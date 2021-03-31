---
title: crmscript_ref_NSSentryAgent_GetTableRightByContactOwnership
description: TableRight GetTableRightByContactOwnership(String tableName, Integer contactId)
intellisense: NSSentryAgent.GetTableRightByContactOwnership
keywords: NSSentryAgent,GetTableRightByContactOwnership
so.topic: reference
---

Return the TableRight from the relationship between the current user and the given user and group.

**Parameters:**
 - **tableName** Name of the table to get the TableRights from.
 - **contactId** The owner contact.

**Returns:** The TableRight

```crmscript
NSSentryAgent agent;
String tableName;
Integer contactId;
TableRight res = agent.GetTableRightByContactOwnership(tableName, contactId);
```

