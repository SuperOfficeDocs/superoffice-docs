---
uid: crmscript_ref_NSListAgent_SaveAmountClassEntity
title: NSAmountClassEntity SaveAmountClassEntity(NSAmountClassEntity amountClassEntity);
intellisense: NSListAgent.SaveAmountClassEntity
keywords: NSListAgent, SaveAmountClassEntity
so.topic: reference
---
	  
Updates the existing NSAmountClassEntity or creates a new NSAmountClassEntity if the id parameter is 0
	  
**Parameters**:
 - **amountClassEntity** The NSAmountClassEntity to save.

**Returns:** NSAmountClassEntity

```crmscript
NSList  agent;
NSAmountClassEntity thing = agent.CreateDefaultAmountClassEntity();
thing = agent.SaveAmountClassEntity(thing);
```

