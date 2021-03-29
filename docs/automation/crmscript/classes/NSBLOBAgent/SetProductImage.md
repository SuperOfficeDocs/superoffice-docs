---
title: crmscript_ref_NSBLOBAgent_SetProductImage_Integer_p_0_NSImage_p_1
description: NSBLOBAgent.SetProductImage(Integer p_0, NSImage p_1)
intellisense: NSBLOBAgent.SetProductImage
sortOrder: 1435
keywords: SetProductImage(Integer,NSImage)
so.topic: reference
---


Stores the product image that is displayed in the CRM application. The image is scaled down to max 1000x1000. This method operates only the main (rank=1) image; future extensions may support multiple images. A thumbnail of size 75x75 is also automatically set.



* **productId:** The project id of the product the image belongs to.
* **image:** The image that is stored on the product (System.Drawing.Image), scaled down to no more than 1000x1000


