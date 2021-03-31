---
title: crmscript_ref_NSListAgent_MoveListItem
description: Void MoveListItem(Integer udListDefinitionId, Integer listItemId, Integer direction)
intellisense: NSListAgent.MoveListItem
keywords: NSListAgent,MoveListItem
so.topic: reference
---

Move a list item up or down in the list based on rank

**Parameters:**
 - **udListDefinitionId** Id of the list. Negative numbers indicate TableNumber value instead of UDListDefId. e.g. -64 = category.
 - **listItemId** Id of the list item
 - **direction** -1 moves the item up one position, 1 moves the item down one position
