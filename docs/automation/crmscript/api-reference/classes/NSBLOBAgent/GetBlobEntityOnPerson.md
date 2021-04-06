---
uid: crmscript_ref_NSBLOBAgent_GetBlobEntityOnPerson
title: BlobEntity GetBlobEntityOnPerson(Integer personId)
intellisense: NSBLOBAgent.GetBlobEntityOnPerson
keywords: NSBLOBAgent, GetBlobEntityOnPerson
so.topic: reference
---

Gets the blob entity that represents the person image binary object.

**Parameters:**
 - **personId** The person id

**Returns:** BlobEntity object

```crmscript
NSBLOBAgent agent;
Integer personId;
BlobEntity res = agent.GetBlobEntityOnPerson(personId);
```

