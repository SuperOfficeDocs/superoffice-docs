---
uid: crmscript_ref_NSListAgent_GetListItemsForHeading
title: SelectableMDOListItem[] GetListItemsForHeading(Integer udListDefinitionId, Integer headingId)
intellisense: NSListAgent.GetListItemsForHeading
keywords: NSListAgent, GetListItemsForHeading
so.topic: reference
---

List of list items that is selected if under this heading

**Parameters:**
 - **udListDefinitionId** The id of the list. Negative numbers indicate TableNumber value instead of UDListDefId. e.g. -64 = category.
 - **headingId** The id of the heading

**Returns:** Array of selectable list items

```crmscript
NSListAgent agent;
Integer udListDefinitionId;
Integer headingId;
SelectableMDOListItem[] res = agent.GetListItemsForHeading(udListDefinitionId, headingId);
```

