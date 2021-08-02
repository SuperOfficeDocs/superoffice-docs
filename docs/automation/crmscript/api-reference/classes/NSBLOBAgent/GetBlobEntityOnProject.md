---
uid: crmscript_ref_NSBLOBAgent_GetBlobEntityOnProject
title: NSBlobEntity GetBlobEntityOnProject(Integer projectId)
intellisense: NSBLOBAgent.GetBlobEntityOnProject
keywords: NSBLOBAgent, GetBlobEntityOnProject
so.topic: reference
---

Gets the blob entity that represents the project image binary object.

**Parameters:**
 - **projectId** The project id

**Returns:** NSBlobEntity

```crmscript
NSBLOBAgent agent;
Integer projectId;
NSBlobEntity res = agent.GetBlobEntityOnProject(projectId);
```

