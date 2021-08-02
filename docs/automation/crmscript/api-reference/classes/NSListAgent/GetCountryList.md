---
uid: crmscript_ref_NSListAgent_GetCountryList
title: NSCountry[] GetCountryList(Integer[]  countryIds);
intellisense: NSListAgent.GetCountryList
keywords: NSListAgent, GetCountryList
so.topic: reference
---

Gets a vector of NSCountry objects.

**Parameters:**
 - **countryIds** The identifiers of the NSCountry objects

**Returns:** NSCountry[]

```crmscript
Integer[] ids;
NSListAgent agent;
NSCountry[] res = agent.GetCountryList(ids);
```

