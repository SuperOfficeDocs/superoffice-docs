---
title: crmscript_ref_NSListAgent_SetVisibleForUserGroup
description: Void SetVisibleForUserGroup(Integer udListDefinitionId, Integer listItemId, IntegerArray userGroupId, Bool enable)
intellisense: NSListAgent.SetVisibleForUserGroup
keywords: NSListAgent,SetVisibleForUserGroup
so.topic: reference
---

Set a group which this list item should be visible for

**Parameters:**
 - **udListDefinitionId** The id of the list. Negative numbers indicate TableNumber value instead of UDListDefId. e.g. -64 = category.
 - **listItemId** The id of the list item
 - **userGroupId** The id of the user groups to set for this list item
 - **enable** Set to true to enable, false to disable
