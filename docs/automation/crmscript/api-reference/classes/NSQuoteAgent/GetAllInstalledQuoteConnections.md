---
uid: crmscript_ref_NSQuoteAgent_GetAllInstalledQuoteConnections
title: NSQuoteConnection[] GetAllInstalledQuoteConnections()
intellisense: NSQuoteAgent.GetAllInstalledQuoteConnections
keywords: NSQuoteAgent, GetAllInstalledQuoteConnections
so.topic: reference
---

# NSQuoteConnection[] GetAllInstalledQuoteConnections()

Get all installed connections. Some installed connections may not be available to the user.

**Returns:** NSQuoteConnection[]

```crmscript
NSQuoteAgent agent;
NSQuoteConnection[] res = agent.GetAllInstalledQuoteConnections();
```

