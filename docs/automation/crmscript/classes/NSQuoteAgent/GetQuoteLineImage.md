---
title: crmscript_ref_NSQuoteAgent_GetQuoteLineImage
description: Image GetQuoteLineImage(Integer quoteLineId, Integer rank)
intellisense: NSQuoteAgent.GetQuoteLineImage
keywords: NSQuoteAgent,GetQuoteLineImage
so.topic: reference
---

Gets an image connected to a quoteline, either from the ERPProvider or from the SuperOffice database

**Parameters:**
 - **quoteLineId** Primary key of the quoteline
 - **rank** The rank of the image.

**Returns:** The image. Returns null if no image available.

```crmscript
NSQuoteAgent agent;
Integer quoteLineId;
Integer rank;
Image res = agent.GetQuoteLineImage(quoteLineId, rank);
```

