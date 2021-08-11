---
uid: crmscript_ref_NSCRMScriptAgent_ValidateScript
title: NSCRMScriptResult ValidateScript(Integer cRMScriptId)
intellisense: NSCRMScriptAgent.ValidateScript
keywords: NSCRMScriptAgent, ValidateScript
so.topic: reference
---

# NSCRMScriptResult ValidateScript(Integer cRMScriptId)

Validate a CRMScript. This will check that the syntax is correct

**Parameters:**
 - **cRMScriptId** The id of the CRMScript to execute

**Returns:** True of the syntax is correct

```crmscript
NSCRMScriptAgent agent;
Integer cRMScriptId;
NSCRMScriptResult res = agent.ValidateScript(cRMScriptId);
```

