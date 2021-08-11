---
uid: crmscript_ref_NSQuoteAgent_SavePriceList
title: NSPriceList SavePriceList(NSPriceList priceList);
intellisense: NSQuoteAgent.SavePriceList
keywords: NSQuoteAgent, SavePriceList
so.topic: reference
---

# NSPriceList SavePriceList(NSPriceList priceList);
	  
Updates the existing NSPriceList or creates a new NSPriceList if the id parameter is 0
	  
**Parameters**:
 - **priceList** The NSPriceList to save.

**Returns:** NSPriceList

```crmscript
NSQuote  agent;
NSPriceList thing = agent.CreateDefaultPriceList();
thing = agent.SavePriceList(thing);
```

