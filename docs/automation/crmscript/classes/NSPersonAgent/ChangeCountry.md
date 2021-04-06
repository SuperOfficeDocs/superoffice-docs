---
uid: crmscript_ref_NSPersonAgent_ChangeCountry
title: PersonEntity ChangeCountry(PersonEntity personEntity, Integer toCountryId)
intellisense: NSPersonAgent.ChangeCountry
keywords: NSPersonAgent, ChangeCountry
so.topic: reference
---

Change country regenerates the default values and localized information such as phone number and address format for this entity.

**Parameters:**
 - **personEntity** The PersonEntity to change country on
 - **toCountryId** The country to switch to

**Returns:** The PersonEntity

```crmscript
NSPersonAgent agent;
PersonEntity personEntity;
Integer toCountryId;
PersonEntity res = agent.ChangeCountry(personEntity, toCountryId);
```

