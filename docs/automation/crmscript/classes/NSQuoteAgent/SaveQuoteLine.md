---
uid: crmscript_ref_NSQuoteAgent_SaveQuoteLine
title: QuoteLine SaveQuoteLine(QuoteLine quoteLine)
intellisense: NSQuoteAgent.SaveQuoteLine
keywords: NSQuoteAgent, SaveQuoteLine
so.topic: reference
---

Saves the QuoteLine in the SuperOffice database

**Parameters:**
 - **quoteLine** The QuoteLine to save.

**Returns:** The updated quote line (If the quoteline was new, it returns with id's set.

```crmscript
NSQuoteAgent agent;
QuoteLine quoteLine;
QuoteLine res = agent.SaveQuoteLine(quoteLine);
```

