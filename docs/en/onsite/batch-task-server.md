---
title: SuperOffice Batch Task Server
uid: batch_task_server
description: SuperOffice Batch Task Server
author: {github-id}
keywords:
topic: article
envir: onsite
client: web
---

# SuperOffice Batch Task Server

> [!NOTE]
> If you are running SuperOffice Sales & Marketing Web with remote NetServer web services, this must be set up on the server running NetServer web services.

First introduced in SuperOffice Web version 6.3, background computing plays an important role that accomplishes long-running tasks in the background while allowing the user to continue working without being affected. Since 7.0 the Batch Tasks are configured to run in the IIS process instead of outside. The standard *web.config* file declares:

![x -screenshot][img1]

The tasks are started by the IIS process and run on the web server rather than on a separate batch task service. This has simplified configuration and deployment a lot.

[This tutorial][1], which will also drill down into how built-in tasks get started and demonstrate how this extensibility point can be leveraged for other applications.

The Batch task service is automatically set up during installation of the Sales & Marketing web, you'll find it running under services on the server where IIS is running. The name is the same as the website name + Batch Task Server. If you have more than one web installation, you will find one batch server service for each install.

![x -screenshot][img2]

When the server is started, it will instantiate and connect to NetServer using the configuration settings found in the [SoBatchService.exe.Config][2] file.

**The main difference between the web.config file and the SoBatchService.exe.Config file is in the Session.mode. For the Batch task server the session.mode = Process and not HttpContext.**

## Batch task server

The batch task service is used for time-consuming operations like:

* Printing reports
* Updating inbox
* Performing mail merge
* Publishing new user-defined fields (from version 7.5)
* Regenerate Status Monitors (from version 7.5)

When the batch task server is in use the user will see a small icon in Sales & Marketing web

![x -screenshot][img3]

Whenever a task is running the area at the top right next to the free-text search area will show an animated icon of two wheels in motion to indicate that one or more batch tasks are running. Next to the icon, a text will be displayed telling the user who's task is currently running if the user only has one task. If the user has more than one task, this text will display the number of tasks the user has, and the tooltip will display more details about the status and name of the tasks.

## Problem with tasks timing out?

Task execution can timeout. This is handled in the batch processor in NetServer. If the queue of waiting tasks becomes too big, the administrator of the system should either increase the number of simultaneous tasks that can run in this service, install multiple instances of the service on one machine,  or set up more than one server running batch processing services. Tasks will be found in the database table `crm7.batchtask`.

<!-- Referenced links -->
[1]: ../api/tutorials/sem-batch-processing/index.md
[2]: ../api/config/batchservice.md

<!-- Referenced images -->
[img1]: media/runtaskinprocess.png
[img2]: media/batchtaskservice.png
[img3]: media/webbatchprocessing1.png
