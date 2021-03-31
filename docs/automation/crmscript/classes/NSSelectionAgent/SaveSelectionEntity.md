---
title: crmscript_ref_NSSelectionAgent_SaveSelectionEntity
description: NSSelectionEntity SaveSelectionEntity(NSSelectionEntity selectionEntity);
intellisense: NSSelectionAgent.SaveSelectionEntity
keywords: NSSelectionAgent,SaveSelectionEntity
so.topic: reference
---
	  
Updates the existing NSSelectionEntity or creates a new NSSelectionEntity if the id parameter is 0
	  
**Parameters**:
 - **selectionEntity** The NSSelectionEntity to save.

**Returns:** New or updated NSSelectionEntity

```crmscript
NSSelection  agent;
NSSelectionEntity thing = agent.CreateDefaultSelectionEntity();
thing = agent.SaveSelectionEntity(thing);
```

