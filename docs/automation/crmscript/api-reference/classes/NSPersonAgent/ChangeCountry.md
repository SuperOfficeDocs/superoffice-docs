---
uid: crmscript_ref_NSPersonAgent_ChangeCountry
title: NSPersonEntity ChangeCountry(NSPersonEntity personEntity, Integer toCountryId)
intellisense: NSPersonAgent.ChangeCountry
keywords: NSPersonAgent, ChangeCountry
so.topic: reference
---

# NSPersonEntity ChangeCountry(NSPersonEntity personEntity, Integer toCountryId)

Change country regenerates the default values and localized information such as phone number and address format for this entity.

**Parameters:**
 - **personEntity** The NSPersonEntity to change country on
 - **toCountryId** The country to switch to

**Returns:** The NSPersonEntity

```crmscript
NSPersonAgent agent;
NSPersonEntity personEntity;
Integer toCountryId;
NSPersonEntity res = agent.ChangeCountry(personEntity, toCountryId);
```

