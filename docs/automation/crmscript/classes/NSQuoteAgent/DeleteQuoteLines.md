---
title: crmscript_ref_NSQuoteAgent_DeleteQuoteLines
description: Void DeleteQuoteLines(IntegerArray quoteLineIds)
intellisense: NSQuoteAgent.DeleteQuoteLines
keywords: NSQuoteAgent,DeleteQuoteLines
so.topic: reference
---

Delete the QuoteLines in the SuperOffice database

**Parameters:**
 - **quoteLineIds** Primary keys of the quotelines to delete

**Returns:** Nothing

```crmscript
NSQuoteAgent agent;
IntegerArray quoteLineIds;
Void res = agent.DeleteQuoteLines(quoteLineIds);
```

