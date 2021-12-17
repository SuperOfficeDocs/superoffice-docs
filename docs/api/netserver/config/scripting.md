---
title: Scripting element
uid: ns_config_scripting
description: NetServer configuration values related to NetServer Service Scripting.
so.date: 12.09.2021
author: Bergfrid Dias
keywords: config, NetServer, web.config, Scripting, EnableScripting, ScriptPath, MaxTimeouts, TimeoutLimit
so.topic: reference
so.envir: onsite
---

# NetServer Scripting element

Configuration values related to NetServer Service Scripting.

```XML
<Scripting>
  <add key="ScriptPath" value="" />
  <add key="EnableScripting" value="false" />
  <add key="TimeoutLimit" value="20000" />
  <add key="MaxTimeouts" value="5" />
</Scripting>
```

| Name | Description | Default |
|---|---|---|
| EnableScripting | Determines whether scripts will be invoked when web service methods are called. | true |
| ScriptPath | UNC path to directory containing .cs, .vb or .dll script files. Defaults to *\script* if not set. | |
| MaxTimeouts | Maximum number of timeouts before a script is disabled. | 5 |
| TimeoutLimit | Number of milliseconds before a script times out. | 20000 |

See the [NetServer Core reference][1] for details about handling this programmatically.

<!-- Referenced links -->
[1]: <xref:SuperOffice.Configuration.ConfigFile.Scripting>
