---
uid: crmscript_ref_NSCRMScriptAgent_ExecuteScriptAsEvent
title: NSEventData ExecuteScriptAsEvent(Integer cRMScriptId, NSEventData eventData)
intellisense: NSCRMScriptAgent.ExecuteScriptAsEvent
keywords: NSCRMScriptAgent, ExecuteScriptAsEvent
so.topic: reference
---

Execute a CRMScript with event data as input. Returns event data with output variable values.

**Parameters:**
 - **cRMScriptId** The id of the CRMScript to execute
 - **eventData** The NSEventData instance sent to the crmscript with input values

**Returns:** NSEventData

```crmscript
NSCRMScriptAgent agent;
Integer cRMScriptId;
NSEventData eventData;
NSEventData res = agent.ExecuteScriptAsEvent(cRMScriptId, eventData);
```

