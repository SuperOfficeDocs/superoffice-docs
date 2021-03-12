---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: enable_debug_of_reporter       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Enable debug for Web Reporter # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir: onsite             # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Enable debug for Web Reporter

Debug logging for Reporter in Web can be enabled in *SoReporter.Executer.exe.config* file which is located in *\<Web installation>\\bin\\Reporter* folder.

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

Make sure the path in the initializeData parameter exists and Web can create *Listener.log* file there. After you save the config file, Web Reporter will be restarted and will start logging to the *Listener.log* file.
