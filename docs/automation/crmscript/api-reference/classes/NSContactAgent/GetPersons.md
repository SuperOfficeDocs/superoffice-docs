---
uid: crmscript_ref_NSContactAgent_GetPersons
title: NSPerson[] GetPersons(Integer contactId)
intellisense: NSContactAgent.GetPersons
keywords: NSContactAgent, GetPersons
so.topic: reference
---

# NSPerson[] GetPersons(Integer contactId)

Returns an array of all the contact persons for the company card.

**Parameters:**
 - **contactId** 

**Returns:** NSPerson[]

```crmscript
NSContactAgent agent;
Integer contactId;
NSPerson[] res = agent.GetPersons(contactId);
```

