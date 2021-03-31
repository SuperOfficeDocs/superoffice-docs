---
uid: crmscript_ref_NSListAgent_SetListItemsForHeading
title: Void SetListItemsForHeading(Integer udListDefinitionId, Integer headingId, IntegerArray listItemIds, Bool enable)
intellisense: NSListAgent.SetListItemsForHeading
keywords: NSListAgent, SetListItemsForHeading
so.topic: reference
---

Update listItems that will be visible for this usergroup

**Parameters:**
 - **udListDefinitionId** The id of the list. Negative numbers indicate TableNumber value instead of UDListDefId. e.g. -64 = category.
 - **headingId** The id of the heading
 - **listItemIds** The ids of the list items.
 - **enable** True to enable, false to disable
