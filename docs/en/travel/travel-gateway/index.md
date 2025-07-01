---
title: Travel Gateway overview
description: What is SuperOffice Travel Gateway?
author: SuperOffice Product and Engineering
keywords:
date:
content_type: concept
deployment: onsite
platform: win
---

# SuperOffice Travel Gateway

## What is SuperOffice Travel Gateway?

With the SuperOffice Travel Gateway, you can automate the tasks that the system administrator usually performs in connection with Travel, by specifying that a process should run automatically at a particular time.

## Using SuperOffice Travel Gateway

SuperOffice Travel Gateway can be used both centrally and locally, by users with user-level 0 and by Travel users. A user can be logged in to both SuperOffice CRM and SuperOffice Travel Gateway simultaneously.

The Gateway program is **SOTRVGATE.EXE** and is installed in the SuperOffice Server program folder. The file can be copied manually to your local program folder.

To use the program:

1. Double-click SOTRVGATE.EXE (you can also create a shortcut to the file) to log in to the program. This dialog box appears:
    ![1 -screenshot][img1]

2. Enter your user ID and password and click **OK**.

3. Select **Inactive** under **Execution status** if you want to make changes.

    > [!NOTE]
    > For SuperOffice Travel Gateway to perform activities, you must remember to reset the execution status back to **Active** once you have made any changes required.

4. Check **Start overdue activities immediately on activation** if you want delayed activities to be started when you log on. If you don’t check this option, activities will be delayed until the next time they are actually run, meaning that the existing operational schedule will continue. We’ll now be looking in more detail at adding, editing, deleting, and executing activities.

## Travel gateway as a service

Using SuperOffice Travel Gateway, you can automate the tasks that the system administrator usually performs in connection with Travel, by specifying that a process should run automatically at a particular time.
To install the Travel gateway service, run the SuperOffice client installation file from the Server\Client folder. [Install manually][1] if the client installer fails.

## Start the service

> [!NOTE]
> The Log on as user MUST have full access rights to SO_ARC, so if this is not on the local computer you need to set up another Log on as user. This user must also be granted **Log on as a service rights**.

1. Go to Control panel - Administrative tools - Local services and locate the new *SuperOffice Travel gateway* service. It is not yet started and is currently set up to Log on as "Local System account".

2. Set the service to start automatically and start it so it's running.

## Set up tasks to be executed by the gateway service

The program [SoTrvGate.exe][2] is still used to set up tasks to be executed. Note that you may no longer set execution status here, but it will show if the gateway service is running or not. And if it's currently executing any tasks.

## Automatic login

The SOTrvGate.exe takes username and password as parameters so you may create a shortcut to SOTrvGate.exe

<!-- Referenced links -->
[1]: install.md
[2]: schedule.md

<!-- Referenced images -->
[img1]: media/sotrvgatesignin.gif
