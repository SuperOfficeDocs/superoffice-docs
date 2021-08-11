---
uid: crmscript_ref_NSBLOBAgent_GetProductThumbnail
title: NSImage GetProductThumbnail(Integer productId)
intellisense: NSBLOBAgent.GetProductThumbnail
keywords: NSBLOBAgent, GetProductThumbnail
so.topic: reference
---

# NSImage GetProductThumbnail(Integer productId)

Returns the product thumbnail that is displayed in the CRM application.

**Parameters:**
 - **productId** The product id of the product the thumbnail belongs to.

**Returns:** NSImage

```crmscript
NSBLOBAgent agent;
Integer productId;
NSImage res = agent.GetProductThumbnail(productId);
```

