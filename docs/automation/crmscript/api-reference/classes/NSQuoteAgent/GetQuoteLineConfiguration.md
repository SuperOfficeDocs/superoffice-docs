---
uid: crmscript_ref_NSQuoteAgent_GetQuoteLineConfiguration
title: NSQuoteLineConfiguration GetQuoteLineConfiguration(Integer quoteLineConfigurationId)
intellisense: NSQuoteAgent.GetQuoteLineConfiguration
keywords: NSQuoteAgent, GetQuoteLineConfiguration
so.topic: reference
---

Returns the configuration field with the given id

**Parameters:**
 - **quoteLineConfigurationId** Id of the NSQuoteLineConfiguration to get.

**Returns:** NSQuoteLineConfiguration

```crmscript
NSQuoteAgent agent;
Integer quoteLineConfigurationId;
NSQuoteLineConfiguration res = agent.GetQuoteLineConfiguration(quoteLineConfigurationId);
```

