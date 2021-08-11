---
uid: crmscript_ref_NSQuoteAgent_GetAllAvailableQuoteConnectionsWithPriceLists
title: NSQuoteConnection[] GetAllAvailableQuoteConnectionsWithPriceLists()
intellisense: NSQuoteAgent.GetAllAvailableQuoteConnectionsWithPriceLists
keywords: NSQuoteAgent, GetAllAvailableQuoteConnectionsWithPriceLists
so.topic: reference
---

# NSQuoteConnection[] GetAllAvailableQuoteConnectionsWithPriceLists()

Get all available connections. Some installed connections may not be available to the user. Includes pricelists for the connection. This is a heavy call

**Returns:** NSQuoteConnection[]

```crmscript
NSQuoteAgent agent;
NSQuoteConnection[] res = agent.GetAllAvailableQuoteConnectionsWithPriceLists();
```

