---
uid: crmscript_ref_NSQuoteAgent_SaveQuoteLineConfiguration
title: QuoteLineConfiguration SaveQuoteLineConfiguration(QuoteLineConfiguration quoteLineConfiguration)
intellisense: NSQuoteAgent.SaveQuoteLineConfiguration
keywords: NSQuoteAgent, SaveQuoteLineConfiguration
so.topic: reference
---

Save a QuoteLineConfiguration object. It is not possible to add a new configuration.

**Parameters:**
 - **quoteLineConfiguration** The QuoteLineConfiguration to save.

**Returns:** The saved QuoteLineConfiguration.

```crmscript
NSQuoteAgent agent;
QuoteLineConfiguration quoteLineConfiguration;
QuoteLineConfiguration res = agent.SaveQuoteLineConfiguration(quoteLineConfiguration);
```

