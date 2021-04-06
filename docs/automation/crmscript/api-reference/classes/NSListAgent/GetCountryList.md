---
uid: crmscript_ref_NSListAgent_GetCountryList
title: NSCountry[] GetCountryList(Integer[]  countryIds);
intellisense: NSListAgent.GetCountryList
keywords: NSListAgent, GetCountryList
so.topic: reference
---

Gets a vector of Country objects.

**Parameters:**
 - **countryIds** The identifiers of the NSCountry objects

**Returns:** Vector of NSCountry objects

```crmscript
Integer[] ids;
NSListAgent agent;
agent.GetCountryList(ids);
```

