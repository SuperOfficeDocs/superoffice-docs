---
uid: crmscript_ref_NSBLOBAgent_GetBlobEntityOnProduct
title: BlobEntity GetBlobEntityOnProduct(Integer productId)
intellisense: NSBLOBAgent.GetBlobEntityOnProduct
keywords: NSBLOBAgent, GetBlobEntityOnProduct
so.topic: reference
---

Gets the blob entity that represents the product image binary object.

**Parameters:**
 - **productId** The product id

**Returns:** BlobEntity object

```crmscript
NSBLOBAgent agent;
Integer productId;
BlobEntity res = agent.GetBlobEntityOnProduct(productId);
```

