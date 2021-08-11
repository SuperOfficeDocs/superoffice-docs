---
uid: crmscript_ref_NSViewStateAgent_GetHistoriesByName
title: NSHistory[] GetHistoriesByName(String historyName)
intellisense: NSViewStateAgent.GetHistoriesByName
keywords: NSViewStateAgent, GetHistoriesByName
so.topic: reference
---

# NSHistory[] GetHistoriesByName(String historyName)

Returns the named history list that belong to the currently logged in user

**Parameters:**
 - **historyName** Name of the history list

**Returns:** NSHistory[]

```crmscript
NSViewStateAgent agent;
String historyName;
NSHistory[] res = agent.GetHistoriesByName(historyName);
```

