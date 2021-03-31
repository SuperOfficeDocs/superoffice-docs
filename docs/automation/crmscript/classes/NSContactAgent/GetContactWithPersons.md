---
title: crmscript_ref_NSContactAgent_GetContactWithPersons
description: ContactEntity GetContactWithPersons(Integer contactId)
intellisense: NSContactAgent.GetContactWithPersons
keywords: NSContactAgent,GetContactWithPersons
so.topic: reference
---

Returns the contact with all the contact persons belonging to the contact

**Parameters:**
 - **contactId** The id of the contact.

**Returns:** ContactEntity with all data and persons.

```crmscript
NSContactAgent agent;
Integer contactId;
ContactEntity res = agent.GetContactWithPersons(contactId);
```

