---
uid: crmscript_ref_NSCRMScriptAgent_SaveTriggerScriptEntity
title: NSTriggerScriptEntity SaveTriggerScriptEntity(NSTriggerScriptEntity triggerScriptEntity);
intellisense: NSCRMScriptAgent.SaveTriggerScriptEntity
keywords: NSCRMScriptAgent, SaveTriggerScriptEntity
so.topic: reference
---
	  
Updates the existing NSTriggerScriptEntity or creates a new NSTriggerScriptEntity if the id parameter is 0
	  
**Parameters**:
 - **triggerScriptEntity** The NSTriggerScriptEntity to save.

**Returns:** New or updated NSTriggerScriptEntity

```crmscript
NSCRMScript  agent;
NSTriggerScriptEntity thing = agent.CreateDefaultTriggerScriptEntity();
thing = agent.SaveTriggerScriptEntity(thing);
```

