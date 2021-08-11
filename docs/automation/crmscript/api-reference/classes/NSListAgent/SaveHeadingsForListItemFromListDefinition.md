---
uid: crmscript_ref_NSListAgent_SaveHeadingsForListItemFromListDefinition
title: NSSelectableMDOListItem[] SaveHeadingsForListItemFromListDefinition(Integer udListDefinitionId, Integer listItemId, NSSelectableMDOListItem[] headings)
intellisense: NSListAgent.SaveHeadingsForListItemFromListDefinition
keywords: NSListAgent, SaveHeadingsForListItemFromListDefinition
so.topic: reference
---

# NSSelectableMDOListItem[] SaveHeadingsForListItemFromListDefinition(Integer udListDefinitionId, Integer listItemId, NSSelectableMDOListItem[] headings)

Saves the active headings for the list item.

**Parameters:**
 - **udListDefinitionId** The id of the list definition, indicating which list to delete the items from. Negative numbers indicate TableNumber value instead of UDListDefId. e.g. -64 = category.
 - **listItemId** The identity of the list item to delete
 - **headings** The headings to save.

**Returns:** NSSelectableMDOListItem[]

```crmscript
NSListAgent agent;
Integer udListDefinitionId;
Integer listItemId;
NSSelectableMDOListItem[] headings;
NSSelectableMDOListItem[] res = agent.SaveHeadingsForListItemFromListDefinition(udListDefinitionId, listItemId, headings);
```

