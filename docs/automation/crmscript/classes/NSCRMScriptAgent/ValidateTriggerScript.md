---
title: crmscript_ref_NSCRMScriptAgent_ValidateTriggerScript
description: CRMScriptResult ValidateTriggerScript(Integer triggerScriptId)
intellisense: NSCRMScriptAgent.ValidateTriggerScript
keywords: NSCRMScriptAgent,ValidateTriggerScript
so.topic: reference
---

Validate a Trigger CRMScript. This will check that the syntax is correct, but not execute the script.

**Parameters:**
 - **triggerScriptId** The id of the CRMScript Trigger to validate

**Returns:** True of the syntax is correct

```crmscript
NSCRMScriptAgent agent;
Integer triggerScriptId;
CRMScriptResult res = agent.ValidateTriggerScript(triggerScriptId);
```

