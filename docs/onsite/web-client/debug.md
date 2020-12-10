---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: debug_web_client       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Debug Web client # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite              # cloud or onsite
so.client: web              # online, web, win, pocket, or mobile
---

# Debug Web client

Enable debug for Sales & Marketing Web client or Remote WebServices. When locating problems in Sales & Marketing Web client, Service, Pocket CRM, or any other tool that use SuperOffice Remote WebServices (NetServer).

You can enable the debugging in a SuperOffice application which configures Web installation and/or NetServer and is called Product Configurator. There are two ways how you can start it - from the Windows Start menu and directly from the installation directory.

## From the Start menu

To do it click on the Start button and type in “Product Configuration” and click on the one that has the name of the program you want to troubleshoot.

There are multiple ways how [SuperOffice can be deployed][1]. If SuperOffice Web and NetServer are installed separately, or if your company’s SuperOffice installation has more than one NetServer, make sure you start the  Product configuration which has the name of the component you want to troubleshoot.

## From the installation folder

In the file explorer, navigate to the component's Config folder (example: C:\\SuperOffice\\SuperOffice Web\\Config) and double-click on the app SoAppConfig.exe.

> [!CAUTION]
> When you open the Product Configuration tool all SuperOffice Web users will be logged out from the SuperOffice CRM. They will be able to login right away and keep working, however, when you will save the changes made in the configuration tool, all users will be logged out again.

When you have the Product configuration application open:

1. Click on **Diagnostics (1)** section. In the field (2) you can define a path where the log file should be saved. Then add a tick next to the **Display Advanced Settings (3)**, which will let you specify how much details you want in the debugging log file.

![image0sx5s.png][2]

2. Click **Next** to go through the whole configuration wizard and click **Finish**. Once you finish the wizard, Report configuration product wizard will start automatically. You can close it if you don’t want to debug reports. Then the log file will be created and errors will start to be logged.

> [!NOTE]
> We recommend recreating the issue and turning off the logging as soon as you have debugging information in the log. By leaving debugging On you risk creating a huge size log file, which can eventually affect performance or use all server resources and crash it. Heavy logging will reduce performance, so only turn on this when you need to generate a log file to locate a problem.

## How to know which level of details I want to include in the logs?

In a generic troubleshooting case you are interested to see errors in Web/NetServer, then add a tick next to **Log error** and click through the wizard.

In a case where you want to troubleshoot e-mail sending or receiving\* via the NetServer add a tick next to **Log e-mail** and in the field next to this option define where the log files should be created. Logging will create 2 files - one for incoming emails (communication with IMAP server) and one for outgoing emails (communication with SMTP server). This is not a debug logging for MailLink.

\* SuperOffice Inbox and SuperOffice mobile app - Pocket CRM use NetServer service to send emails.

## How do I find location of Web/NetServer log file without kicking out SuperOffice users from the session?

If you know that the debugging has been enabled and you just want to find a location of the file without making all users log out from the session, you can do it directly in config file. Find a *.config* file of the component you are debugging and in the `<Diagnostics>` section `<add key="LogFolder" value="C:\Log">` will store the path to the log file.

## How do I enabling debugging directly in the config files?

You can set the same logging parameters directly in the Web.config in <Diagnostics> section.

See Netserver Diagnostics section below.

## NetServer start-up and performance

SuperOffice Web always takes a long time to start up initially because IIS needs to initiate both the .NET common language runtime and NetServer. As soon as the w3wp.exe IIS work process is up and running you'll see that the performance is a way better.

We do however also have some online services configurable in the web.config file. If you experience poor performance on the second login you may turn off *Logging to SuperOffice Research & Product Developement.* Go to Diagnostics and turn off Log to SuperOffice Research & Product Developement.

## Netserver Diagnostics

You can turn on and off logging for NetServer for Web client directly in the Web.config file.

```xml
<SuperOffice>

<Diagnostics>

<!-- Log errors (default 'True'). -->
<add key="LogError" value="True">
</add>
<!-- Log warnings (default 'False') -->
<add key="LogWarning" value="False">
</add>
<!-- Log general information. This includes successful SQL's passed to the database.
Only permit this option while debugging a bug. This will be a severe performance hit!
(default 'False') -->
<add key="LogInformation" value="False">
</add>
<!-- Log failed authentications (default 'True') -->
<add key="LogFailureAudit" value="True">
</add>
<!-- Log sucessfull authentications (default 'False') -->
<add key="LogSuccessAudit" value="False">
</add>
<!-- Log to the OS event log (default 'True') -->
<add key="LogToEventLog" value="False">
</add>
<!-- Log to SuperOffice Research and Product Development (Online through a WebService) (default 'False') -->
<add key="LogToSuperOffice" value="False">
</add>
<!-- Log to a LogFile (default 'False') -->
<add key="LogToFile" value="True">
</add>
<!-- Folder (e.g. UNC path) where the logfile is to recide. Note that the owner of the process needs to have access to manipulate files in this folder -->
<add key="LogFolder" value="C:\Log">
</add>
</Diagnostics>
```

When you use SuperOffice Win the Scaffolding option is not in SuperOffice.config file at all. If asked for even more extended logging you may turn this on by adding:

```xml
<add key="EnableScaffolding" value="true" />
```

See also [Diagnostics][3] section of the Web.config page.

[!include[ALT](../includes/turn-off-logging.md)]

<!-- Referenced links -->
[1]: https://community.superoffice.com/en/technical/documentation/prepare/security/deploy-securely/deployment-scenarios/
[2]: https://community.superoffice.com/contentassets/f06ec7d2a872425a9cc32f2b22cf748e/image0sx5s.png
[3]: https://community.superoffice.com/en/technical/documentation/administration/config-ini/webconfig/