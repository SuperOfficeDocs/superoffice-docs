---
uid: crmscript_ref_NSListAgent_GetAllCurrencies
title: NSCurrencyEntity[] GetAllCurrencies(Bool includeDeleted)
intellisense: NSListAgent.GetAllCurrencies
keywords: NSListAgent, GetAllCurrencies
so.topic: reference
---

# NSCurrencyEntity[] GetAllCurrencies(Bool includeDeleted)

Returns all currencies

**Parameters:**
 - **includeDeleted** Include deleted items in result?

**Returns:** NSCurrencyEntity[]

```crmscript
NSListAgent agent;
Bool includeDeleted;
NSCurrencyEntity[] res = agent.GetAllCurrencies(includeDeleted);
```

