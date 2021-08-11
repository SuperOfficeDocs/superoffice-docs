---
uid: crmscript_ref_NSQuoteAgent_SaveProduct
title: NSProduct SaveProduct(NSProduct product);
intellisense: NSQuoteAgent.SaveProduct
keywords: NSQuoteAgent, SaveProduct
so.topic: reference
---

# NSProduct SaveProduct(NSProduct product);
	  
Updates the existing NSProduct or creates a new NSProduct if the id parameter is 0
	  
**Parameters**:
 - **product** The NSProduct to save.

**Returns:** NSProduct

```crmscript
NSQuote  agent;
NSProduct thing = agent.CreateDefaultProduct();
thing = agent.SaveProduct(thing);
```

