---
uid: crmscript_ref_NSListAgent_SetListItemsForUserGroup
title: Void SetListItemsForUserGroup(Integer udListDefinitionId, Integer usergroupId, Integer[] listItemIds, Bool enable)
intellisense: NSListAgent.SetListItemsForUserGroup
keywords: NSListAgent, SetListItemsForUserGroup
so.topic: reference
---

# Void SetListItemsForUserGroup(Integer udListDefinitionId, Integer usergroupId, Integer[] listItemIds, Bool enable)

Update listItems that will be visible for this usergroup

**Parameters:**
 - **udListDefinitionId** The id of the list. Negative numbers indicate TableNumber value instead of UDListDefId. e.g. -64 = category.
 - **usergroupId** The id of the userGroup
 - **listItemIds** The id of the list items.
 - **enable** True to enable, false to disable
