---
title: crmscript_ref_NSQuoteAgent_UpdateQuoteVersionPrices
description: QuoteVersionValidated UpdateQuoteVersionPrices(Integer quoteVersionId)
intellisense: NSQuoteAgent.UpdateQuoteVersionPrices
keywords: NSQuoteAgent,UpdateQuoteVersionPrices
so.topic: reference
---

Update price on the all the quotelines for each alternative in the current quote version

**Parameters:**
 - **quoteVersionId** The version to be update prices for

**Returns:** The updated quote version.

```crmscript
NSQuoteAgent agent;
Integer quoteVersionId;
QuoteVersionValidated res = agent.UpdateQuoteVersionPrices(quoteVersionId);
```

