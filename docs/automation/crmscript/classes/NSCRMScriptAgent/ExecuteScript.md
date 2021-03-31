---
title: crmscript_ref_NSCRMScriptAgent_ExecuteScript
description: String ExecuteScript(Integer cRMScriptId, StringDictionary parameters)
intellisense: NSCRMScriptAgent.ExecuteScript
keywords: NSCRMScriptAgent,ExecuteScript
so.topic: reference
---

Execute a CRMScript with parameters, returning printed output value.

**Parameters:**
 - **cRMScriptId** The id of the CRMScript to execute
 - **parameters** Parameters passed as variables to the CRMScript

**Returns:** The output produced by the CRMScript

```crmscript
NSCRMScriptAgent agent;
Integer cRMScriptId;
StringDictionary parameters;
String res = agent.ExecuteScript(cRMScriptId, parameters);
```

