---
uid: crmscript_ref_NSForeignSystemAgent_SaveForeignAppEntity
title: NSForeignAppEntity SaveForeignAppEntity(NSForeignAppEntity foreignAppEntity);
intellisense: NSForeignSystemAgent.SaveForeignAppEntity
keywords: NSForeignSystemAgent, SaveForeignAppEntity
so.topic: reference
---
	  
Updates the existing NSForeignAppEntity or creates a new NSForeignAppEntity if the id parameter is 0
	  
**Parameters**:
 - **foreignAppEntity** The NSForeignAppEntity to save.

**Returns:** New or updated NSForeignAppEntity

```crmscript
NSForeignSystem  agent;
NSForeignAppEntity thing = agent.CreateDefaultForeignAppEntity();
thing = agent.SaveForeignAppEntity(thing);
```

