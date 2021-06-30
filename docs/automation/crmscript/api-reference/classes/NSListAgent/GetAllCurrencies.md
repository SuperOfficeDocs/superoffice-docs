---
uid: crmscript_ref_NSListAgent_GetAllCurrencies
title: CurrencyEntity[] GetAllCurrencies(Bool includeDeleted)
intellisense: NSListAgent.GetAllCurrencies
keywords: NSListAgent, GetAllCurrencies
so.topic: reference
---

Returns all currencies

**Parameters:**
 - **includeDeleted** Include deleted items in result?

**Returns:** Array of currencies

```crmscript
NSListAgent agent;
Bool includeDeleted;
CurrencyEntity[] res = agent.GetAllCurrencies(includeDeleted);
```

