---
uid: crmscript_ref_NSViewStateAgent_GetNextCurrent
title: History GetNextCurrent(String historyName, Integer id)
intellisense: NSViewStateAgent.GetNextCurrent
keywords: NSViewStateAgent, GetNextCurrent
so.topic: reference
---

Returns the next current item. If no item exists a default value is returned. This is usually the first item in the table representing the history list.

**Parameters:**
 - **historyName** Name of the history list, e.g. contact, project
 - **id** Id of the history element, e.g. Contact id

**Returns:** The current value.

```crmscript
NSViewStateAgent agent;
String historyName;
Integer id;
History res = agent.GetNextCurrent(historyName, id);
```

