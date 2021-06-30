---
uid: crmscript_ref_NSQuoteAgent_GetAllAvailableQuoteConnectionsWithPriceLists
title: QuoteConnection[] GetAllAvailableQuoteConnectionsWithPriceLists()
intellisense: NSQuoteAgent.GetAllAvailableQuoteConnectionsWithPriceLists
keywords: NSQuoteAgent, GetAllAvailableQuoteConnectionsWithPriceLists
so.topic: reference
---

Get all available connections. Some installed connections may not be available to the user. Includes pricelists for the connection. This is a heavy call


**Returns:** List of connections

```crmscript
NSQuoteAgent agent;
QuoteConnection[] res = agent.GetAllAvailableQuoteConnectionsWithPriceLists();
```

