---
uid: crmscript_ref_NSCRMScriptAgent_ValidateScriptByIncludeId
title: NSCRMScriptResult ValidateScriptByIncludeId(String cRMScriptIncludeId)
intellisense: NSCRMScriptAgent.ValidateScriptByIncludeId
keywords: NSCRMScriptAgent, ValidateScriptByIncludeId
so.topic: reference
---

Validate a CRMScript. This will check that the syntax is correct

**Parameters:**
 - **cRMScriptIncludeId** The include id of the CRMScript to validate

**Returns:** True of the syntax is correct

```crmscript
NSCRMScriptAgent agent;
String cRMScriptIncludeId;
NSCRMScriptResult res = agent.ValidateScriptByIncludeId(cRMScriptIncludeId);
```

