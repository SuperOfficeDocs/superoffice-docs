---
uid: crmscript_ref_NSQuoteAgent_CreateQuoteLine
title: QuoteLine CreateQuoteLine(Integer quoteAlternativeId, String eRPProductKey)
intellisense: NSQuoteAgent.CreateQuoteLine
keywords: NSQuoteAgent, CreateQuoteLine
so.topic: reference
---

Create a quoteline based on a product key.

**Parameters:**
 - **quoteAlternativeId** Primary key of the alternative
 - **eRPProductKey** Primary key of the product in the ProductProvider

**Returns:** The updated quote line.

```crmscript
NSQuoteAgent agent;
Integer quoteAlternativeId;
String eRPProductKey;
QuoteLine res = agent.CreateQuoteLine(quoteAlternativeId, eRPProductKey);
```

