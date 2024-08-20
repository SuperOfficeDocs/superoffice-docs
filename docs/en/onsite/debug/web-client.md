---
uid: debug-web-client
title: Debug Web client
description: Debug Web client
keywords: debug, Product Configurator, SoAppConfig.exe
author: Bergfrid Dias, Martin Pavlas
date: 05.21.2024
topic: howto
envir: onsite
client: web
---

# Debug Web client

Enable debug using the **Product Configurator** when locating problems in the Sales & Marketing Web client, Service, Pocket CRM, or any other tool that uses SuperOffice web services (NetServer).

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

## <a id="10-2"></a>Changes in NetServer logging from 10.2

Some settings in the **Diagnostics** tab of the Product Configuration/web.config are obsolete from SuperOffice 10.2, but they are still visible in the web.config/GUI.

These settings have been replaced by a new file in the Web installation folder called **appsettings.json**. This file is automatically created.

The log levels that can be used (from least to heaviest logging): Error, Warning, Information, Trace, Debug.

The NetServer log in SuperOffice 10.1.6 and earlier was programmed to log when there was any exception in the way that SuperOffice was supposed to work. I.e. if something didn't work as it was programmed, it would automatically create a log entry. The new NetServer creates log records only when it is programmed to do so in the code, for the specified log level.

Obsolete settings of the **Diagnostics** section from SuperOffice 10.2:

* Log to event log
* Log level settings
* Log services calls

![Product configurator - obsolete options -screenshot][img2]

### What stayed the same?

* In Onsite, the debug info from NetServer will still be saved as a physical file.
* The location of this file is specified like before in the Product Configuration/web.config.
* Whether the log file will be created is also decided like before, in the Product Configuration/web.config by **Log to file** setting.
* Everything related to Mail log and long-running queries log stayed the same.

### How to enable the NetServer log now

1. Enable the **Log to file** option in Product Configuration - Diagnostics.

    ![Product configurator - Log to file -screenshot][img3]

1. Set the Default and SuperOffice debug level in *appsettings.json* to Error, Warning, Information, Trace, or Debug. Debug being the highest level.

    ![Log levels -screenshot][img4]

1. Do a recycle to finish the change.

### Important notes and additional information

* **With Debug level, NetServer logs a lot!** Do not keep it on for longer than necessary. Always advise customer to lower the debug level after sending the log file to support (set it back to Error).

* Users are not kicked out when changing the *appsettings.json* file, but they are **kicked out during the recycle**.

* **Log file format is different**:

    ![Log format -screenshot][img5]

* You can set a different location for the email log than the normal NetServer log, if you edit the *web.config* directly and specify the setting for Mail log location.

* Long-running queries only give records when you set the NetServer log level to Debug. If it is lower, it will not log anything. These log entries are added to the NetServer log, no separate file.

* The option **Enable Scaffolding** and the log level Debug will load all SQL queries.

<!-- Referenced links -->
[1]: ../security/deployment-scenarios.md
[2]: index.md
[3]: ../../email/mail-link/debug.md

<!-- Referenced images -->
[img1]: media/image0sx5s.png
[img2]: media/netserver-diagnostics-obsolete.png
[img3]: media/log-to-file.png
[img4]: media/log-levels.png
[img5]: media/log-format.png
