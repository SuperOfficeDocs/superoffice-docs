---
title: crmscript_ref_NSListAgent_GetHeadings
description: SelectableMDOListItemArray GetHeadings(Integer udListDefinitionId, Integer listItemId, Bool showDeleted)
intellisense: NSListAgent.GetHeadings
keywords: NSListAgent,GetHeadings
so.topic: reference
---

Gets a selectable MDO list of the headings for this list item

**Parameters:**
 - **udListDefinitionId** The id of the list. Negative numbers indicate TableNumber value instead of UDListDefId. e.g. -64 = category.
 - **listItemId** The id of the list item
 - **showDeleted** Set to true if you want deleted headings

**Returns:** Array of headings

```crmscript
NSListAgent agent;
Integer udListDefinitionId;
Integer listItemId;
Bool showDeleted;
SelectableMDOListItemArray res = agent.GetHeadings(udListDefinitionId, listItemId, showDeleted);
```

