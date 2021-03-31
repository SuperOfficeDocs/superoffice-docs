---
title: crmscript_ref_NSMDOAgent_GetListItem
description: MDOListItem GetListItem(String listName, Integer id)
intellisense: NSMDOAgent.GetListItem
keywords: NSMDOAgent,GetListItem
so.topic: reference
---

Returns a single list item

**Parameters:**
 - **listName** Conceptual name of the MDO list
 - **id** Id of list item

**Returns:** Single MDO list item

```crmscript
NSMDOAgent agent;
String listName;
Integer id;
MDOListItem res = agent.GetListItem(listName, id);
```

