---
title: Onsite debugging
uid: onsite_debug
description: Debugging onsite
so.date: 12.08.2021
author: Bergfrid Dias
keywords: config, web.config, diagnostics, log
so.topic: concept
so.envir: onsite
---

# Debug

## NetServer diagnostics

You can turn on and off logging for NetServer directly in [Diagnostics section][1] of the *web.config* or *SuperOffice.config* file.

* Make sure the key `LogError` is set to True.
* Make sure it writes to a file by setting `LogToFile` to True.
* Update `LogFolder` if necessary.

The client needs write permission to the folder. Otherwise, NetServer will write the log file to the same location it was started from.

> [!NOTE]
> Remember to turn the logging off when it is not needed, as extended logging in NetServer will reduce performance.

### How do I find the location of the log file

If you know that the debug is enabled and you just want to find a location of the file without making all users log out from the session, you can do it directly in the config file.

1. Find a *.config* file of the component you are debugging.
2. In the `<Diagnostics>` section `<add key="LogFolder" value="C:\Log">` will store the path to the log file.

## NetServer start-up and performance

SuperOffice Web always takes a long time to start up initially because IIS needs to initiate both the .NET common language runtime and NetServer. As soon as the w3wp.exe IIS work process is up and running you'll see that the performance is better.

We do, however, also have some online services configurable in the *web.config* file. If you experience poor performance on the second login, you may turn off *Logging to SuperOffice Research & Product Developement.* Go to [Diagnostics][1] and turn off Log to SuperOffice Research & Product Developement.

## Debug add-ons

* [Enable debug for Outlook Mail Link][8]
* [Enable debug for Notes Mail Link][8]
* [Enable debug for Ribbons][9]

<!-- Referenced links -->
[1]: ../../../../data-access/docs/netserver/config/diagnostics.md
[8]: ../../email/maillink/debug.md
[9]: ../../document/ribbons/enable-debug.md
