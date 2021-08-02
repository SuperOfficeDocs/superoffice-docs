---
uid: crmscript_ref_NSProjectAgent_GetProjectImage
title: NSImage GetProjectImage(Integer projectId)
intellisense: NSProjectAgent.GetProjectImage
keywords: NSProjectAgent, GetProjectImage
so.topic: reference
---

Returns the project image that is displayed in the CRM application.

**Parameters:**
 - **projectId** The project id of the project the image belongs to.

**Returns:** NSImage

```crmscript
NSProjectAgent agent;
Integer projectId;
NSImage res = agent.GetProjectImage(projectId);
```

