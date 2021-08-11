---
uid: crmscript_ref_NSBLOBAgent_GetBlobEntityOnPerson
title: NSBlobEntity GetBlobEntityOnPerson(Integer personId)
intellisense: NSBLOBAgent.GetBlobEntityOnPerson
keywords: NSBLOBAgent, GetBlobEntityOnPerson
so.topic: reference
---

# NSBlobEntity GetBlobEntityOnPerson(Integer personId)

Gets the blob entity that represents the person image binary object.

**Parameters:**
 - **personId** The person id

**Returns:** NSBlobEntity

```crmscript
NSBLOBAgent agent;
Integer personId;
NSBlobEntity res = agent.GetBlobEntityOnPerson(personId);
```

