---
title: Creating a custom Data Exchange agent
uid: custom_data_exchange_agent
description: How to create a custom Data Exchange agent
author: 
so-date: 06.24.2016
keywords: ede, dbi
so.topic: tutorial
#so.envir:
#so.client:
---


# Creating a custom Data Exchange agent

This tutorial will demonstrate how to create your own custom [data exchange agent][1].

## Architecture

All you really need to create an agent is to create an executable or web service which supports reading our proprietary XML format as input, and return our proprietary XML format as output. The input XML will normally look something like this:

```XML
<?xml version="1.0" encoding="utf-8" ?>
<request version="1.1">
  <parameters>
    <string name="agentParameter">Any parameter in agents config</string>
    <string name="dbi.agentId">1</string>
    <string name="dbi.debug">1</string>
    <string name="dbi.event">begin</string>
    <string name="dbi.lastExecution">2011-05-06 13:32:35</string>
    <string name="dbi.started">2011-05-06 13:34:34</string>
    <string name="taskParameter">Any parameter in tasks config</string>
  </parameters>
</request>
```

The parameters will contain some default parameters we always add, as well as any custom parameters you have configured for the agent and the task. The resulting output XML should look something like this:

```XML
<?xml version="1.0" encoding="utf-8" ?>
<response version="1.1">
  <parameters>
  </parameters>
  <object>
    <string name="column.size">3</string>
    <string name="column.0">1</string>
    <string name="column.1">ACME Inc</string>
    <string name="column.2">+1 555 123-4567</string>
  </object>
</response>
```

## Implementation

A very simple platform that can be used to create an agent is ASP.NET. By writing a simple ASPX page and placing it under an IIS Application folder, we have essentially created a web service. Here is the example code for such an agent:

[!code-html[HTML](includes/myagent.aspx)]

As you can see, this agent will return 2 companies, each with a primary key, name, and phone number. By placing this code in the file *myagent.aspx* and placing it in an IIS folder with script execution rights, you should be able to access it with a regular browser:

![01 -screenshot][img1]

## Configuration

We can now go ahead and configure this agent, a task, and a CRMScript to retrieve these companies inside Expander Data Exchange. First, we will create the CRMScript with the following code:

```crmscript
#setLanguageLevel 3;

DbiControl dbiControl = getDbiControl();
String event = dbiControl.getParameter("dbi.event");
Integer agentId = dbiControl.getParameter("dbi.agentId").toInteger();
Bool debug = dbiControl.getParameter("dbi.debug").toInteger() == 1;

if (event == "receiveObject")
{
  Map object = dbiControl.getObject();
  String id = object.get("column.0");
  String name = object.get("column.1");
  String phone = object.get("column.2");
  Company c;
  c.loadFromAgentAndKey(agentId, id);
  c.setValue("name", name);
  c.setValue("phone", phone);
  c.setValue("dbi_agent_id", agentId.toString());
  c.setValue("dbi_key", id);
  c.setValue("dbi_last_modified", c.getValue("dbi_last_modified"));
  c.setValue("dbi_last_synchronized", getCurrentDateTime().toString());
  Integer newId = c.save();
  if(debug) print("Company: " + newId.toString() + "      \r\n");
}
```

Just create this as a script under **System design > Scripts**. Then, we can create our agent:

![02 -screenshot][img2]

Then we can create a task underneath this agent and relate it to our newly created script:

![03 -screenshot][img3]

Choose any schedule you feel like, such as every hour.

## Execution

The best way to test an Expander Data Exchange task is to execute the dbi.exe program from a dos window. Then you will be able to view any print statements inside the CRMScript, as well as the XML which is sent to the agent. To do this, you need to know the numeric ID of the task you just executed, which can be found in the URL when you edit (or hover the link to edit) the task ("http://.../..&id=x"). Then you can execute the following command:

`dbi.exe -debug -asap 1 -force -maxDebug -dump support.company.com`

| Parameter | Description |
|---|---|
| -debug | print debug statements in CRMScript |
| -asap 1 | execute this task right away |
| -force | execute right now, even if the schedule says something else |
| -maxDebug | print lots of info |
| -dump | show the XML we will send to the agent |
| support.company.com | our hostname |

Your output should (hopefully) look something like this:

![04 -screenshot][img4]

...and inside Service you should now be able to find the entries:

![05 -screenshot][img5]

<!-- Referenced links -->
[1]: ../../index.md

<!-- Referenced images -->
[img1]: media/image001.jpg
[img2]: media/image002.jpg
[img3]: media/image003.jpg
[img4]: media/image004.jpg
[img5]: media/image005.jpg
