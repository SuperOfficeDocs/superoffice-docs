---
uid: crmscript_ref_NSBLOBAgent_GetBlobEntityOnProject
title: BlobEntity GetBlobEntityOnProject(Integer projectId)
intellisense: NSBLOBAgent.GetBlobEntityOnProject
keywords: NSBLOBAgent, GetBlobEntityOnProject
so.topic: reference
---

Gets the blob entity that represents the project image binary object.

**Parameters:**
 - **projectId** The project id

**Returns:** BlobEntity object

```crmscript
NSBLOBAgent agent;
Integer projectId;
BlobEntity res = agent.GetBlobEntityOnProject(projectId);
```

