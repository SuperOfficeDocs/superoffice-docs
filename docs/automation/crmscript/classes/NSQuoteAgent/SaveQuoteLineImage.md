---
uid: crmscript_ref_NSQuoteAgent_SaveQuoteLineImage
title: Void SaveQuoteLineImage(Integer quoteLineId, Image image, Integer rank)
intellisense: NSQuoteAgent.SaveQuoteLineImage
keywords: NSQuoteAgent, SaveQuoteLineImage
so.topic: reference
---

Saves the image connected to a quoteline in the SuperOffice database

**Parameters:**
 - **quoteLineId** Primary key of the quoteline
 - **image** The image.
 - **rank** The rank of the image.

**Returns:** Nothing

```crmscript
NSQuoteAgent agent;
Integer quoteLineId;
Image image;
Integer rank;
Void res = agent.SaveQuoteLineImage(quoteLineId, image, rank);
```

