---
uid: crmscript_ref_NSQuoteAgent_GetQuoteLineConfiguration
title: QuoteLineConfiguration GetQuoteLineConfiguration(Integer quoteLineConfigurationId)
intellisense: NSQuoteAgent.GetQuoteLineConfiguration
keywords: NSQuoteAgent, GetQuoteLineConfiguration
so.topic: reference
---

Returns the configuration field with the given id

**Parameters:**
 - **quoteLineConfigurationId** Id of the QuoteLineConfiguration to get.

**Returns:** QuoteLineConfiguration

```crmscript
NSQuoteAgent agent;
Integer quoteLineConfigurationId;
QuoteLineConfiguration res = agent.GetQuoteLineConfiguration(quoteLineConfigurationId);
```

