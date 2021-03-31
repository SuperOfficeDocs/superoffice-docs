---
uid: crmscript_ref_NSBLOBAgent_GetProjectImageWithSize
title: Image GetProjectImageWithSize(Integer projectId, Integer width, Integer height)
intellisense: NSBLOBAgent.GetProjectImageWithSize
keywords: NSBLOBAgent, GetProjectImageWithSize
so.topic: reference
---

Returns the project image that is displayed in the CRM application with a specified maximum size.

**Parameters:**
 - **projectId** The project id of the project the image belongs to.
 - **width** The maximum with of the returned image. Specify <= 0 to preserve aspect ratio of existing image
 - **height** The maximum height of the returned image. Specify <= 0 to preserve aspect ratio of existing image

**Returns:** The image as a System.Drawing.Image. (If the the image is returned over webservices, the stream is returned as a jpeg/base64 encoded string.)

```crmscript
NSBLOBAgent agent;
Integer projectId;
Integer width;
Integer height;
Image res = agent.GetProjectImageWithSize(projectId, width, height);
```

