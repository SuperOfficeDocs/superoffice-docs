---
uid: crmscript_ref_NSPersonAgent_GetAddressByCountry
title: Address GetAddressByCountry(Integer personId, Integer countryId)
intellisense: NSPersonAgent.GetAddressByCountry
keywords: NSPersonAgent, GetAddressByCountry
so.topic: reference
---

Gets the person's localized address.

**Parameters:**
 - **personId** The person id
 - **countryId** 

**Returns:** The address as LocalizedField[][].

```crmscript
NSPersonAgent agent;
Integer personId;
Integer countryId;
Address res = agent.GetAddressByCountry(personId, countryId);
```

