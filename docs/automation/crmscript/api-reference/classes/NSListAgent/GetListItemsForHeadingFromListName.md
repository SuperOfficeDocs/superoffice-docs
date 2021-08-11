---
uid: crmscript_ref_NSListAgent_GetListItemsForHeadingFromListName
title: NSSelectableMDOListItem[] GetListItemsForHeadingFromListName(String udListDefinitionName, Integer headingId)
intellisense: NSListAgent.GetListItemsForHeadingFromListName
keywords: NSListAgent, GetListItemsForHeadingFromListName
so.topic: reference
---

# NSSelectableMDOListItem[] GetListItemsForHeadingFromListName(String udListDefinitionName, Integer headingId)

List of list items that is selected if under this heading

**Parameters:**
 - **udListDefinitionName** The name of the list definition.
 - **headingId** The id of the heading

**Returns:** NSSelectableMDOListItem[]

```crmscript
NSListAgent agent;
String udListDefinitionName;
Integer headingId;
NSSelectableMDOListItem[] res = agent.GetListItemsForHeadingFromListName(udListDefinitionName, headingId);
```

