---
uid: crmscript_ref_NSListAgent_CreateDefaultHierarchyEntity
title: NSHierarchyEntity CreateDefaultHierarchyEntity()
intellisense: NSListAgent.CreateDefaultHierarchyEntity
keywords: NSListAgent, CreateDefaultHierarchyEntity
so.topic: reference
---
	  
Set default values into a new NSHierarchyEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSHierarchyEntity with default values.

```crmscript
NSListAgent agent;
NSHierarchyEntity thing = agent.CreateDefaultHierarchyEntity();
thing = agent.SaveHierarchyEntity(thing);
```

