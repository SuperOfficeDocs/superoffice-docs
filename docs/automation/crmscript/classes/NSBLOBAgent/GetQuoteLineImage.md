---
title: crmscript_ref_NSBLOBAgent_GetQuoteLineImage
description: Image GetQuoteLineImage(Integer quoteLineId)
intellisense: NSBLOBAgent.GetQuoteLineImage
keywords: NSBLOBAgent,GetQuoteLineImage
so.topic: reference
---

Returns the quoteline image (rank=1) that is displayed in the CRM application.

**Parameters:**
 - **quoteLineId** The product id of the quoteline the image belongs to.

**Returns:** The image as a System.Drawing.Image. (If the the image is returned over webservices, the stream is returned as a Base64 encoded string.)

```crmscript
NSBLOBAgent agent;
Integer quoteLineId;
Image res = agent.GetQuoteLineImage(quoteLineId);
```

