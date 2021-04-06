---
uid: crmscript_ref_NSListAgent_SaveCurrencyEntity
title: NSCurrencyEntity SaveCurrencyEntity(NSCurrencyEntity currencyEntity);
intellisense: NSListAgent.SaveCurrencyEntity
keywords: NSListAgent, SaveCurrencyEntity
so.topic: reference
---
	  
Updates the existing NSCurrencyEntity or creates a new NSCurrencyEntity if the id parameter is 0
	  
**Parameters**:
 - **currencyEntity** The NSCurrencyEntity to save.

**Returns:** New or updated NSCurrencyEntity

```crmscript
NSList  agent;
NSCurrencyEntity thing = agent.CreateDefaultCurrencyEntity();
thing = agent.SaveCurrencyEntity(thing);
```

