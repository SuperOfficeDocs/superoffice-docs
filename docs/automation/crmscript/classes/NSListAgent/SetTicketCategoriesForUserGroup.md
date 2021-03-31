---
uid: crmscript_ref_NSListAgent_SetTicketCategoriesForUserGroup
title: Void SetTicketCategoriesForUserGroup(Integer userGroupId, IntegerArray categoryIds)
intellisense: NSListAgent.SetTicketCategoriesForUserGroup
keywords: NSListAgent, SetTicketCategoriesForUserGroup
so.topic: reference
---

Set ticket categories for one user group

**Parameters:**
 - **userGroupId** The ids of the user groups we want tickets categories from
 - **categoryIds** The ids of the user groups we want tickets categories from

**Returns:** This method has no return value

```crmscript
NSListAgent agent;
Integer userGroupId;
IntegerArray categoryIds;
Void res = agent.SetTicketCategoriesForUserGroup(userGroupId, categoryIds);
```

