---
uid: crmscript_ref_NSViewStateAgent_GetHistoriesByNames
title: History[] GetHistoriesByNames(String[] historyNames)
intellisense: NSViewStateAgent.GetHistoriesByNames
keywords: NSViewStateAgent, GetHistoriesByNames
so.topic: reference
---

Returns the named history lists that belong to the currently logged in user

**Parameters:**
 - **historyNames** String array of list names

**Returns:** Array of History items

```crmscript
NSViewStateAgent agent;
String[] historyNames;
History[] res = agent.GetHistoriesByNames(historyNames);
```

