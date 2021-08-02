---
uid: crmscript_ref_NSQuoteAgent_SaveQuoteAlternative
title: NSQuoteAlternative SaveQuoteAlternative(NSQuoteAlternative quoteAlternative);
intellisense: NSQuoteAgent.SaveQuoteAlternative
keywords: NSQuoteAgent, SaveQuoteAlternative
so.topic: reference
---
	  
Updates the existing NSQuoteAlternative or creates a new NSQuoteAlternative if the id parameter is 0
	  
**Parameters**:
 - **quoteAlternative** The NSQuoteAlternative to save.

**Returns:** NSQuoteAlternative

```crmscript
NSQuoteAgent agent;
NSQuoteAlternative thing = agent.CreateDefaultQuoteAlternative();
thing = agent.SaveQuoteAlternative(thing);
```

