---
uid: crmscript_ref_NSViewStateAgent_GetCurrent
title: NSHistory GetCurrent(String historyName)
intellisense: NSViewStateAgent.GetCurrent
keywords: NSViewStateAgent, GetCurrent
so.topic: reference
---

Get the current (most recent) value of the history list. This is the item with rank = 1. If no item exists a default value is returned. This is usually the first item in the table representing the history list.

**Parameters:**
 - **historyName** Name of the history list, e.g. contact, project

**Returns:** NSHistory

```crmscript
NSViewStateAgent agent;
String historyName;
NSHistory res = agent.GetCurrent(historyName);
```

