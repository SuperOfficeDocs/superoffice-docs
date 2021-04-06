---
uid: crmscript_ref_NSPhoneListAgent_GetContactPhones
title: PhoneListItemArray GetContactPhones(Integer contactId)
intellisense: NSPhoneListAgent.GetContactPhones
keywords: NSPhoneListAgent, GetContactPhones
so.topic: reference
---

Returns an array of phone list items for all the persons belonging to a contact (company). The in-parameter must be a valid contact-id.

**Parameters:**
 - **contactId** The contact id

**Returns:** The contacts phone list.

```crmscript
NSPhoneListAgent agent;
Integer contactId;
PhoneListItemArray res = agent.GetContactPhones(contactId);
```

