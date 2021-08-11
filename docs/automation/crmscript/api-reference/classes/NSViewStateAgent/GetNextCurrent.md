---
uid: crmscript_ref_NSViewStateAgent_GetNextCurrent
title: NSHistory GetNextCurrent(String historyName, Integer id)
intellisense: NSViewStateAgent.GetNextCurrent
keywords: NSViewStateAgent, GetNextCurrent
so.topic: reference
---

# NSHistory GetNextCurrent(String historyName, Integer id)

Returns the next current item. If no item exists a default value is returned. This is usually the first item in the table representing the history list.

**Parameters:**
 - **historyName** Name of the history list, e.g. contact, project
 - **id** Id of the history element, e.g. Contact id

**Returns:** NSHistory

```crmscript
NSViewStateAgent agent;
String historyName;
Integer id;
NSHistory res = agent.GetNextCurrent(historyName, id);
```

