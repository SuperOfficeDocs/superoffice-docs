---
title: Background computing and batch processing
uid: background_computing_and_batch_processing
description: Background computing and batch processing
author: {github-id}
so.date: 04.15.2009
keywords:
so.topic: tutorial
# so.envir:
# so.client:
---

# Background computing and batch processing

This article will introduce you to the high-level aspects of SuperOffice web background computing, drill down into how built-in tasks get started and demonstrate how this extensibility point can be leveraged for other applications.

## Introduction

Certain tasks related to CRM are potentially very time consuming. Performing a mail-merge, for example, has the potential of taking minutes to complete. Within the context of any application, conducting such a time-consuming task synchronously would be disastrous for the user-experience. SuperOffice Background Computing (SBC), sometimes referred to as Batch Processing,  was created to counter such an event, and enhance the overall experience and functionality of the platform.

The remainder of this article will focus on how Background computing is accomplished in SuperOffice SuperOffice web.

## Server Event Manager

At the heart of SuperOffice web resides a component called the Server Event Manager (SEM). SEM is a host for plug-ins that the web application uses for various utility functions, such as checking for new appointments and executing background computing - or batch tasks.

### Invocation

How SEM works is simple, but clever. As seen in the figure below, all requests to the web server are forwarded to SEM. There are three distinct types of requests that can be sent to the web server: GET, POST and AJAX.

GET and POST requests are generally issued when an action occurs from within the main form of the web application; such as clicking the New button to create a new company.

AJAX requests refer to all requests sent to the server via the SuperOffice web AjaxMethodDispatcher, an AJAX utility class used for submitting both synchronous and asynchronous requests to the web server.  

**Conceptual overview of the SuperOffice web ServerEventManager workflow:**

![x][img1]

Each request sent to SEM is treated like a heartbeat. The idea is that SEM should have a healthy rhythm and not beat too fast. If the rhythm beats too fast, the server would incur unnecessary CPU utilization and potentially slow the server down. To avoid that, SEM checks the current time to determine if enough time has elapsed since the last heartbeat. If there has been SEM summons each plug-in into action, otherwise SEM simply returns to a resting state.

In the case of too few heartbeats, every two minutes the web client issues a built-in "Keep-Alive" AJAX call from the client to the server. This occurs due to an unrelated task but is also beneficial in the context of SEM.

The execution of each plug-in begins with a call to the plug-in BeginExecute method, see the Server event manager routine illustration below. BeginExecute returns a ServerEventObject datatype which contains three properties: MappingName, EventType, and Data. MappingName is the name of the SEM plug-in, EventType is the name of the client-side event to which this plug-in relates and Data can be anything the server wants to send back to the client, such as a structure that represents a person with a first and last name.

For each plug-in SEM executes, the results are collected and returned to the client by "piggy-backing" the response in the form of a ServerEventObjResult data type. This type contains a single property called ServerEvents and represents an array of ServerEventObject types.

A ServerEventObject, specifically the EventType and Data properties, becomes very important when the response reaches the client.

### Plug-In Conditions

For each SEM plug-in discovered, there are a set of conditions that define when the plug-in is allowed to be called. Each condition is checked verified true, the SEM plug-in is invoked and begins processing.

**Condition Definitions:**

| Condition | Data Type, Definition |
|---|---|
| post | Boolean, Defines whether the plug-in can be invoked by a POST request. |
| get | Boolean, Defines whether the plug-in can be invoked by a GET request. |
| ajax | Boolean, Defines whether the plug-in can be invoked by an AJAX request. |
| interval | Integer, Defines how often the plug-in can be invoked in seconds. |
| protocol | Not Implemented |
| isdialog | Boolean, Defines whether the plug-in is invoked by a request from a dialog. |
| ismainpage | Boolean, Defines whether the plug-in is invoked by a request from a main page. |

Have you ever wondered how sometimes the Invitation dialog just appears out of nowhere, letting you know that you have an appointment? This is all orchestrated by SEM. As long as requests are sent to the server - keeping the heartbeat active, SEM checks to determine if the Invitation plug-in meets all of the conditions. If it does, it is allowed to run and fetch new appointments for the logged-on user. When new appointments are discovered, the results from the plug-in are sent back to the client in the response and, the invitation dialog is opened by the application and displayed to the user.

So how does the completion of the background computing plug-in actually raise the ONINVITATIONPOPUP event in the web client?  Remember, each SEM plug-in returns a ServerEventObjResult type containing one or more ServerEventObject types. Each ServerEventObject has an EventType property that defines an event that is raised on the client. This is the vital link between the plug-in result and the type of event that is raised on the web client.

Open the SoServerEventConfiguration.config file and you will see contents similar to what is shown below.

In addition to containing the conditions that must evaluate to true before SEM executing the SoBatchServerEventPlugin plug-in, the plugin element contains the name of the SEM plug-in and more importantly, the event type that is raised in the web client for each ServerEventObject returned by this plug-in.

**Contents of the SoServerEventConfiguration.config file:**

```xml
<plugins>
  <plugin name="SoBatchServerEventPlugin" eventtype="ONBATCHEVENT">
    <conditions>
    <condition type="post">true<condition>
    <condition type="get">true<condition>
    <condition type="ajax">true<condition>
    <condition type="interval">30<condition>
    <condition type="soprotocol"><condition>
    <condition type="ismainpage">true<condition>
    <condition type="isdialog">true<condition>
    <conditions>
  <plugin>
<plugins>
```

Regardless of the type of request, when the call to SEM returns and a ServerEventObjResult is returned, the client passes the result to the client-side JavaScript ServerEventManager object.

The ServerEventManager then, for each ServerEventObject in the ServerEventObjResult, passes the ServerEventObject into the invokePageHandler method. The invokePageHandler method in turn calls the javascript PageEventHandler object and invokes the onServerEvent method. The onServerEvent method actually invokes the event, notifying each subscriber and passing the data returned in the ServerEventObject.Data property.

Finally, when control from the PageEventHandler object returns, the ServerEventManager javascript object invokes an AJAX server-side method that will call EndInvoke on each plug-in that returned a ServerEventObject result.

**Server Event Manager Routine:**

![x][img2]

## Batch Event Server Plugin and the Batch Service

Out of the box, SuperOffice web version 6.3 comes with two SEM plug-ins; the SoInvitation and SoBatchServer plug-ins. The actual name for the SoBatchServer plug-in is SoBatchServerEventPlugin, but for the remainder of this article, I'll refer to it simply as SBS.

SBS itself is based on a plug-in model. SBS comes out of the box with 3 standard plug-ins; Mail Merge, Reports, and Mail Cache Update. As you can imagine, each is designed to do what their names indicate: one to conduct mail merges, one for generating reports, and one to check for new emails, respectively. The best part about batch processing is that it too is an extensibility point.

### Batch Processing

The conceptual overview of processing batch tasks is seen in below. The basic idea is that a user will create a batch task (#1 in the figure), such as conducting a mail-merge.

When the client sends a mail-merge task to the web server, it sends an asynchronous request to the web server with the parameters of the mail merge operation. The request contains a JavaScript callback method that is called when the operation has been completed, however, this does not represent the completed state of the batch task; just the invocation of it. When the request reaches the web server, it reacts by contacting the application server and telling it about the new task.

The application server then takes the mail-merge parameters and creates a new BatchTask entry in the database. The new entry contains all of the required information for the SoBatchService to execute the batch task.

**Batch processing conceptual overview:**

![x][img3]

Now that a user has created a batch task, the second dimension to this process is the SBS polling the database via the application server for all batch tasks created by the current user. When batch tasks are returned, SBS returns all the information about each task, including a summary tooltip shown when hovering the mouse over the batch processing indicator (see below). This is also when clients are given the opportunity to take action based on the results of the task (more on that in a second).

**Batch processing indicator:**

![x][img4]

Meanwhile, the SoBatchService (#3 in the figure) windows service polls to discover pending tasks and process them when found. As tasks are processed, the SoBatchService updates the status of batch tasks in the BatchTask table. Consequently, each subsequent call to SBS updates the available tooltip for the client but more importantly raises the ONBATCHEVENT client-side event. This event notifies each subscriber that there is potentially new information available. It is then up to subscribers' event callback to determine the state of the task and update the client browser accordingly. In the case of a mail-merge, an information dialog box is displayed informing the user whether the operation was successful or not.

### Database Role

As seen below, the database plays a vital role in batch processing; it is at the center of the Background Computing universe. The bottom shows the three key tables that hold all information related to batch tasks.

The BatchTaskDefinition table contains details about each available batch task plug-in discovered by the SoBatchService. The discovery process is a little bit like Lazy Loading in the respect that, if a submitted batch task does not already contain a BatchTaskDefinition, a new BatchTaskDefinition record is created.

The BatchTask table defines all batch tasks that either waiting to start or are running. It also contains the state of each batch task. Tasks are removed when they have been completed.

Because a batch task may require a complex set of parameters to execute, such as reports requiring layout, language, and other settings, all parameters for a task are stored in a binaryobject record. The container for task parameters is a StringDictionary datatype (located in the SuperOffice.CRM.Services namespace) defined in NetServer. This facilitates passing any number of required parameters to run a particular task.

**UML sketch of the three aspects of batch processing:**

![x][img5]

**Batch processing tables:**

![x][img6]

## Techno-Babble

The remainder of this document describes the process of creating a custom batch task. It is highly technical and written for developers.

## Constructing a Custom Batch Task

The custom batch task I will demonstrate is not necessarily an ideal batch task, but it will demonstrate all of the concepts required to be run as a custom batch task, and return a defined result to the SuperOffice web application.

### Creating the Plug-In

The bare minimum needed to get away with creating a custom batch task is a class library with a reference to the SoBatchProcessing.dll library. Contained within the SoBatchProcessing library are types required to easily run a batch task. The quickest and recommended way to create a custom batch task is to create a class that inherits from BatchTaskBase. Now all you need to do is override the Run method, decorate the class with the BatchTask attribute and define the name of the plug-in. That is all there really is to create a custom batch task. The code below shows a barebones batch task plug-in that demonstrates a couple of interesting concepts. The public constants are used to define the name of the plugin and the interval at which SEM should check for progress. The latter is demonstrated in the next section. The Run method demonstrates how to use the base class GetTaskInfo method to access the BatchTaskInfo type that defines everything needed to execute this batch task. Notice how the ParameterObject property of the BatchTaskInfo is used to access the retrieve all parameters passed to this batch task.

Batch tasks are ideal for long-running operations. You probably do not want to leverage batch tasks for quick tasks that you would probably be better completed in a server-side AJAX method. Here the task is just being put to sleep for 15 seconds.

Although the Run method simply returns a boolean, indicating whether the task was completed successfully or not, the way data is passed back to the client is by using the base class SetResult method. This is used to return a string value.

**Custom Batch Task:**

```csharp
[SoWebObject(SampleAjaxClass.MappingName)]

class SampleAjaxClass : IWebObject
{
conststring MappingName = "SampleAjaxClass";

public SampleReturn GetSomeData(string args)
    {
       SampleReturn sr = newSampleReturn();

       StringDictionary quoteParams = newStringDictionary();

       quoteParams["args"] = args;


       ServerEventManager.SetInterval(

            DevNet.BatchTasks.SampleBatchPlugin.PluginName,

            DevNet.BatchTasks.SampleBatchPlugin.CheckingInterval);


        BatchTaskInfo bti = new BatchTaskInfo();

        bti.Name          = DevNet.BatchTasks.SampleBatchPlugin.PluginName;

        bti.Description   = "Sample Batch Task";

        sr.BatchTaskId    = BatchData.SaveBatchTaskInfo(bti, quoteParams);

        return sr;
    }
}

public class SampleReturn
{
    public int    BatchTaskId    = 0;

    public string SampleResults  = String.Empty;

    public string Error          = String.Empty;
}
```

### Creating An Ajax Method

In order for the custom batch task to be useful, a new record must be created in the table BatchTask. The new record defines the name and other parameters for the plug-in. The easiest way to accomplish this in the web world is to create a server-side AJAX method and do the actual record creation in the body of the method. This is really only feasible when in local mode and there is not a firewall between the web application and application server. If both are hosted on the same machine, then this perfectly fine. Although not demonstrated here, a better approach would be to from the AJAX method call a custom web service on the application server and create the record there. This scenario is required when the web application's service mode is set to remote and communication with the application server is by using web services through a firewall.

Server-side AJAX methods for the SuperOffice web client are easy to create. You can do this by simply creating a class that inherits from the IWebObject interface and decorate the class with the SoWebObject attribute. As seen below, there are four important things to consider when creating a batch task. The first is to have a type that is returned to the client to be sure the batch task was created successfully. The second is to organize any parameters needed by the batch task in a StringDictionary and pass that into the BatchData.SaveBatchTaskInfo method. The third important thing is to set the ServerEventManager interval, which defines how often the ServerEventManager is allowed to call the plug-in. The final and most important thing is to actually create an instance of a BatchTaskInfo type, defined its properties, and then save it. This is facilitated by using the BatchData type. BatchData is primarily a data-access class and resides in the SoDatabase.dll. In the event of deploying the web application in remote mode, then you will be required to create a web service on the application server and call it to create the BatchTaskInfo using BatchData.

**A Sample Ajax method that creates a new BatchTask entry in the database:**

```javascript
/// 
/// Sample class. It will be created at load.
/// 
var Sample = new _Sample();
function _Sample(){}
 
// Display the results of a finished report
_Sample.prototype.ShowSampleReport=function(obj)
{   
    g_debug.trace("ShowSampleReport(" + obj.Response + ")", 
"Sample.ShowSampleReport");
    Dialog.Information('SuperOffice SIX', 
                       obj.Name + '\r\n' + obj.Response);
};
 
// Handle and display information from a custom object
_Sample.prototype.GetSample=function(obj)
{
 
    g_debug.trace("Sample.GetSample(" + obj + ")", 
"Sample.GetSample");
    AjaxMethodDispatcher.CallASync("Sample.GetSampleSent",
              "Sample.Error","","","DevNet.AjaxLib.SampleAjaxClass.GetSomeData", obj);
};
 
_Sample.prototype.GetSampleSent=function(obj)
{   
    Dialog.Information('SuperOffice SIX', 
'Get sample task has been sent to the Batch service. ID: ' + obj.BatchTaskId);
};
 
_Sample.prototype.Error=function(err,context)
{
    Dialog.enableWindow(window);
    Dialog.CloseProgressBox();
    Dialog.Information('SuperOffice SIX', err);
};
```

### Getting Notified

Oki, it is great that you can invoke the AJAX method and have the custom batch task executed, but how do you get notified on the client when that task has completed? Remember the text about subscribing to the ONBATCHEVENT event? The first line in the code below contains the necessary JavaScript code to subscribe to the event ONBATCHEVENT. By placing this at the top of the file, the event will be registered as soon as the client loads it. The first parameter is the name of the event type to subscribe to. The second parameter is a unique name that identifies this subscription and the third parameter is the callback function that is invoked when the event is raised.

I wanted to isolate this code to point out a few things about it. As of this writing, there is no helper method that eliminates a lot of the redundant code seen in the OnSampleEvent method. It does not look redundant here because it is not, however, for each ONBATCHEVENT subscription, the callback method looks almost identical - the only difference being the name of the plug-in.

**Defines how to subscribe to and listen for the event ONBATCHEVENT:**

```csharp
// Subscribe to Server Event
PageEventHandler.addServerEvent("ONBATCHEVENT", "sampleevent", 
"Sample.OnSampleEvent(obj)");   
 
/// 
/// Sample class. It will be created at load.
/// 
var Sample = new _Sample();
function _Sample(){}
 
// Handle and display information from a batch object
_Sample.prototype.OnSampleEvent=function(obj)
{
    g_debug.trace("OnSampleEvent(" + obj + ")", "Sample");
 
if( obj.BatchTaskInfos != null && obj.BatchTaskInfos.length > 0 )
    {
        for( var t=0; t<obj.batchtaskinfos.length; ++t )>
        {
            try
            {
                if(obj.BatchTaskInfos[t].Name == "SampleBatchPlugin")
                {
                    if(obj.BatchTaskInfos[t].State == 4 || 
                       obj.BatchTaskInfos[t].State == 5)
                    {
                        Batch.SetStoredObject('SampleBatchPlugin_' + t, 
                                              obj.BatchTaskInfos[t]);
                        setTimeout(
   "Sample.ShowSampleReport(Batch.GetStoredObject('SampleBatchPlugin_" + t + "'));",
                     200);
                    }
                }
            }catch(e)
            {
                Dialog.Information('SuperOffice SIX', 'An exception ocurred: ' + e);
            }    
        }
    }
};
```

The OnSampleEvent method iterates over the returned status of results of each batch task in the obj.BatchTaskInfos collection looking for the one plugin we are interested in. In this case, it is the SampleBatchPlugin plug-in. Once it is found, the code checks to determine if the status is set to succeeded or failed. When one of these conditions is true, it calls a method to set the results and then immediately invokes a local method that will display the results to the user.

## Conclusion

This article has covered the full breadth of SuperOffice Background Computing. You have been introduced to the Server Event Manager, and explained how intricate of a role it plays in the execution of batch tasks. You have been given insight into how a client action begins the series of steps required to successfully create a batch task, monitor the tasks progress, as well as invoke a callback on the client when the batch task has been completed. Finally, you have seen code that can be used to successfully execute a custom batch task through the web application.

<!-- Referenced images -->
[img1]: media/servereventmanager4-initial.png
[img2]: media/servereventmanagerillustrated-sm.png
[img3]: media/batchservereventplugin2sm.png
[img4]: media/batchprocessing1.png
[img5]: media/batchprocessing2.png
[img6]: media/tables-500.png
