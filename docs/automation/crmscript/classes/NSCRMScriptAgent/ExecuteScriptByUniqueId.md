---
title: crmscript_ref_NSCRMScriptAgent_ExecuteScriptByUniqueId
description: String ExecuteScriptByUniqueId(String cRMScriptUniqueId, StringDictionary parameters)
intellisense: NSCRMScriptAgent.ExecuteScriptByUniqueId
keywords: NSCRMScriptAgent,ExecuteScriptByUniqueId
so.topic: reference
---

Execute a CRMScript with parameters, returning printed output value.

**Parameters:**
 - **cRMScriptUniqueId** The unique id of the CRMScript to validate
 - **parameters** Parameters passed as variables to the CRMScript

**Returns:** The output produced by the CRMScript

```crmscript
NSCRMScriptAgent agent;
String cRMScriptUniqueId;
StringDictionary parameters;
String res = agent.ExecuteScriptByUniqueId(cRMScriptUniqueId, parameters);
```

