---
uid: crmscript_ref_NSBLOBAgent_GetBlobEntityOnContact
title: NSBlobEntity GetBlobEntityOnContact(Integer contactId)
intellisense: NSBLOBAgent.GetBlobEntityOnContact
keywords: NSBLOBAgent, GetBlobEntityOnContact
so.topic: reference
---

Gets the blob entity that represents the contact image binary object.

**Parameters:**
 - **contactId** The Contact id

**Returns:** NSBlobEntity

```crmscript
NSBLOBAgent agent;
Integer contactId;
NSBlobEntity res = agent.GetBlobEntityOnContact(contactId);
```

