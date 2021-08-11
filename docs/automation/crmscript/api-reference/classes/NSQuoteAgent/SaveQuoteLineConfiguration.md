---
uid: crmscript_ref_NSQuoteAgent_SaveQuoteLineConfiguration
title: NSQuoteLineConfiguration SaveQuoteLineConfiguration(NSQuoteLineConfiguration quoteLineConfiguration)
intellisense: NSQuoteAgent.SaveQuoteLineConfiguration
keywords: NSQuoteAgent, SaveQuoteLineConfiguration
so.topic: reference
---

# NSQuoteLineConfiguration SaveQuoteLineConfiguration(NSQuoteLineConfiguration quoteLineConfiguration)

Save a NSQuoteLineConfiguration object. It is not possible to add a new configuration.

**Parameters:**
 - **quoteLineConfiguration** The QuoteLineConfiguration to save.

**Returns:** NSQuoteLineConfiguration

```crmscript
NSQuoteAgent agent;
NSQuoteLineConfiguration quoteLineConfiguration;
NSQuoteLineConfiguration res = agent.SaveQuoteLineConfiguration(quoteLineConfiguration);
```

