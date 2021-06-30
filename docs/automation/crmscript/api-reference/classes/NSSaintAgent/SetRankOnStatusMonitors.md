---
uid: crmscript_ref_NSSaintAgent_SetRankOnStatusMonitors
title: Void SetRankOnStatusMonitors(String type, Integer[] itemsIds)
intellisense: NSSaintAgent.SetRankOnStatusMonitors
keywords: NSSaintAgent, SetRankOnStatusMonitors
so.topic: reference
---

Set rank order on status monitors

**Parameters:**
 - **type** Type of status monitors to reorder ("contact", "project", etc.)
 - **itemsIds** The ids of the items in the order you want

**Returns:** This method has no return value

```crmscript
NSSaintAgent agent;
String type;
Integer[] itemsIds;
Void res = agent.SetRankOnStatusMonitors(type, itemsIds);
```

