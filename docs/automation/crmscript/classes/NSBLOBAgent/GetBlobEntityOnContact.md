---
uid: crmscript_ref_NSBLOBAgent_GetBlobEntityOnContact
title: BlobEntity GetBlobEntityOnContact(Integer contactId)
intellisense: NSBLOBAgent.GetBlobEntityOnContact
keywords: NSBLOBAgent, GetBlobEntityOnContact
so.topic: reference
---

Gets the blob entity that represents the contact image binary object.

**Parameters:**
 - **contactId** The Contact id

**Returns:** BlobEntity object

```crmscript
NSBLOBAgent agent;
Integer contactId;
BlobEntity res = agent.GetBlobEntityOnContact(contactId);
```

