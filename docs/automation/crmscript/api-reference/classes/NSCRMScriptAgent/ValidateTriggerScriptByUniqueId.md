---
uid: crmscript_ref_NSCRMScriptAgent_ValidateTriggerScriptByUniqueId
title: NSCRMScriptResult ValidateTriggerScriptByUniqueId(String triggerScriptUniqueId)
intellisense: NSCRMScriptAgent.ValidateTriggerScriptByUniqueId
keywords: NSCRMScriptAgent, ValidateTriggerScriptByUniqueId
so.topic: reference
---

Validate a Trigger CRMScript. This will check that the syntax is correct, but not execute the script.

**Parameters:**
 - **triggerScriptUniqueId** The unique id of the CRMScript to validate

**Returns:** True of the syntax is correct

```crmscript
NSCRMScriptAgent agent;
String triggerScriptUniqueId;
NSCRMScriptResult res = agent.ValidateTriggerScriptByUniqueId(triggerScriptUniqueId);
```

