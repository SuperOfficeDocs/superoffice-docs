---
title: Debug Web client
uid: debug_web_client
description: Debug Web client
author: {github-id}
keywords:
so.topic: howto
so.envir: onsite
so.client: web
---

# Debug Web client

Enable debug for Sales & Marketing Web client or Remote web services. When locating problems in Sales & Marketing Web client, Service, Pocket CRM, or any other tool that use SuperOffice Remote web services (NetServer).

You can enable the debugging in a SuperOffice application that configures Web installation and/or NetServer and is called Product Configurator. There are 2 ways how you can start it - from the Windows Start menu and directly from the installation directory.

## From the Start menu

To do it click on the Start button and type in "Product Configuration" and click on the one that has the name of the program you want to troubleshoot.

There are multiple ways how [SuperOffice can be deployed][1]. If SuperOffice Web and NetServer are installed separately, or if your company’s SuperOffice installation has more than one NetServer, make sure you start the Product configuration that has the name of the component you want to troubleshoot.

## From the installation folder

In the file explorer, navigate to the component's Config folder (example: *C:\SuperOffice\SuperOffice Web\Config*) and double-click on the app **SoAppConfig.exe**.

> [!CAUTION]
> When you open the Product Configuration tool, **all SuperOffice Web users will be logged out** from the SuperOffice CRM. They will be able to log in right away and keep working, however, when you will save the changes made in the configuration tool, all users will be logged out again.

When you have the Product configuration application open:

1. Click on the **Diagnostics (1)** section. In the field (2) you can define a path where the log file should be saved. Then add a tick next to the **Display Advanced Settings (3)**, which will let you specify how many details you want in the debugging log file.

    ![image0sx5s.png -screenshot][img1]

2. Click **Next** to go through the whole configuration wizard and click **Finish**. Once you finish the wizard, the Report configuration product wizard will start automatically. You can close it if you don’t want to debug reports. Then the log file will be created and errors will start to be logged.

> [!NOTE]
> We recommend recreating the issue and turning off the logging as soon as you have the debug information in the log. By leaving debugging On, you risk creating a huge size log file, which can eventually **affect performance** or use all server resources and crash it. Heavy logging will reduce performance, so only turn on this when you need to generate a log file to locate a problem.

## How to know which level of details I want to include in the logs?

In a generic troubleshooting case you are interested to see errors in Web/NetServer, then add a tick next to **Log error** and click through the wizard.

SuperOffice Inbox and Pocket CRM use NetServer service to send emails. If you want to troubleshoot email sending or receiving via the NetServer, add a tick next to **Log e-mail** and in the field next to this option define where the log files should be created. Logging will create 2 files - one for incoming emails (communication with IMAP server) and one for outgoing emails (communication with SMTP server). This is not a debug log for MailLink.

## How do I find the location of Web client/NetServer log file without kicking out SuperOffice users from the session?

If you know that the debugging has been enabled and you just want to find a location of the file without making all users log out from the session, you can do it directly in the config file. Find a *.config* file of the component you are debugging and in the `<Diagnostics>` section `<add key="LogFolder" value="C:\Log">` will store the path to the log file.

## How do I enabling debugging directly in the config files?

You can set the same logging parameters directly in the *web.config* file in the `<Diagnostics>` section.

## NetServer start-up and performance

SuperOffice Web always takes a long time to start up initially because IIS needs to initiate both the .NET common language runtime and NetServer. As soon as the w3wp.exe IIS work process is up and running you'll see that the performance is better.

We do, however, also have some online services configurable in the *web.config* file. If you experience poor performance on the second login, you may turn off *Logging to SuperOffice Research & Product Developement.* Go to Diagnostics and turn off Log to SuperOffice Research & Product Developement.

## NetServer diagnostics

[Turn on/off in web.config][3]

<!-- Referenced links -->
[1]: ../security/deployment-scenarios.md
[2]: ../config/web-config.md
[3]: netserver.md

<!-- Referenced images -->
[img1]: media/image0sx5s.png
