---
title: crmscript_ref_NSCRMScriptAgent_SaveTriggerScriptByUniqueId
description: TriggerScriptEntity SaveTriggerScriptByUniqueId(String triggerScriptUniqueId, TriggerScriptEntity entity)
intellisense: NSCRMScriptAgent.SaveTriggerScriptByUniqueId
keywords: NSCRMScriptAgent,SaveTriggerScriptByUniqueId
so.topic: reference
---

Validate a CRMScript. This will check that the syntax is correct

**Parameters:**
 - **triggerScriptUniqueId** The unique id of the CRMScript to validate
 - **entity** Trigger script details and source code

**Returns:** Trigger script details and source code.

```crmscript
NSCRMScriptAgent agent;
String triggerScriptUniqueId;
TriggerScriptEntity entity;
TriggerScriptEntity res = agent.SaveTriggerScriptByUniqueId(triggerScriptUniqueId, entity);
```

