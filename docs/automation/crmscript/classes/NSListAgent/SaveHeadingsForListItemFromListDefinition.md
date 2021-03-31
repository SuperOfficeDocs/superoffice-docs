---
title: crmscript_ref_NSListAgent_SaveHeadingsForListItemFromListDefinition
description: SelectableMDOListItemArray SaveHeadingsForListItemFromListDefinition(Integer udListDefinitionId, Integer listItemId, SelectableMDOListItemArray headings)
intellisense: NSListAgent.SaveHeadingsForListItemFromListDefinition
keywords: NSListAgent,SaveHeadingsForListItemFromListDefinition
so.topic: reference
---

Saves the active headings for the list item.

**Parameters:**
 - **udListDefinitionId** The id of the list definition, indicating which list to delete the items from. Negative numbers indicate TableNumber value instead of UDListDefId. e.g. -64 = category.
 - **listItemId** The identity of the list item to delete
 - **headings** The headings to save.

**Returns:** Array of headings

```crmscript
NSListAgent agent;
Integer udListDefinitionId;
Integer listItemId;
SelectableMDOListItemArray headings;
SelectableMDOListItemArray res = agent.SaveHeadingsForListItemFromListDefinition(udListDefinitionId, listItemId, headings);
```

