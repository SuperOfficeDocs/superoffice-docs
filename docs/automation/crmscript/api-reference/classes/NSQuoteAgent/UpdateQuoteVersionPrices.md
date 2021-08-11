---
uid: crmscript_ref_NSQuoteAgent_UpdateQuoteVersionPrices
title: NSQuoteVersionValidated UpdateQuoteVersionPrices(Integer quoteVersionId)
intellisense: NSQuoteAgent.UpdateQuoteVersionPrices
keywords: NSQuoteAgent, UpdateQuoteVersionPrices
so.topic: reference
---

# NSQuoteVersionValidated UpdateQuoteVersionPrices(Integer quoteVersionId)

Update price on the all the quotelines for each alternative in the current quote version

**Parameters:**
 - **quoteVersionId** The version to be update prices for

**Returns:** NSQuoteVersionValidated

```crmscript
NSQuoteAgent agent;
Integer quoteVersionId;
NSQuoteVersionValidated res = agent.UpdateQuoteVersionPrices(quoteVersionId);
```

