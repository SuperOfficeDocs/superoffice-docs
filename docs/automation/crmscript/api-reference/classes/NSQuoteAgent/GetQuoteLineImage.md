---
uid: crmscript_ref_NSQuoteAgent_GetQuoteLineImage
title: NSImage GetQuoteLineImage(Integer quoteLineId, Integer rank)
intellisense: NSQuoteAgent.GetQuoteLineImage
keywords: NSQuoteAgent, GetQuoteLineImage
so.topic: reference
---

# NSImage GetQuoteLineImage(Integer quoteLineId, Integer rank)

Gets an image connected to a quoteline, either from the ERPProvider or from the SuperOffice database

**Parameters:**
 - **quoteLineId** Primary key of the quoteline
 - **rank** The rank of the image.

**Returns:** NSImage

```crmscript
NSQuoteAgent agent;
Integer quoteLineId;
Integer rank;
NSImage res = agent.GetQuoteLineImage(quoteLineId, rank);
```

