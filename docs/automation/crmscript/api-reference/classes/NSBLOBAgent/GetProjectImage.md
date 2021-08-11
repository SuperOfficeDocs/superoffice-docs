---
uid: crmscript_ref_NSBLOBAgent_GetProjectImage
title: NSImage GetProjectImage(Integer projectId)
intellisense: NSBLOBAgent.GetProjectImage
keywords: NSBLOBAgent, GetProjectImage
so.topic: reference
---

# NSImage GetProjectImage(Integer projectId)

Returns the project image that is displayed in the CRM application.

**Parameters:**
 - **projectId** The project id of the project the image belongs to.

**Returns:** NSImage

```crmscript
NSBLOBAgent agent;
Integer projectId;
NSImage res = agent.GetProjectImage(projectId);
```

