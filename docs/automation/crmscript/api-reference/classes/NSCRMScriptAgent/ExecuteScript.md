---
uid: crmscript_ref_NSCRMScriptAgent_ExecuteScript
title: String ExecuteScript(Integer cRMScriptId, StringDictionary parameters)
intellisense: NSCRMScriptAgent.ExecuteScript
keywords: NSCRMScriptAgent, ExecuteScript
so.topic: reference
---

# String ExecuteScript(Integer cRMScriptId, StringDictionary parameters)

Execute a CRMScript with parameters, returning printed output value.

**Parameters:**
 - **cRMScriptId** The id of the CRMScript to execute
 - **parameters** Parameters passed as variables to the CRMScript

**Returns:** String

```crmscript
NSCRMScriptAgent agent;
Integer cRMScriptId;
StringDictionary parameters;
String res = agent.ExecuteScript(cRMScriptId, parameters);
```

