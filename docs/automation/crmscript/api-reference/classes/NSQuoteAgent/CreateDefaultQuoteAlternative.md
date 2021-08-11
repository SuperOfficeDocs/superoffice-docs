---
uid: crmscript_ref_NSQuoteAgent_CreateDefaultQuoteAlternative
title: NSQuoteAlternative CreateDefaultQuoteAlternative()
intellisense: NSQuoteAgent.CreateDefaultQuoteAlternative
keywords: NSQuoteAgent, CreateDefaultQuoteAlternative
so.topic: reference
---

# NSQuoteAlternative CreateDefaultQuoteAlternative()
	  
Set default values into a new NSQuoteAlternative.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** NSQuoteAlternative

```crmscript
NSQuoteAgent agent;
NSQuoteAlternative thing = agent.CreateDefaultQuoteAlternative();
thing = agent.SaveQuoteAlternative(thing);
```

