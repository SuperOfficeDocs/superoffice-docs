---
uid: crmscript_ref_NSBLOBAgent_GetProductImage
title: Image GetProductImage(Integer productId)
intellisense: NSBLOBAgent.GetProductImage
keywords: NSBLOBAgent, GetProductImage
so.topic: reference
---

Returns the product image (rank=1) that is displayed in the CRM application.

**Parameters:**
 - **productId** The product id of the product the image belongs to.

**Returns:** The image as a System.Drawing.Image. (If the the image is returned over webservices, the stream is returned as a Base64 encoded string.)

```crmscript
NSBLOBAgent agent;
Integer productId;
Image res = agent.GetProductImage(productId);
```

