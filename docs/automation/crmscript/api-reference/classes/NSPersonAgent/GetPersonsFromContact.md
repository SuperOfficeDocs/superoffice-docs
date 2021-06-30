---
uid: crmscript_ref_NSPersonAgent_GetPersonsFromContact
title: Person[] GetPersonsFromContact(Integer contactId)
intellisense: NSPersonAgent.GetPersonsFromContact
keywords: NSPersonAgent, GetPersonsFromContact
so.topic: reference
---

Returns all the persons belonging to a contact.

**Parameters:**
 - **contactId** The project id

**Returns:** The persons belonging to a contact.

```crmscript
NSPersonAgent agent;
Integer contactId;
Person[] res = agent.GetPersonsFromContact(contactId);
```

