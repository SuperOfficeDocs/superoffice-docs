---
uid: crmscript_ref_NSQuoteAgent_SaveQuoteLineConfigurations
title: NSQuoteLineConfiguration[] SaveQuoteLineConfigurations(NSQuoteLineConfiguration[] quoteLineConfigurations)
intellisense: NSQuoteAgent.SaveQuoteLineConfigurations
keywords: NSQuoteAgent, SaveQuoteLineConfigurations
so.topic: reference
---

# NSQuoteLineConfiguration[] SaveQuoteLineConfigurations(NSQuoteLineConfiguration[] quoteLineConfigurations)

Save a collection of QuoteLineConfigurations. It is not possible to add a new configurations.

**Parameters:**
 - **quoteLineConfigurations** The QuoteLineConfigurations to save.

**Returns:** NSQuoteLineConfiguration[]

```crmscript
NSQuoteAgent agent;
NSQuoteLineConfiguration[] quoteLineConfigurations;
NSQuoteLineConfiguration[] res = agent.SaveQuoteLineConfigurations(quoteLineConfigurations);
```

