---
uid: crmscript_ref_NSQuoteAgent_SaveQuoteLines
title: NSQuoteLine[] SaveQuoteLines(NSQuoteLine[] quoteLines)
intellisense: NSQuoteAgent.SaveQuoteLines
keywords: NSQuoteAgent, SaveQuoteLines
so.topic: reference
---

# NSQuoteLine[] SaveQuoteLines(NSQuoteLine[] quoteLines)

Saves the QuoteLines in the SuperOffice database

**Parameters:**
 - **quoteLines** The QuoteLines to save.

**Returns:** NSQuoteLine[]

```crmscript
NSQuoteAgent agent;
NSQuoteLine[] quoteLines;
NSQuoteLine[] res = agent.SaveQuoteLines(quoteLines);
```

