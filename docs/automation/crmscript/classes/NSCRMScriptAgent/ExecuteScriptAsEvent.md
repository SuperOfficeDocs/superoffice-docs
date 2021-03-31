---
title: crmscript_ref_NSCRMScriptAgent_ExecuteScriptAsEvent
description: EventData ExecuteScriptAsEvent(Integer cRMScriptId, EventData eventData)
intellisense: NSCRMScriptAgent.ExecuteScriptAsEvent
keywords: NSCRMScriptAgent,ExecuteScriptAsEvent
so.topic: reference
---

Execute a CRMScript with event data as input. Returns event data with output variable values.

**Parameters:**
 - **cRMScriptId** The id of the CRMScript to execute
 - **eventData** The EventData instance sent to the crmscript with input values

**Returns:** The EventData instance after script execution with output values

```crmscript
NSCRMScriptAgent agent;
Integer cRMScriptId;
EventData eventData;
EventData res = agent.ExecuteScriptAsEvent(cRMScriptId, eventData);
```

