---
uid: crmscript_ref_NSQuoteAgent_SaveQuoteLineImage
title: Void SaveQuoteLineImage(Integer quoteLineId, NSImage image, Integer rank)
intellisense: NSQuoteAgent.SaveQuoteLineImage
keywords: NSQuoteAgent, SaveQuoteLineImage
so.topic: reference
---

Saves the image connected to a quoteline in the SuperOffice database

**Parameters:**
 - **quoteLineId** Primary key of the quoteline
 - **image** The image.
 - **rank** The rank of the image.


```crmscript
NSQuoteAgent agent;
Integer quoteLineId;
NSImage image;
Integer rank;
agent.SaveQuoteLineImage(quoteLineId, image, rank);
```

