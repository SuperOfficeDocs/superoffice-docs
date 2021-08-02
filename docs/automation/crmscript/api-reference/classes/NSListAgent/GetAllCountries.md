---
uid: crmscript_ref_NSListAgent_GetAllCountries
title: NSCountry[] GetAllCountries(Bool includeDeleted)
intellisense: NSListAgent.GetAllCountries
keywords: NSListAgent, GetAllCountries
so.topic: reference
---

Returns all available countries a contact or person could belong to.

**Parameters:**
 - **includeDeleted** Include deleted items in result?

**Returns:** NSCountry[]

```crmscript
NSListAgent agent;
Bool includeDeleted;
NSCountry[] res = agent.GetAllCountries(includeDeleted);
```

