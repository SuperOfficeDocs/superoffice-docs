---
title: crmscript_ref_NSListAgent_SaveRelationDefinitionEntity
description: NSRelationDefinitionEntity SaveRelationDefinitionEntity(NSRelationDefinitionEntity relationDefinitionEntity);
intellisense: NSListAgent.SaveRelationDefinitionEntity
keywords: NSListAgent,SaveRelationDefinitionEntity
so.topic: reference
---
	  
Updates the existing NSRelationDefinitionEntity or creates a new NSRelationDefinitionEntity if the id parameter is 0
	  
**Parameters**:
 - **relationDefinitionEntity** The NSRelationDefinitionEntity to save.

**Returns:** New or updated NSRelationDefinitionEntity

```crmscript
NSList  agent;
NSRelationDefinitionEntity thing = agent.CreateDefaultRelationDefinitionEntity();
thing = agent.SaveRelationDefinitionEntity(thing);
```

