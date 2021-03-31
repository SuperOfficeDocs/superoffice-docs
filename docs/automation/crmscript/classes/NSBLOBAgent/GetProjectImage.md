---
title: crmscript_ref_NSBLOBAgent_GetProjectImage
description: Image GetProjectImage(Integer projectId)
intellisense: NSBLOBAgent.GetProjectImage
keywords: NSBLOBAgent,GetProjectImage
so.topic: reference
---

Returns the project image that is displayed in the CRM application.

**Parameters:**
 - **projectId** The project id of the project the image belongs to.

**Returns:** The image as a System.Drawing.Image. (If the the image is returned over webservices, the stream is returned as a Base64 encoded string.)

```crmscript
NSBLOBAgent agent;
Integer projectId;
Image res = agent.GetProjectImage(projectId);
```

