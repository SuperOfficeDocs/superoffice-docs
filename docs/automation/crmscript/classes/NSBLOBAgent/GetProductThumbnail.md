---
title: crmscript_ref_NSBLOBAgent_GetProductThumbnail
description: Image GetProductThumbnail(Integer productId)
intellisense: NSBLOBAgent.GetProductThumbnail
keywords: NSBLOBAgent,GetProductThumbnail
so.topic: reference
---

Returns the product thumbnail that is displayed in the CRM application.

**Parameters:**
 - **productId** The product id of the product the thumbnail belongs to.

**Returns:** The thumbnail as a System.Drawing.Image. (If the the image is returned over webservices, the stream is returned as a Base64 encoded string.)

```crmscript
NSBLOBAgent agent;
Integer productId;
Image res = agent.GetProductThumbnail(productId);
```

