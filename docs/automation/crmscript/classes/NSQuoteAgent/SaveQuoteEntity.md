---
title: crmscript_ref_NSQuoteAgent_SaveQuoteEntity
description: QuoteEntity SaveQuoteEntity(QuoteEntity quoteEntity)
intellisense: NSQuoteAgent.SaveQuoteEntity
keywords: NSQuoteAgent,SaveQuoteEntity
so.topic: reference
---

Saves a QuoteEntity. Versions and alternatives will not be saved by this call.

**Parameters:**
 - **quoteEntity** The Quote entity to save

**Returns:** The saved Quote

```crmscript
NSQuoteAgent agent;
QuoteEntity quoteEntity;
QuoteEntity res = agent.SaveQuoteEntity(quoteEntity);
```

