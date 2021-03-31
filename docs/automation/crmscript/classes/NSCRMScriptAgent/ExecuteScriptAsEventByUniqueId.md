---
title: crmscript_ref_NSCRMScriptAgent_ExecuteScriptAsEventByUniqueId
description: EventData ExecuteScriptAsEventByUniqueId(String cRMScriptUniqueId, EventData eventData)
intellisense: NSCRMScriptAgent.ExecuteScriptAsEventByUniqueId
keywords: NSCRMScriptAgent,ExecuteScriptAsEventByUniqueId
so.topic: reference
---

Execute a CRMScript with event data as input. Returns event data with output variable values.

**Parameters:**
 - **cRMScriptUniqueId** The unique id of the CRMScript to execute
 - **eventData** The EventData instance sent to the crmscript with input values

**Returns:** The EventData instance after script execution with output values

```crmscript
NSCRMScriptAgent agent;
String cRMScriptUniqueId;
EventData eventData;
EventData res = agent.ExecuteScriptAsEventByUniqueId(cRMScriptUniqueId, eventData);
```

