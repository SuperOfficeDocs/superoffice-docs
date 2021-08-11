---
uid: crmscript_ref_NSPhoneListAgent_GetContactPhones
title: NSPhoneListItem[] GetContactPhones(Integer contactId)
intellisense: NSPhoneListAgent.GetContactPhones
keywords: NSPhoneListAgent, GetContactPhones
so.topic: reference
---

# NSPhoneListItem[] GetContactPhones(Integer contactId)

Returns an array of phone list items for all the persons belonging to a contact (company). The in-parameter must be a valid contact-id.

**Parameters:**
 - **contactId** The contact id

**Returns:** NSPhoneListItem[]

```crmscript
NSPhoneListAgent agent;
Integer contactId;
NSPhoneListItem[] res = agent.GetContactPhones(contactId);
```

