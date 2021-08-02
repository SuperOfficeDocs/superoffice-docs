---
uid: crmscript_ref_NSListAgent_GetCurrencyList
title: NSCurrency[] GetCurrencyList(Integer[]  currencyIds);
intellisense: NSListAgent.GetCurrencyList
keywords: NSListAgent, GetCurrencyList
so.topic: reference
---

Gets a vector of NSCurrency objects.

**Parameters:**
 - **currencyIds** The identifiers of the NSCurrency objects

**Returns:** NSCurrency[]

```crmscript
Integer[] ids;
NSListAgent agent;
NSCurrency[] res = agent.GetCurrencyList(ids);
```

