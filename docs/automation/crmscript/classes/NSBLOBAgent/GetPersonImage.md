---
title: crmscript_ref_NSBLOBAgent_GetPersonImage
description: Image GetPersonImage(Integer personId)
intellisense: NSBLOBAgent.GetPersonImage
keywords: NSBLOBAgent,GetPersonImage
so.topic: reference
---

Returns the person image that is displayed in the CRM application.

**Parameters:**
 - **personId** The person id of the person the image belongs to.

**Returns:** The image as a System.Drawing.Image. (If the the image is returned over webservices, the stream is returned as a Base64 encoded string.)

```crmscript
NSBLOBAgent agent;
Integer personId;
Image res = agent.GetPersonImage(personId);
```

