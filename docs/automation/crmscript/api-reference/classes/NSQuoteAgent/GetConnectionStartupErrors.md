---
uid: crmscript_ref_NSQuoteAgent_GetConnectionStartupErrors
title: PluginResponseArray GetConnectionStartupErrors()
intellisense: NSQuoteAgent.GetConnectionStartupErrors
keywords: NSQuoteAgent, GetConnectionStartupErrors
so.topic: reference
---

Returns an array of PluginResponseInfos for all failed connection initializations.


**Returns:** Array of PluginResponseInfos for each failed connection initialization.

```crmscript
NSQuoteAgent agent;
PluginResponseArray res = agent.GetConnectionStartupErrors();
```

