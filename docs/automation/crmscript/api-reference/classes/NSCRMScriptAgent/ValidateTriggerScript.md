---
uid: crmscript_ref_NSCRMScriptAgent_ValidateTriggerScript
title: NSCRMScriptResult ValidateTriggerScript(Integer triggerScriptId)
intellisense: NSCRMScriptAgent.ValidateTriggerScript
keywords: NSCRMScriptAgent, ValidateTriggerScript
so.topic: reference
---

# NSCRMScriptResult ValidateTriggerScript(Integer triggerScriptId)

Validate a Trigger CRMScript. This will check that the syntax is correct, but not execute the script.

**Parameters:**
 - **triggerScriptId** The id of the CRMScript Trigger to validate

**Returns:** True of the syntax is correct

```crmscript
NSCRMScriptAgent agent;
Integer triggerScriptId;
NSCRMScriptResult res = agent.ValidateTriggerScript(triggerScriptId);
```

