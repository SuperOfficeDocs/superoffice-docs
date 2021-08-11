---
uid: crmscript_ref_NSBLOBAgent_SetProductImage
title: Void SetProductImage(Integer productId, NSImage image)
intellisense: NSBLOBAgent.SetProductImage
keywords: NSBLOBAgent, SetProductImage
so.topic: reference
---

# Void SetProductImage(Integer productId, NSImage image)

Stores the product image that is displayed in the CRM application. The image is scaled down to max 1000x1000. This method operates only the main (rank=1) image; future extensions may support multiple images. A thumbnail of size 75x75 is also automatically set.

**Parameters:**
 - **productId** The product id of the product the image belongs to.
 - **image** The image that is stored on the product (System.Drawing.Image), scaled down to no more than 1000x1000
