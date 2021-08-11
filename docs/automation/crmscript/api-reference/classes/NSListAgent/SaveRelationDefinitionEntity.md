---
uid: crmscript_ref_NSListAgent_SaveRelationDefinitionEntity
title: NSRelationDefinitionEntity SaveRelationDefinitionEntity(NSRelationDefinitionEntity relationDefinitionEntity);
intellisense: NSListAgent.SaveRelationDefinitionEntity
keywords: NSListAgent, SaveRelationDefinitionEntity
so.topic: reference
---

# NSRelationDefinitionEntity SaveRelationDefinitionEntity(NSRelationDefinitionEntity relationDefinitionEntity);
	  
Updates the existing NSRelationDefinitionEntity or creates a new NSRelationDefinitionEntity if the id parameter is 0
	  
**Parameters**:
 - **relationDefinitionEntity** The NSRelationDefinitionEntity to save.

**Returns:** NSRelationDefinitionEntity

```crmscript
NSList  agent;
NSRelationDefinitionEntity thing = agent.CreateDefaultRelationDefinitionEntity();
thing = agent.SaveRelationDefinitionEntity(thing);
```

