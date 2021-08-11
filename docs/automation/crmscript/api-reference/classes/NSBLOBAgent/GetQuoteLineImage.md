---
uid: crmscript_ref_NSBLOBAgent_GetQuoteLineImage
title: NSImage GetQuoteLineImage(Integer quoteLineId)
intellisense: NSBLOBAgent.GetQuoteLineImage
keywords: NSBLOBAgent, GetQuoteLineImage
so.topic: reference
---

# NSImage GetQuoteLineImage(Integer quoteLineId)

Returns the quoteline image (rank=1) that is displayed in the CRM application.

**Parameters:**
 - **quoteLineId** The product id of the quoteline the image belongs to.

**Returns:** NSImage

```crmscript
NSBLOBAgent agent;
Integer quoteLineId;
NSImage res = agent.GetQuoteLineImage(quoteLineId);
```

