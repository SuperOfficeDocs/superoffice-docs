---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: batch_task_server       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: SuperOffice Batch Task Server # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: article             # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite            # cloud or onsite
so.client: web              # online, web, win, pocket, or mobile
---

# SuperOffice Batch Task Server

> [!NOTE]
> If you are running SuperOffice Sales & Markting Web with remote NetServer web services, this must be set up on the server running NetServer WebServices.

First introduced in 6.web, version 6.3, background computing plays an important role that accomplishes long-running tasks in the background, while allowing the user to continue working without being affected. Since 7.0 the Batch Tasks are configured to run in the IIS process instead of outside.The standard web.config file declares:

![x][img1]

The tasks are started by the IIS process, and run on the web server rather than on a separate batch task service. This has simplified configuration and deployment a lot.

On [DevNet - Developers Club][1] you'll find an article which will also drill down into how built-in tasks get started and demonstrate how this extensibility point can be leveraged for other applications.

The Batch task service is automatically set up during install of Sales & Marketing web, you'll find it running under services on the server where IIS is running. The name is the same as the web site name + Batch Task Server. If you have more than one web installation, you will find one batch server service for each install.

![x][img2]

When the server is started, it will instantiate and connect to NetServer using the configuration settings found in the SoBatchService.exe.Config file (see path to executable)

**The main difference between the web.config file and the SoBatchService.exe.Config file is in the Session.mode. For the Batch task server the session.mode = Process and not HttpContext.**

## Batch task server

The batch task service is used for time-consuming operations like:

* Printing reports
* Updating inbox
* Performing mail merge
* Publishing new user-defined fields (from version 7.5)
* Regenerate Status Monitors (from version 7.5)

When the batch task server is in use the user will see a small icon in Sales & Marketing web

![x][img3]

Whenever a task is running the area at the top right next to the free-text search area will show an animated icon of two wheels in motion to indicate that one or more batch tasks are running. Next to the icon, a text will be displayed telling the user which task is currently running if the user only has one task. If the user has more than one task, this text will display the number of tasks the user has, and the tooltip will display more details about the status and name of the tasks.

## Problem with tasks timing out?

Task execution can timeout. This is handled in the batch processor in NetServer. If the queue of waiting tasks becomes to big, the administrator of the system should either increase the number of simultaneous tasks that can run in this service, install multiple instances of the service on one machine,  or set up more than one server running batch processing services. Tasks will be found in the database table `crm7.batchtask`.

<!-- Referenced links -->
[1]: https://community.superoffice.com/en/content/content/webclient/Background-Computing-and-Batch-Processing/

<!-- Referenced images -->
[img1]: media/runtaskinprocess.png
[img2]: media/batchtaskservice.png
[img3]: media/webbatchprocessing1.png
