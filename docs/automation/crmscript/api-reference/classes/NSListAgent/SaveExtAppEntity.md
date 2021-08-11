---
uid: crmscript_ref_NSListAgent_SaveExtAppEntity
title: NSExtAppEntity SaveExtAppEntity(NSExtAppEntity extAppEntity);
intellisense: NSListAgent.SaveExtAppEntity
keywords: NSListAgent, SaveExtAppEntity
so.topic: reference
---

# NSExtAppEntity SaveExtAppEntity(NSExtAppEntity extAppEntity);
	  
Updates the existing NSExtAppEntity or creates a new NSExtAppEntity if the id parameter is 0
	  
**Parameters**:
 - **extAppEntity** The NSExtAppEntity to save.

**Returns:** NSExtAppEntity

```crmscript
NSList  agent;
NSExtAppEntity thing = agent.CreateDefaultExtAppEntity();
thing = agent.SaveExtAppEntity(thing);
```

