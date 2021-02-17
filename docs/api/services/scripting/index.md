---
title: scripting_ns_services       
description: Scripting in NetServer services
author: Tony Yates
so.date: 04.15.2009
so.topic: concept
keywords:
so.envir: onsite              # cloud or onsite
so.client: web              # online, web, win, pocket, or mobile
---

# Scripting in NetServer services

Ever since SuperOffice CRM Web application was first released, people have been asking when the web client would have a scripting workflow experience like that in the SuperOffice Windows client. Scripting in the web world has proven challenging for many reasons, but it's nice now to say that, yes, the web client does have a similar scripting workflow experience.

This article will introduce scripting workflows in the web client and provide insight into how to get scripting up and running on your web application installation. It's important to note that scripting web events are actually executing on the application server, in NetServer services. This means that NetServer scripting can be deployed to work for the SuperOffice web client, PocketCRM environments, and customer solutions that leverage a NetServer services code base.

## Functional overview

Scripting in the SuperOffice web application is accomplished by loading either text files or compiled assemblies. With regards to loading text files, SuperOffice web supports VB.NET (.vb) and C# (.cs) files. That is to say that anyone can write a file that contains Visual Basic .NET or C# code and have that execute during the execution of data tasks within the web client. They can also compile code into assemblies and have those used at runtime as well.

SuperOffice .web does not support VBScript or Javascript code through the COM script control use in the windows client. Nor is the .NET VSA scripting system (JScript.net), Visual Studio Tools for Applications – the .NET replacement for VBA, Boo, and any other exotic languages supported.

Unlike scripting in the Windows client, which uses a current system to access what has just been created or saved, scripting in .web is presented in such a way that provides the type being saved/loaded as an argument in the event handler. This provides an easy way to get and store more information about the entity using NetServer, such as built-in caches and the static constructors we know and love, in the context of the call.

The available scripting functions appear as `Before` and `After` web service calls. There is also support for conducting **asynchronous calls** after an event has occurred. The latter provides the ability for a script to execute long-running tasks without affecting the user experience.

![scripting][img1]

**State** is passed between the Before and After methods using a `state` parameter. This allows the script to persist data between method calls.

There is support for **loading** multiple scripts simultaneously. For example, two or more script files can subscribe to the same `BeforeContactSave` event, and they will not interfere with each other.

The first version of the scripting does not support user interaction in the web client. It really only caters to intercepting database queries for the retrieval and modifications of data through the service layer.

## Continue reading

* [Configuration][1]
* [Basic scripting][2]
* [Three ways to run scripts][3]

<!-- Referenced links -->
[1]: configure.md
[2]: basic-scripting.md
[3]: run-scripts.md

<!-- Referenced images -->
[img1]: media/netserverservicescripting-750.png
