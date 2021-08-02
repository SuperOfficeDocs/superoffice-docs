---
uid: crmscript_ref_NSPersonAgent_GetPersonsFromContact
title: NSPerson[] GetPersonsFromContact(Integer contactId)
intellisense: NSPersonAgent.GetPersonsFromContact
keywords: NSPersonAgent, GetPersonsFromContact
so.topic: reference
---

Returns all the persons belonging to a contact.

**Parameters:**
 - **contactId** The project id

**Returns:** NSPerson[]

```crmscript
NSPersonAgent agent;
Integer contactId;
NSPerson[] res = agent.GetPersonsFromContact(contactId);
```

