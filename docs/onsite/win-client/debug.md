---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: debug_win_client       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description:  Debug Win client # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto               # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite              # cloud or onsite
so.client: win             # online, web, win, pocket, or mobile
---

# Debug Win client

## Add the following parameters to SuperOffice.ini

```text
[Error]
EnableDebug=1
EnableOleDBLog=0
EnableReporterLog=1
Truncate=0
Logpath=c:\SO_arc\data\SOError.log
```

* Most parameters are either on = 1 or off = 0.
* **EnableOleDBLog** supports log levels 1-5. Use it to troubleshoot anything using the OleDBProvider, such as reports.
* **Logpath**: make sure the path is accessible for the client you want to make the log file for. For debugging it is most useful if this location is only used for the client with problems, so a local folder where the user has a write permission is ideal.

See the [superOffice.ini reference][1] for details.

> [!NOTE]
> If you enable the comprehensive error logging function, you must remember to disable it (set `EnableDebug=0`) afterward. Otherwise, the hard disk will fill up.

## To also get debug info from NetServer, edit SuperOffice.config

Since the windows client uses both old components and NetServer, you also need to enable debugging in the *SuperOffice.config* file for support to be able to trace what happens.

* Make sure the key LogError is set to True in the section Diagnostics
* Make sure it writes to a file by setting LogToFile to True. Default the LogFolder is set to *%Localappdata%\\SuperOffice*, but you may change this to the same location as the above Logfolder in *SuperOffice.ini*.

> [!NOTE]
> The client needs to write permission to the LogFolder. Without write permission to this folder, NetServer will write the log file to the same location it was started from.

See the [SuperOffice.config reference][2] for details.

### Netserver diagnostics

```xml
<SuperOffice>
<Diagnostics>

<!-- Log errors (default 'True').
--> <add key="LogError" value="True">
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
<!-- Folder (for example UNC path) where the logfile is to recide. Note that the owner of the process needs to have access to manipulate files in this folder -->
<add key="LogFolder" value="C:\Log">
</add>
</Diagnostics>
```

When you use SuperOffice Win, the Scaffolding option is not in the *SuperOffice.config* file at all.

If asked for even more extended logging, you may turn this on by adding:

```xml
<add key="EnableScaffolding" value="true" />
```

See also [Diagnostics][3] section of the *web.config* page.

[!include[ALT](../includes/turn-off-logging.md)]

<!-- Referenced links -->
[1]: ../config-and-ini/superoffice-ini.md
[2]: ../config-and-ini/superoffice-config.md
[3]: ../config-and-ini/web-config.md
