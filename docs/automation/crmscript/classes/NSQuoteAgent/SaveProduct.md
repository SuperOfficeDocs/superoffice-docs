---
title: crmscript_ref_NSQuoteAgent_SaveProduct
description: NSProduct SaveProduct(NSProduct product);
intellisense: NSQuoteAgent.SaveProduct
keywords: NSQuoteAgent,SaveProduct
so.topic: reference
---
	  
Updates the existing NSProduct or creates a new NSProduct if the id parameter is 0
	  
**Parameters**:
 - **product** The NSProduct to save.

**Returns:** New or updated NSProduct

```crmscript
NSQuote  agent;
NSProduct thing = agent.CreateDefaultProduct();
thing = agent.SaveProduct(thing);
```

