---
uid: crmscript_ref_NSListAgent_SaveHeadingsForListItemFromListName
title: SelectableMDOListItem[] SaveHeadingsForListItemFromListName(String udListDefinitionName, Integer listItemId, SelectableMDOListItem[] headings)
intellisense: NSListAgent.SaveHeadingsForListItemFromListName
keywords: NSListAgent, SaveHeadingsForListItemFromListName
so.topic: reference
---

Saves the headings for the list item.

**Parameters:**
 - **udListDefinitionName** The name of the list definition, indicating which list to update.
 - **listItemId** The identity of the list item
 - **headings** The headings to save.

**Returns:** Array of selectable headings 

```crmscript
NSListAgent agent;
String udListDefinitionName;
Integer listItemId;
SelectableMDOListItem[] headings;
SelectableMDOListItem[] res = agent.SaveHeadingsForListItemFromListName(udListDefinitionName, listItemId, headings);
```

