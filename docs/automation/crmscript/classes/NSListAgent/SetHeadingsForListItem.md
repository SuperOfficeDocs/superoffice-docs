---
title: crmscript_ref_NSListAgent_SetHeadingsForListItem
description: Void SetHeadingsForListItem(Integer udListDefinitionId, Integer listItemId, IntegerArray headingIds, Bool enable)
intellisense: NSListAgent.SetHeadingsForListItem
keywords: NSListAgent,SetHeadingsForListItem
so.topic: reference
---

Set headings which this list item should be listed under

**Parameters:**
 - **udListDefinitionId** The id of the list. Negative numbers indicate TableNumber value instead of UDListDefId. e.g. -64 = category.
 - **listItemId** The id of the list item
 - **headingIds** The ids of the headings to set for this list item
 - **enable** Set to true to enable, false to disable
