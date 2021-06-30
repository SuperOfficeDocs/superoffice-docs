---
uid: crmscript_ref_NSQuoteAgent_SaveQuoteLines
title: QuoteLine[] SaveQuoteLines(QuoteLine[] quoteLines)
intellisense: NSQuoteAgent.SaveQuoteLines
keywords: NSQuoteAgent, SaveQuoteLines
so.topic: reference
---

Saves the QuoteLines in the SuperOffice database

**Parameters:**
 - **quoteLines** The QuoteLines to save.

**Returns:** The updated quote lines (If the quoteline was new, it returns with id's set.

```crmscript
NSQuoteAgent agent;
QuoteLine[] quoteLines;
QuoteLine[] res = agent.SaveQuoteLines(quoteLines);
```

