---
uid: crmscript_ref_NSMDOAgent_GetListItem
title: NSMDOListItem GetListItem(String listName, Integer id)
intellisense: NSMDOAgent.GetListItem
keywords: NSMDOAgent, GetListItem
so.topic: reference
---

Returns a single list item

**Parameters:**
 - **listName** Conceptual name of the MDO list
 - **id** Id of list item

**Returns:** NSMDOListItem

```crmscript
NSMDOAgent agent;
String listName;
Integer id;
NSMDOListItem res = agent.GetListItem(listName, id);
```

