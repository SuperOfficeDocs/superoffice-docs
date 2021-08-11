---
uid: crmscript_ref_NSBLOBAgent_SetProductThumbnail
title: Void SetProductThumbnail(Integer productId, NSImage image)
intellisense: NSBLOBAgent.SetProductThumbnail
keywords: NSBLOBAgent, SetProductThumbnail
so.topic: reference
---

# Void SetProductThumbnail(Integer productId, NSImage image)

Stores the product thumbnail that is displayed in the CRM application. The image is scaled down to max 200x200 pixels.

**Parameters:**
 - **productId** The product id of the product the image belongs to.
 - **image** The image that is stored on the product (System.Drawing.Image); scaled down to no more than 200x200
