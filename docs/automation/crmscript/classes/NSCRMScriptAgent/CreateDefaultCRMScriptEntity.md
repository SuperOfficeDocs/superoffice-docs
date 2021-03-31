---
uid: crmscript_ref_NSCRMScriptAgent_CreateDefaultCRMScriptEntity
title: NSCRMScriptEntity CreateDefaultCRMScriptEntity()
intellisense: NSCRMScriptAgent.CreateDefaultCRMScriptEntity
keywords: NSCRMScriptAgent, CreateDefaultCRMScriptEntity
so.topic: reference
---
	  
Set default values into a new NSCRMScriptEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSCRMScriptEntity with default values.

```crmscript
NSCRMScriptAgent agent;
NSCRMScriptEntity thing = agent.CreateDefaultCRMScriptEntity();
thing = agent.SaveCRMScriptEntity(thing);
```

