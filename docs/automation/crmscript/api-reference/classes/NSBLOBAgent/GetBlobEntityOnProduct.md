---
uid: crmscript_ref_NSBLOBAgent_GetBlobEntityOnProduct
title: NSBlobEntity GetBlobEntityOnProduct(Integer productId)
intellisense: NSBLOBAgent.GetBlobEntityOnProduct
keywords: NSBLOBAgent, GetBlobEntityOnProduct
so.topic: reference
---

Gets the blob entity that represents the product image binary object.

**Parameters:**
 - **productId** The product id

**Returns:** NSBlobEntity

```crmscript
NSBLOBAgent agent;
Integer productId;
NSBlobEntity res = agent.GetBlobEntityOnProduct(productId);
```

