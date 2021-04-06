---
uid: crmscript_ref_NSListAgent_GetListItemsForHeadingFromListName
title: SelectableMDOListItemArray GetListItemsForHeadingFromListName(String udListDefinitionName, Integer headingId)
intellisense: NSListAgent.GetListItemsForHeadingFromListName
keywords: NSListAgent, GetListItemsForHeadingFromListName
so.topic: reference
---

List of list items that is selected if under this heading

**Parameters:**
 - **udListDefinitionName** The name of the list definition.
 - **headingId** The id of the heading

**Returns:** Array of selectable list items

```crmscript
NSListAgent agent;
String udListDefinitionName;
Integer headingId;
SelectableMDOListItemArray res = agent.GetListItemsForHeadingFromListName(udListDefinitionName, headingId);
```

