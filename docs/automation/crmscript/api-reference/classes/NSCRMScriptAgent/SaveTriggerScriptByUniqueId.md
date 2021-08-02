---
uid: crmscript_ref_NSCRMScriptAgent_SaveTriggerScriptByUniqueId
title: NSTriggerScriptEntity SaveTriggerScriptByUniqueId(String triggerScriptUniqueId, NSTriggerScriptEntity entity)
intellisense: NSCRMScriptAgent.SaveTriggerScriptByUniqueId
keywords: NSCRMScriptAgent, SaveTriggerScriptByUniqueId
so.topic: reference
---

Validate a CRMScript. This will check that the syntax is correct

**Parameters:**
 - **triggerScriptUniqueId** The unique id of the CRMScript to validate
 - **entity** Trigger script details and source code

**Returns:** NSTriggerScriptEntity

```crmscript
NSCRMScriptAgent agent;
String triggerScriptUniqueId;
NSTriggerScriptEntity entity;
NSTriggerScriptEntity res = agent.SaveTriggerScriptByUniqueId(triggerScriptUniqueId, entity);
```

