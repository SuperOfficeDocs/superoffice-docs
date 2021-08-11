---
uid: crmscript_ref_NSCRMScriptAgent_GetTriggerScriptByUniqueId
title: NSTriggerScriptEntity GetTriggerScriptByUniqueId(String triggerScriptUniqueId)
intellisense: NSCRMScriptAgent.GetTriggerScriptByUniqueId
keywords: NSCRMScriptAgent, GetTriggerScriptByUniqueId
so.topic: reference
---

# NSTriggerScriptEntity GetTriggerScriptByUniqueId(String triggerScriptUniqueId)

Get a trigger CRMScript.

**Parameters:**
 - **triggerScriptUniqueId** The unique id of the CRMScript to validate

**Returns:** Trigger script details and source code.

```crmscript
NSCRMScriptAgent agent;
String triggerScriptUniqueId;
NSTriggerScriptEntity res = agent.GetTriggerScriptByUniqueId(triggerScriptUniqueId);
```

