---
title: crmscript_ref_NSCRMScriptAgent_ValidateScriptByUniqueId
description: CRMScriptResult ValidateScriptByUniqueId(String cRMScriptUniqueId)
intellisense: NSCRMScriptAgent.ValidateScriptByUniqueId
keywords: NSCRMScriptAgent,ValidateScriptByUniqueId
so.topic: reference
---

Validate a CRMScript. This will check that the syntax is correct

**Parameters:**
 - **cRMScriptUniqueId** The unique id of the CRMScript to validate

**Returns:** True of the syntax is correct

```crmscript
NSCRMScriptAgent agent;
String cRMScriptUniqueId;
CRMScriptResult res = agent.ValidateScriptByUniqueId(cRMScriptUniqueId);
```

