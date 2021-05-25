---
title: Scripting element
uid: ns_config_scripting
description: NetServer Scripting element
so.date: 06.06.2018
author: {github-id}
keywords: config
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

| Name | Description |
|---|---|
| ScriptPath | UNC path to directory containing .cs, .vb or .dll script files. |
| EnableScripting | Determines whether scripts will be invoked when web service methods are called.<br>Default: true |
| TimeoutLimit | Number of milliseconds before a script times out.<br>Default: 20000 |
| MaxTimeouts | Maximum number of timeouts before a script is disabled. |
