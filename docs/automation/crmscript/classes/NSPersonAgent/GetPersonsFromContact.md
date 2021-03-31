---
title: crmscript_ref_NSPersonAgent_GetPersonsFromContact
description: PersonArray GetPersonsFromContact(Integer contactId)
intellisense: NSPersonAgent.GetPersonsFromContact
keywords: NSPersonAgent,GetPersonsFromContact
so.topic: reference
---

Returns all the persons belonging to a contact.

**Parameters:**
 - **contactId** The project id

**Returns:** The persons belonging to a contact.

```crmscript
NSPersonAgent agent;
Integer contactId;
PersonArray res = agent.GetPersonsFromContact(contactId);
```

