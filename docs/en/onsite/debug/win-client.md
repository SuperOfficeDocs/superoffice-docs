---
title: Debug Win client
uid: debug_win_client
description:  Debug Windows client
date: 12.08.2021
author: Bergfrid Dias
keywords: debug, superoffice.ini, superoffice.config
topic: howto
envir: onsite
client: win
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

* **Logpath**: make sure the path is accessible for the client you want to make the log file for. For debugging, it is most useful if this location is used only for the client with problems, so a local folder where the user has a write-permission is ideal.

See the [SuperOffice.ini reference][1] for details.

> [!CAUTION]
> If you enable the comprehensive error logging function, you must remember to disable it (set `EnableDebug=0`) afterward. Otherwise, the hard disk will fill up.

## Get debug info from NetServer

Because the Windows client uses both old components and NetServer, you need to [enable debug in SuperOffice.config][3] in addition to *SuperOffice.ini* for support to be able to trace what happens.

The `LogFolder` is set to *%Localappdata%\SuperOffice* by default, but you may change this to the same location as the Logfolder in *SuperOffice.ini*.

When you use SuperOffice Win, the Scaffolding option is not in the *SuperOffice.config* file at all.

If asked for even more extended logging, you may turn this on by adding:

```xml
<add key="EnableScaffolding" value="true" />
```

<!-- Referenced links -->
[1]: ../install/win-client/superoffice-ini.md
[3]: index.md
