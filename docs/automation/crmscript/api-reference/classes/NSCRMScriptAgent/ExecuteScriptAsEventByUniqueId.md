---
uid: crmscript_ref_NSCRMScriptAgent_ExecuteScriptAsEventByUniqueId
title: NSEventData ExecuteScriptAsEventByUniqueId(String cRMScriptUniqueId, NSEventData eventData)
intellisense: NSCRMScriptAgent.ExecuteScriptAsEventByUniqueId
keywords: NSCRMScriptAgent, ExecuteScriptAsEventByUniqueId
so.topic: reference
---

Execute a CRMScript with event data as input. Returns event data with output variable values.

**Parameters:**
 - **cRMScriptUniqueId** The unique id of the CRMScript to execute
 - **eventData** The NSEventData instance sent to the crmscript with input values

**Returns:** NSEventData

```crmscript
NSCRMScriptAgent agent;
String cRMScriptUniqueId;
NSEventData eventData;
NSEventData res = agent.ExecuteScriptAsEventByUniqueId(cRMScriptUniqueId, eventData);
```

