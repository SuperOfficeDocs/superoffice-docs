---
uid: crmscript_ref_NSListAgent_GetHeadings
title: NSSelectableMDOListItem[] GetHeadings(Integer udListDefinitionId, Integer listItemId, Bool showDeleted)
intellisense: NSListAgent.GetHeadings
keywords: NSListAgent, GetHeadings
so.topic: reference
---

# NSSelectableMDOListItem[] GetHeadings(Integer udListDefinitionId, Integer listItemId, Bool showDeleted)

Gets a selectable MDO list of the headings for this list item

**Parameters:**
 - **udListDefinitionId** The id of the list. Negative numbers indicate TableNumber value instead of UDListDefId. e.g. -64 = category.
 - **listItemId** The id of the list item
 - **showDeleted** Set to true if you want deleted headings

**Returns:** NSSelectableMDOListItem[]

```crmscript
NSListAgent agent;
Integer udListDefinitionId;
Integer listItemId;
Bool showDeleted;
NSSelectableMDOListItem[] res = agent.GetHeadings(udListDefinitionId, listItemId, showDeleted);
```

