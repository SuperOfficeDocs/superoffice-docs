---
uid: crmscript_ref_NSViewStateAgent_GetHistoriesByNames
title: NSHistory[] GetHistoriesByNames(String[] historyNames)
intellisense: NSViewStateAgent.GetHistoriesByNames
keywords: NSViewStateAgent, GetHistoriesByNames
so.topic: reference
---

Returns the named history lists that belong to the currently logged in user

**Parameters:**
 - **historyNames** String array of list names

**Returns:** NSHistory[]

```crmscript
NSViewStateAgent agent;
String[] historyNames;
NSHistory[] res = agent.GetHistoriesByNames(historyNames);
```

