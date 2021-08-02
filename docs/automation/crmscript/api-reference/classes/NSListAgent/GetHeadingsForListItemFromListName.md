---
uid: crmscript_ref_NSListAgent_GetHeadingsForListItemFromListName
title: NSSelectableMDOListItem[] GetHeadingsForListItemFromListName(String udListDefinitionName, Integer listItemId, Bool showDeleted)
intellisense: NSListAgent.GetHeadingsForListItemFromListName
keywords: NSListAgent, GetHeadingsForListItemFromListName
so.topic: reference
---

Gets a selectable MDO list of the headings for this list item

**Parameters:**
 - **udListDefinitionName** The name of the list definition, indicating which list to delete the items from.
 - **listItemId** The id of the list item
 - **showDeleted** Set to true if you want deleted headings

**Returns:** NSSelectableMDOListItem[]

```crmscript
NSListAgent agent;
String udListDefinitionName;
Integer listItemId;
Bool showDeleted;
NSSelectableMDOListItem[] res = agent.GetHeadingsForListItemFromListName(udListDefinitionName, listItemId, showDeleted);
```

