---
title: crmscript_ref_NSProjectAgent_GetProjectImage
description: Image GetProjectImage(Integer projectId)
intellisense: NSProjectAgent.GetProjectImage
keywords: NSProjectAgent,GetProjectImage
so.topic: reference
---

Returns the project image that is displayed in the CRM application.

**Parameters:**
 - **projectId** The project id of the project the image belongs to.

**Returns:** The image as a System.Drawing.Image. (If the the image is returned over webservices, the stream is returned as a Base64 encoded string.)

```crmscript
NSProjectAgent agent;
Integer projectId;
Image res = agent.GetProjectImage(projectId);
```

