---
uid: crmscript_ref_NSViewStateAgent_GetPreviousCurrent
title: History GetPreviousCurrent(String historyName, Integer id)
intellisense: NSViewStateAgent.GetPreviousCurrent
keywords: NSViewStateAgent, GetPreviousCurrent
so.topic: reference
---

Returns the previous current item. If no item exists a default value is returned. This is usually the first item in the table representing the history list.

**Parameters:**
 - **historyName** Name of the history list, e.g. contact, project
 - **id** Id of the history element, e.g. Contact id

**Returns:** The current value.

```crmscript
NSViewStateAgent agent;
String historyName;
Integer id;
History res = agent.GetPreviousCurrent(historyName, id);
```

