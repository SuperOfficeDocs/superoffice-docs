---
title: crmscript_ref_NSQuoteAgent_DeleteQuoteLine
description: Void DeleteQuoteLine(Integer quoteLineId)
intellisense: NSQuoteAgent.DeleteQuoteLine
keywords: NSQuoteAgent,DeleteQuoteLine
so.topic: reference
---

Deletes the QuoteLine in the SuperOffice database

**Parameters:**
 - **quoteLineId** Primary key of the quoteline to delete

**Returns:** Nothing

```crmscript
NSQuoteAgent agent;
Integer quoteLineId;
Void res = agent.DeleteQuoteLine(quoteLineId);
```

