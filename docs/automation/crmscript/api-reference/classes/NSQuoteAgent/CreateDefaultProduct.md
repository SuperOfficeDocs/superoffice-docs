---
uid: crmscript_ref_NSQuoteAgent_CreateDefaultProduct
title: NSProduct CreateDefaultProduct()
intellisense: NSQuoteAgent.CreateDefaultProduct
keywords: NSQuoteAgent, CreateDefaultProduct
so.topic: reference
---
	  
Set default values into a new NSProduct.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** NSProduct

```crmscript
NSQuoteAgent agent;
NSProduct thing = agent.CreateDefaultProduct();
thing = agent.SaveProduct(thing);
```

