---
uid: crmscript_ref_NSQuoteAgent_CreateDefaultPriceList
title: NSPriceList CreateDefaultPriceList()
intellisense: NSQuoteAgent.CreateDefaultPriceList
keywords: NSQuoteAgent, CreateDefaultPriceList
so.topic: reference
---
	  
Set default values into a new NSPriceList.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** NSPriceList

```crmscript
NSQuoteAgent agent;
NSPriceList thing = agent.CreateDefaultPriceList();
thing = agent.SavePriceList(thing);
```

