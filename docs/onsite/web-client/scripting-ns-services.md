---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: scripting_ns_services       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Scripting NetServer services
 # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: Tony Yates
so.date: 04.15.2009
keywords:
so.topic: article                # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite              # cloud or onsite
so.client: web              # online, web, win, pocket, or mobile
---

# Scripting NetServer services

## Introduction

Ever since SuperOffice CRM Web application was first released, people have been asking when the web client would have a scripting workflow experience like that in the SuperOffice Windows client. Scripting in the web world has proven challenging for many reasons, but it's nice now to say that, yes, the web client does have a similar scripting workflow experience.

This article will introduce scripting workflows in the web client and provide insight how to get scripting up and running on your web application installation. It's important to note that scripting web events are actually executing on the application server, in NetServer services. This means that NetServer scripting can be deployed to work for the SuperOffice web client, PocketCRM environments, and customer solutions that leverage a NetServer services code base.

### Functional Overview

Scripting in the SuperOffice web application is accomplished by loading either text files or compiled assemblies. With regards to loading text files, SuperOffice web supports VB.NET (.vb) and C# (.cs) files. That is to say that anyone can write a file that contains Visual Basic .NET or C# code and have that execute during the execution of data tasks within the web client. They can also compile code into assemblies and have those used at runtime as well.

SuperOffice .web does not support VBScript or Javascript code through the COM script control use in the windows client. Nor is the .NET VSA scripting system (JScript.net) , Visual Studio Tools for Applications – the .NET replacement for VBA, Boo and any other exotic languages supported.

Unlike scripting in the Windows client, which uses a current system to access what has just been created or saved, scripting in .web is presented in such a way that provides the type being saved/loaded as an argument in the event handler. This provides an easy way to get and store more information about the entity using NetServer, such as built-in caches and the static constructors we know and love, in the context of the call.

The available scripting functions appear as Before and After web service calls. There is also support for conducting Asynchronous calls after an event has occurred. The latter provides the ability for a script to execute long running tasks without affecting the user experience.

![NetServerServiceScripting_750.png][img1]

State is passed between the Before and After methods using a state parameter. This allows the script to persist data between method calls.

There is support for loading multiple scripts simultaneously. For example, two or more script files are able to subscribe to the same BeforeContactSave event, and they will not interfere with each other.

The first version of the scripting does not support user interaction in the web client. It really only caters to intercepting database queries for the retrieval and modifications of data through the service layer.

## How to Configure Scripting

When installing SuperOffice CRM Web, a new scripting section is added to the web applications web.config file. If upgrading from a previous version, optionally run the *SoAppConfig.exe* configuration utility.

**SoAppConfig.exe utility with the Scripting section displayed:**

![x][img2]

The configuration options are:

* Enabling scripting overall.
* The path to the folder where the scripts are stored. If no path is set, the \[ArchivePath\]\\scripts is used.
* The timeout limit is how much time is allowed on synchronous scripts. Asynchronous scripts are not affected by the limit.
* The Script violation limit is the number of times a script can violate the time limit before being disabled.

The *SoAppConfig.exe* utility will the section as seen in Listing One in *web.config*.

*SoAppConfig*: Scripting section added to the application configuration file.

```xml
<Scripting\>
  <add key\="EnableScripting"value\="False" />
  <add key\="ScriptPath"value\="" />
  <add key\="TimeoutLimit"value\="20000" />
  <add key\="MaxTimeouts"value\="5" />
</Scripting\>
```

### Document Section

One more important configuration section is the documents section. The reason for this is that each script runs in a separate appdomain than NetServer services, and the scripting app domain dynamically creates a separate configuration file for that appdomain. This temporary configuration file, named *webScriptEngine.config*, is saved and read from the Document's `TemporaryPath` value. Make sure this path exists and that document permission settings are correct to read and write from this location.

```xml
<Documents\>
  ...
  <addkey\="TemporaryPath"value\="C:\\Temp" />
</Documents\>
```

## Basic NetServer Scripting

### Events

There are Before, After, and AfterAsync events for each method on each web service agent. These are void methods, Sub routines in Visual Basic.NET, where there is no return value. The naming standard of every available scripting event is the exact same as the web service method, prefixed with the Before or After keyword. Asynchronous scripting events are always prefixed with "After" and have an "Async" suffix.

#### \[Before|After\]ServiceMethod\[Async\]

The `Before` method has the same parameters as the agent method.

The `After` method has the same parameters as the agent method + the return value at the end of the param list.

The `AfterAsync` method has the same parameters as the agent method plus the return value at the end of the parameter list, however, changes done to the return value parameter are not passed on.

#### Scripting Method Prototypes

* public static void BeforeGetContactEntity(int contactid, ref object State)
* public static void AfterGetContactEntity(int contactid, ref ContactEntity entity, ref object State)
* public static void AfterGetContactEntityAsync(int contactid, ref ContactEntity entity, ref object State)

* public static void BeforeSaveContactEntity(ContactEntity entity, ref object State)
* public static void AfterSaveContactEntity(ContactEntity entity, ref ContactEntity returnedEntity, ref object State)
* public static void AfterSaveContactEntityAsync(ContactEntity entity, ref ContactEntity returnedEntity, ref object State)

* public static void BeforeGetDuplicates(string name, ref object State)
* public static void AfterGetDuplicates(string name, ref DuplicateEntry\[\] result, ref object State)
* public static void AfterGetDuplicatesAsync(string name, ref DuplicateEntry\[\] result, ref object State)

### Script APIs

All scripts inherit the current NetServer session that initiated the call. This is an important point, because scripts do not need to do any additional authentication. The scripts execute within the same context as the application and are free to use all of NetServer, or any other objects they can create – to do their work. The only restriction is that the scripts can not display any user interface - since these scripts run on the application server.

The script event handlers are raised on the application server, meaning inside the services layer that the web client uses to get all SuperOffice data. Therefore, you have complete access to the NetServer core's lower layer APIs, and you want to use the fastest code possible to conduct your business logic.  

Use NetServer core APIs for data access, not the web service Agent APIs. Use Entities, Rows, and OSQL for your business logic, and this will avoid any re-entrance issues you might have by raising other events that may have event handlers as well.

**Example AfterGetContactEntity single function script:**

```csharp
public static void AfterGetContactEntity(int contactId, ref ContactEntity contact, ref object state)
{
    //Write entities, row(s) or OSQL code
    //Lookup the fetched contact for business logic routines...
    SuperOffice.CRM.Entities.Contact contact \=
         SuperOffice.CRM.Entities.Contact.GetFromIdxContactId(contactId);

    //But make updates to the ContactEntity that will be returned to the web client
    //and let the user decide if any changes should be saved where its appropriate.
    contact.Name += "(added by script)";
    contact.Department += "(ScriptDemo)";
}

Script Error Logging, Tracing

Script compilation and runtime errors are logged using normal NetServer logging features. The script itself may contain an OnError( errorDetails ) event handler that can report errors to the script author.

public static void OnError(string message)
{
    ...
}
```

### Register Scripts

To enable your scripts, simply drop the script files (or assemblies) into the folder specified in the Scripting section of the configuration file. Remember to flush in order to get 6.web aware of the new scripts.dll.

## Three Ways to Deploy and Run Scripts

### Single Function

The simplest form of scripting is the single function script. This is accomplished by adding a text file that contains a single method declaration with the correct extension (.cs or .vb) into the scripting folder. The following code demonstrates this technique. The example demonstrates manipulating the name and department of the contact after it is retrieved from the database, but before it is returned to the client.

**Example AfterGetContactEntity single function script:**

```csharp
public static void AfterGetContactEntity(int contactId, ref ContactEntity contact, ref object state)
{
    contact.Name += "(added by script)";
    contact.Department += "(ScriptDemo)";
}
```

### Full Class

Another option is to write a full class and deploy it as a file. This allows you to structure your code better, as well as the option to refer to other assemblies.

When writing a full class file, you must add the keyword `$FullClass` at the top of the file. You can also add references to other assemblies that contain types used by this class by adding the `$ReferencedAssembly` keyword; followed by the full path to the referenced assembly. You must also have a `static void Main` method. This is a framework requirement.

**A full class example that demonstrates changing the name and department of a contact:**

```csharp
//$FullClass
//$ReferencedAssembly: C:\\MyAssemblies\\SuperOffice.Services.dll
using System;
using System.Text;
using System.Windows.Forms;
using SuperOffice.CRM.Services;
namespace MyScriptClass
{
    public static class CSharpScript
    {
        static void Main() { }
        public static void BeforeGetContactEntity(int contactId, ref object state)
        {
            //Do  Magic Here
        }
        public static void AfterGetContactEntity(int contactId, ref ContactEntity contact, ref object state)
        {
            contact.Name += "(Magic)";
            contact.Department += "(Scripted)";
        }
    }
}
```

### Assembly

Neither single function files, nor class files, are easy to debug. To be able to debug your scripts you must pre-compile them into a standalone assembly. As long as the versions referred to in your assembly comply with the running 6.web version all you need to do is drop the dll into the script folder. By adding the pdb file as well, debugging should be a piece of cake.

### Permissions

Just as a reminder, you will need to ensure that the IIS process has read permissions on the scripting folder. That is generally the ASP.NET and Network Service accounts. In most cases, setting the `APPPOOL\YourAppPoolName` permissions will work.

The image below demonstrates setting the `apppool` permissions.

![x][img3]

## Conclusion

In this article you have learned about SuperOffice Scripting in the web world. You have seen how to configure the web client for scripting, as well as seen how scripting event methods are declared, and finally examples of how this might like and are used.

Video References:

* [Scripting in the Web World][1]
* [Web Client and Interactive NetServer Web Service Scripts][2]

<!-- Referenced links -->
[1]: https://community.superoffice.com/en/developer/videos/video-player/?videoId=138
[2]: https://community.superoffice.com/en/developer/videos/video-player/?videoId=841

<!-- Referenced images -->
[img1]: media/netserverservicescripting_750.png
[img2]: media/scriptingsetup.png
[img3]: media/permissions2.png
