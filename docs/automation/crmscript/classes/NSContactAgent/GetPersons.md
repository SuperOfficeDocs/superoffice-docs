---
uid: crmscript_ref_NSContactAgent_GetPersons
title: PersonArray GetPersons(Integer contactId)
intellisense: NSContactAgent.GetPersons
keywords: NSContactAgent, GetPersons
so.topic: reference
---

Returns an array of all the contact persons for the company card.

**Parameters:**
 - **contactId** 

**Returns:** Array of Persons

```crmscript
NSContactAgent agent;
Integer contactId;
PersonArray res = agent.GetPersons(contactId);
```

