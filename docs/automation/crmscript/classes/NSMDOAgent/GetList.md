---
uid: crmscript_ref_NSMDOAgent_GetList
title: MDOListItemArray GetList(String name, Bool forceFlatList, String additionalInfo, Bool onlyHistory)
intellisense: NSMDOAgent.GetList
keywords: NSMDOAgent, GetList
so.topic: reference
---

Method to get a MDO list.

**Parameters:**
 - **name** Conceptual name of the MDO list-
 - **forceFlatList** Force the list to be flat
 - **additionalInfo** Additional info to the MDO provider
 - **onlyHistory** If true, return only history items

**Returns:** Array of MDOListItem

```crmscript
NSMDOAgent agent;
String name;
Bool forceFlatList;
String additionalInfo;
Bool onlyHistory;
MDOListItemArray res = agent.GetList(name, forceFlatList, additionalInfo, onlyHistory);
```

