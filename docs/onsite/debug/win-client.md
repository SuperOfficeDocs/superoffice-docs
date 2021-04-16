---
title: Debug Win client
uid: debug_win_client
description:  Debug Windows client
author: {github-id}
keywords:
so.topic: howto
so.envir: onsite
so.client: win
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
* **Logpath**: make sure the path is accessible for the client you want to make the log file for. For debugging, it is most useful if this location is only used for the client with problems, so a local folder where the user has a write permission is ideal.

See the [superOffice.ini reference][1] for details.

> [!NOTE]
> If you enable the comprehensive error logging function, you must remember to disable it (set `EnableDebug=0`) afterward. Otherwise, the hard disk will fill up.

## To also get debug info from NetServer, edit SuperOffice.config

Since the Windows client uses both old components and NetServer, you also need to enable debugging in the *SuperOffice.config* file for support to be able to trace what happens.

* Make sure the key LogError is set to True in the section Diagnostics
* Make sure it writes to a file by setting LogToFile to True. Default the LogFolder is set to *%Localappdata%\\SuperOffice*, but you may change this to the same location as the above Logfolder in *SuperOffice.ini*.

> [!NOTE]
> The client needs to write permission to the LogFolder. Without write permission to this folder, NetServer will write the log file to the same location it was started from.

See the [SuperOffice.config reference][2] for details.

## NetServer diagnostics

[Turn on/off in web.config][3]

<!-- Referenced links -->
[1]: ../config/superoffice-ini.md
[2]: ../config/superoffice-config.md
[3]: netserver.md
