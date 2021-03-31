---
title: crmscript_ref_NSCRMScriptAgent_GetTriggerScriptByUniqueId
description: TriggerScriptEntity GetTriggerScriptByUniqueId(String triggerScriptUniqueId)
intellisense: NSCRMScriptAgent.GetTriggerScriptByUniqueId
keywords: NSCRMScriptAgent,GetTriggerScriptByUniqueId
so.topic: reference
---

Get a trigger CRMScript.

**Parameters:**
 - **triggerScriptUniqueId** The unique id of the CRMScript to validate

**Returns:** Trigger script details and source code.

```crmscript
NSCRMScriptAgent agent;
String triggerScriptUniqueId;
TriggerScriptEntity res = agent.GetTriggerScriptByUniqueId(triggerScriptUniqueId);
```

