---
title: Debug
uid: enable_debug_of_reporter
description: Enable debug for Web Reporter
author: {github-id}
keywords:
topic: howto
envir: onsite
client: web
---

# Enable debug for Web Reporter

Debug logging for Reporter in Web can be enabled in *SoReporter.Executer.exe.config* file, which is located in *\<Web installation>\bin\Reporter* folder.

Go to `<system.diagnostics>` section and uncomment the following lines:

```xml
<system.diagnostics>
<!--
<trace autoflush="true" indentsize="4">
  <listeners>
    <add name="SoReporterTrace" type="System.Diagnostics.TextWriterTraceListener" initializeData="c:\temp\Listener.log" />
  </listeners>
</trace>
<switches>
  <add name="SoReporterTraceSwitch" value="Verbose" />
</switches>
-->
</system.diagnostics>
```

Make sure the path in the `initializeData` parameter exists and Web can create the *Listener.log* file there. After you save the config file, Web Reporter will be restarted and will start logging to the *Listener.log* file.
