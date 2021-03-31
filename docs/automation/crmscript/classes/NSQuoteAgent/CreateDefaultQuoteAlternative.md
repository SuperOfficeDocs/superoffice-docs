---
title: crmscript_ref_NSQuoteAgent_CreateDefaultQuoteAlternative
description: NSQuoteAlternative CreateDefaultQuoteAlternative()
intellisense: NSQuoteAgent.CreateDefaultQuoteAlternative
keywords: NSQuoteAgent,CreateDefaultQuoteAlternative
so.topic: reference
---
	  
Set default values into a new NSQuoteAlternative.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSQuoteAlternative with default values.

```crmscript
NSQuoteAgent agent;
NSQuoteAlternative thing = agent.CreateDefaultQuoteAlternative();
thing = agent.SaveQuoteAlternative(thing);
```

