---
uid: crmscript_ref_NSCRMScriptAgent_SaveCRMScriptEntity
title: NSCRMScriptEntity SaveCRMScriptEntity(NSCRMScriptEntity cRMScriptEntity);
intellisense: NSCRMScriptAgent.SaveCRMScriptEntity
keywords: NSCRMScriptAgent, SaveCRMScriptEntity
so.topic: reference
---
	  
Updates the existing NSCRMScriptEntity or creates a new NSCRMScriptEntity if the id parameter is 0
	  
**Parameters**:
 - **cRMScriptEntity** The NSCRMScriptEntity to save.

**Returns:** NSCRMScriptEntity

```crmscript
NSCRMScriptAgent  agent;
NSCRMScriptEntity thing = agent.CreateDefaultCRMScriptEntity();
thing = agent.SaveCRMScriptEntity(thing);
```

