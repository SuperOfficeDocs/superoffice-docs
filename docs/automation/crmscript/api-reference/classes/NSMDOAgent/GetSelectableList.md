---
uid: crmscript_ref_NSMDOAgent_GetSelectableList
title: NSSelectableMDOListItem[] GetSelectableList(String name, Bool forceFlatList, String additionalInfo, Bool onlyHistory)
intellisense: NSMDOAgent.GetSelectableList
keywords: NSMDOAgent, GetSelectableList
so.topic: reference
---

Method to get a Selectable MDO list.

**Parameters:**
 - **name** Conceptual name of the MDO list.
 - **forceFlatList** Force the list to be flat
 - **additionalInfo** Additional info to the MDO provider
 - **onlyHistory** If true, return only history items

**Returns:** NSSelectableMDOListItem[]

```crmscript
NSMDOAgent agent;
String name;
Bool forceFlatList;
String additionalInfo;
Bool onlyHistory;
NSSelectableMDOListItem[] res = agent.GetSelectableList(name, forceFlatList, additionalInfo, onlyHistory);
```

