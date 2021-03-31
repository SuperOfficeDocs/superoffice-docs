---
uid: crmscript_ref_NSContactAgent_AddPerson
title: PersonEntity AddPerson(Integer contactId, PersonEntity newPersonEntity)
intellisense: NSContactAgent.AddPerson
keywords: NSContactAgent, AddPerson
so.topic: reference
---

Add a person to the given contact

**Parameters:**
 - **contactId** Contact to add person to
 - **newPersonEntity** Person object to add

**Returns:** Updated person object

```crmscript
NSContactAgent agent;
Integer contactId;
PersonEntity newPersonEntity;
PersonEntity res = agent.AddPerson(contactId, newPersonEntity);
```

