---
uid: crmscript_ref_NSListAgent_GetListItemsForHeading
title: NSSelectableMDOListItem[] GetListItemsForHeading(Integer udListDefinitionId, Integer headingId)
intellisense: NSListAgent.GetListItemsForHeading
keywords: NSListAgent, GetListItemsForHeading
so.topic: reference
---

List of list items that is selected if under this heading

**Parameters:**
 - **udListDefinitionId** The id of the list. Negative numbers indicate TableNumber value instead of UDListDefId. e.g. -64 = category.
 - **headingId** The id of the heading

**Returns:** NSSelectableMDOListItem[]

```crmscript
NSListAgent agent;
Integer udListDefinitionId;
Integer headingId;
NSSelectableMDOListItem[] res = agent.GetListItemsForHeading(udListDefinitionId, headingId);
```

