---
uid: crmscript_ref_NSQuoteAgent_GetAllAvailableQuoteConnections
title: QuoteConnection[] GetAllAvailableQuoteConnections()
intellisense: NSQuoteAgent.GetAllAvailableQuoteConnections
keywords: NSQuoteAgent, GetAllAvailableQuoteConnections
so.topic: reference
---

Get all available connections. Some installed connections may not be available to the user. Use GetAllAvailableQuoteConnectionsWithPriceLists if you need the pricelists on the connections as well.


**Returns:** List of connections

```crmscript
NSQuoteAgent agent;
QuoteConnection[] res = agent.GetAllAvailableQuoteConnections();
```

