---
uid: crmscript_ref_NSCRMScriptAgent_CreateDefaultTriggerScriptEntity
title: NSTriggerScriptEntity CreateDefaultTriggerScriptEntity()
intellisense: NSCRMScriptAgent.CreateDefaultTriggerScriptEntity
keywords: NSCRMScriptAgent, CreateDefaultTriggerScriptEntity
so.topic: reference
---
	  
Set default values into a new NSTriggerScriptEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSTriggerScriptEntity with default values.

```crmscript
NSCRMScriptAgent agent;
NSTriggerScriptEntity thing = agent.CreateDefaultTriggerScriptEntity();
thing = agent.SaveTriggerScriptEntity(thing);
```

