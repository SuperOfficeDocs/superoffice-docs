---
uid: crmscript_ref_NSContactAgent_GetAddressByCountry
title: Address GetAddressByCountry(Integer contactId, Integer countryId)
intellisense: NSContactAgent.GetAddressByCountry
keywords: NSContactAgent, GetAddressByCountry
so.topic: reference
---

Gets the contact's localized address.

**Parameters:**
 - **contactId** The contact id
 - **countryId** 

**Returns:** The address as LocalizedField[][].

```crmscript
NSContactAgent agent;
Integer contactId;
Integer countryId;
Address res = agent.GetAddressByCountry(contactId, countryId);
```

