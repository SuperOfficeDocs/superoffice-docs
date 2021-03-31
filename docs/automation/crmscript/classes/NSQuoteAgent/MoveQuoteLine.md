---
uid: crmscript_ref_NSQuoteAgent_MoveQuoteLine
title: Void MoveQuoteLine(Integer quoteLineId, Bool direction)
intellisense: NSQuoteAgent.MoveQuoteLine
keywords: NSQuoteAgent, MoveQuoteLine
so.topic: reference
---

Move quote line rank up/down

**Parameters:**
 - **quoteLineId** Id of quote line to move up/down
 - **direction** True is up, false is down

**Returns:** Void return

```crmscript
NSQuoteAgent agent;
Integer quoteLineId;
Bool direction;
Void res = agent.MoveQuoteLine(quoteLineId, direction);
```

