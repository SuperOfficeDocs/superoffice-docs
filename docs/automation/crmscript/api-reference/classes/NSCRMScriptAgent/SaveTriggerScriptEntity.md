---
uid: crmscript_ref_NSCRMScriptAgent_SaveTriggerScriptEntity
title: NSTriggerScriptEntity SaveTriggerScriptEntity(NSTriggerScriptEntity triggerScriptEntity);
intellisense: NSCRMScriptAgent.SaveTriggerScriptEntity
keywords: NSCRMScriptAgent, SaveTriggerScriptEntity
so.topic: reference
---

# NSTriggerScriptEntity SaveTriggerScriptEntity(NSTriggerScriptEntity triggerScriptEntity);
	  
Updates the existing NSTriggerScriptEntity or creates a new NSTriggerScriptEntity if the id parameter is 0
	  
**Parameters**:
 - **triggerScriptEntity** The NSTriggerScriptEntity to save.

**Returns:** NSTriggerScriptEntity

```crmscript
NSCRMScriptAgent  agent;
NSTriggerScriptEntity thing = agent.CreateDefaultTriggerScriptEntity();
thing = agent.SaveTriggerScriptEntity(thing);
```

