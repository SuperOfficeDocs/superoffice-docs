---
uid: crmscript_ref_NSListAgent_SaveHeadingsForListItemFromListName
title: NSSelectableMDOListItem[] SaveHeadingsForListItemFromListName(String udListDefinitionName, Integer listItemId, NSSelectableMDOListItem[] headings)
intellisense: NSListAgent.SaveHeadingsForListItemFromListName
keywords: NSListAgent, SaveHeadingsForListItemFromListName
so.topic: reference
---

# NSSelectableMDOListItem[] SaveHeadingsForListItemFromListName(String udListDefinitionName, Integer listItemId, NSSelectableMDOListItem[] headings)

Saves the headings for the list item.

**Parameters:**
 - **udListDefinitionName** The name of the list definition, indicating which list to update.
 - **listItemId** The identity of the list item
 - **headings** The headings to save.

**Returns:** NSSelectableMDOListItem[] 

```crmscript
NSListAgent agent;
String udListDefinitionName;
Integer listItemId;
NSSelectableMDOListItem[] headings;
NSSelectableMDOListItem[] res = agent.SaveHeadingsForListItemFromListName(udListDefinitionName, listItemId, headings);
```

