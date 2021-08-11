---
uid: crmscript_ref_NSListAgent_SaveListEntity
title: NSListEntity SaveListEntity(NSListEntity listEntity);
intellisense: NSListAgent.SaveListEntity
keywords: NSListAgent, SaveListEntity
so.topic: reference
---

# NSListEntity SaveListEntity(NSListEntity listEntity);
	  
Updates the existing NSListEntity or creates a new NSListEntity if the id parameter is 0
	  
**Parameters**:
 - **listEntity** The NSListEntity to save.

**Returns:** NSListEntity

```crmscript
NSList  agent;
NSListEntity thing = agent.CreateDefaultListEntity();
thing = agent.SaveListEntity(thing);
```

