---
uid: crmscript_ref_NSContactAgent_GetContactWithPersons
title: NSContactEntity GetContactWithPersons(Integer contactId)
intellisense: NSContactAgent.GetContactWithPersons
keywords: NSContactAgent, GetContactWithPersons
so.topic: reference
---

Returns the contact with all the contact persons belonging to the contact

**Parameters:**
 - **contactId** The id of the contact.

**Returns:** NSContactEntity

```crmscript
NSContactAgent agent;
Integer contactId;
NSContactEntity res = agent.GetContactWithPersons(contactId);
```

