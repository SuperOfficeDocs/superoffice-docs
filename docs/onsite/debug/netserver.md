---
title: Debug NetServer
uid: debug_netserver
description:  Debug NetServer
author: {github-id}
keywords:
so.topic: howto
so.envir: onsite
so.client: win,web
---

# NetServer diagnostics

You can turn on and off logging for NetServer directly in the *Web.config* file.

```XML
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

<!-- Log successful authentications (default 'False') -->
<add key="LogSuccessAudit" value="False">
</add>

<!-- Log to the OS event log (default 'True') -->
<add key="LogToEventLog" value="False">
</add>

<!-- Log to SuperOffice Research and Product Development (Online through a WebService)
     (default 'False') -->
<add key="LogToSuperOffice" value="False">
</add>

<!-- Log to a LogFile (default 'False') -->
<add key="LogToFile" value="True">
</add>

<!-- Folder (for example UNC path) where the log file is to reside.
     The owner of the process must have access to manipulate files here -->
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

> [!NOTE]
> Remember to turn the logging off when it is not needed, as extended logging in NetServer will reduce performance.

<!-- Referenced links -->
[3]: ../config/web-config.md
