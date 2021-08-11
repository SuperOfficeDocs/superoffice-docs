---
uid: crmscript_ref_NSContactAgent_AddPerson
title: NSPersonEntity AddPerson(Integer contactId, NSPersonEntity newPersonEntity)
intellisense: NSContactAgent.AddPerson
keywords: NSContactAgent, AddPerson
so.topic: reference
---

# NSPersonEntity AddPerson(Integer contactId, NSPersonEntity newPersonEntity)

Add a person to the given contact

**Parameters:**
 - **contactId** Contact to add person to
 - **newPersonEntity** Person object to add

**Returns:** Updated person object

```crmscript
NSContactAgent agent;
Integer contactId;
NSPersonEntity newPersonEntity;
NSPersonEntity res = agent.AddPerson(contactId, newPersonEntity);
```

