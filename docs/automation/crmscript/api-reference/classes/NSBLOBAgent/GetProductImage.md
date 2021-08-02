---
uid: crmscript_ref_NSBLOBAgent_GetProductImage
title: NSImage GetProductImage(Integer productId)
intellisense: NSBLOBAgent.GetProductImage
keywords: NSBLOBAgent, GetProductImage
so.topic: reference
---

Returns the product image (rank=1) that is displayed in the CRM application.

**Parameters:**
 - **productId** The product id of the product the image belongs to.

**Returns:** NSImage

```crmscript
NSBLOBAgent agent;
Integer productId;
NSImage res = agent.GetProductImage(productId);
```

