---
uid: crmscript_ref_NSCRMScriptAgent_ExecuteScriptByUniqueId
title: String ExecuteScriptByUniqueId(String cRMScriptUniqueId, StringDictionary parameters)
intellisense: NSCRMScriptAgent.ExecuteScriptByUniqueId
keywords: NSCRMScriptAgent, ExecuteScriptByUniqueId
so.topic: reference
---

Execute a CRMScript with parameters, returning printed output value.

**Parameters:**
 - **cRMScriptUniqueId** The unique id of the CRMScript to validate
 - **parameters** Parameters passed as variables to the CRMScript

**Returns:** String

```crmscript
NSCRMScriptAgent agent;
String cRMScriptUniqueId;
StringDictionary parameters;
String res = agent.ExecuteScriptByUniqueId(cRMScriptUniqueId, parameters);
```

