---
title: crmscript_ref_NSQuoteAgent_SaveQuoteLineConfigurations
description: QuoteLineConfigurationArray SaveQuoteLineConfigurations(QuoteLineConfigurationArray quoteLineConfigurations)
intellisense: NSQuoteAgent.SaveQuoteLineConfigurations
keywords: NSQuoteAgent,SaveQuoteLineConfigurations
so.topic: reference
---

Save a collection of QuoteLineConfigurations. It is not possible to add a new configurations.

**Parameters:**
 - **quoteLineConfigurations** The QuoteLineConfigurations to save.

**Returns:** The saved QuoteLineConfigurations.

```crmscript
NSQuoteAgent agent;
QuoteLineConfigurationArray quoteLineConfigurations;
QuoteLineConfigurationArray res = agent.SaveQuoteLineConfigurations(quoteLineConfigurations);
```

