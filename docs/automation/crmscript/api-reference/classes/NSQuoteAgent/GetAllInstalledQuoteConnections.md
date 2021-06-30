---
uid: crmscript_ref_NSQuoteAgent_GetAllInstalledQuoteConnections
title: QuoteConnection[] GetAllInstalledQuoteConnections()
intellisense: NSQuoteAgent.GetAllInstalledQuoteConnections
keywords: NSQuoteAgent, GetAllInstalledQuoteConnections
so.topic: reference
---

Get all installed connections. Some installed connections may not be available to the user.


**Returns:** List of connections

```crmscript
NSQuoteAgent agent;
QuoteConnection[] res = agent.GetAllInstalledQuoteConnections();
```

