---
uid: crmscript_ref_NSViewStateAgent_GetHistoriesByName
title: HistoryArray GetHistoriesByName(String historyName)
intellisense: NSViewStateAgent.GetHistoriesByName
keywords: NSViewStateAgent, GetHistoriesByName
so.topic: reference
---

Returns the named history list that belong to the currently logged in user

**Parameters:**
 - **historyName** Name of the history list

**Returns:** Array of History items

```crmscript
NSViewStateAgent agent;
String historyName;
HistoryArray res = agent.GetHistoriesByName(historyName);
```

