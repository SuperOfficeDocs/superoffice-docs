---
title: crmscript_ref_NSCRMScriptAgent_SaveCRMScriptEntity
description: NSCRMScriptEntity SaveCRMScriptEntity(NSCRMScriptEntity cRMScriptEntity);
intellisense: NSCRMScriptAgent.SaveCRMScriptEntity
keywords: NSCRMScriptAgent,SaveCRMScriptEntity
so.topic: reference
---
	  
Updates the existing NSCRMScriptEntity or creates a new NSCRMScriptEntity if the id parameter is 0
	  
**Parameters**:
 - **cRMScriptEntity** The NSCRMScriptEntity to save.

**Returns:** New or updated NSCRMScriptEntity

```crmscript
NSCRMScript  agent;
NSCRMScriptEntity thing = agent.CreateDefaultCRMScriptEntity();
thing = agent.SaveCRMScriptEntity(thing);
```

