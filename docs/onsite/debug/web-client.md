---
title: Debug Web client
uid: debug_web_client
description: Debug Web client
author: Bergfrid Dias
so.date: 12.10.2021
keywords: debug, Product Configurator, SoAppConfig.exe
so.topic: howto
so.envir: onsite
so.client: web
---

# Debug Web client

Enable debug using the **Product Configurator** when locating problems in the Sales & Marketing Web client, Service, Pocket CRM, or any other tool that uses SuperOffice Remote web services (NetServer).

You can start the Product Configurator in two ways:

* From the Windows Start menu
* Directly from the installation directory

> [!CAUTION]
> When you open the Product Configuration tool, **all SuperOffice Web users will be logged out** from the SuperOffice CRM. They will be able to log in right away and keep working, however, when you will save the changes made in the configuration tool, all users will be logged out again.

You can also [work with the configuration file directly][2].

## Start Product Configurator from the Start menu

1. Click the **Start** button.
2. Enter "Product Configuration".
3. Select the one that has the name of the program you want to troubleshoot.

There are multiple ways how [SuperOffice can be deployed][1]. If SuperOffice Web and NetServer are installed separately, or if your company’s SuperOffice installation has more than one NetServer, make sure you start the Product configuration that has the name of the component you want to troubleshoot.

## Start Product Configurator from the installation folder

1. In the File Explorer, navigate to the component's *Config* folder.

    For example, *C:\SuperOffice\SuperOffice Web\Config*

2. Double-click on the **SoAppConfig.exe** app.

## Using the Product Configurator

![Product configurator -screenshot][img1]

When you have the Product configuration application open:

1. Click on the **Diagnostics** section.

2. Define the path to where the log file should be saved.

3. Select **Display Advanced Settings**, which will let you specify how many details you want in the debugging log file.

4. Click **Next** to go through the whole configuration wizard and click **Finish**.

    * Once you finish the wizard, the Report configuration product wizard will start automatically. You can close it if you don’t want to debug reports.

    * The log file will be created and errors will start to be logged.

> [!NOTE]
> We recommend recreating the issue and turning off the logging as soon as you have the debug information in the log.
>
> By leaving debugging On, you risk creating a huge log file, which can eventually **affect performance** or use all server resources and crash it. Heavy logging will reduce performance, so only turn on this when you need to generate a log file to locate a problem.

### How to know which level of details I want to include in the logs?

In a generic troubleshooting case you are interested to see errors in Web/NetServer, select **Log error** and click through the wizard.

SuperOffice Inbox and Pocket CRM use NetServer service to send emails. If you want to troubleshoot email sending or receiving via the NetServer, select **Log e-mail** and in the field next to this option define where the log files should be created.

Logging will create 2 files - one for incoming emails (communication with IMAP server) and one for outgoing emails (communication with SMTP server).

> [!NOTE]
> This is not a debug log for MailLink. That log file is in *%appdata%\SuperOffice\MailLink\Log*. [Read more about debugging MailLink][3].

<!-- Referenced links -->
[1]: ../security/deployment-scenarios.md
[2]: index.md
[3]: ../../email/maillink/debug.md

<!-- Referenced images -->
[img1]: media/image0sx5s.png
