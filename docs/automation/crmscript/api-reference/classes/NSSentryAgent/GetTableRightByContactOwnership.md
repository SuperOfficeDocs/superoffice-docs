---
uid: crmscript_ref_NSSentryAgent_GetTableRightByContactOwnership
title: NSTableRight GetTableRightByContactOwnership(String tableName, Integer contactId)
intellisense: NSSentryAgent.GetTableRightByContactOwnership
keywords: NSSentryAgent, GetTableRightByContactOwnership
so.topic: reference
---

Return the NSTableRight from the relationship between the current user and the given user and group.

**Parameters:**
 - **tableName** Name of the table to get the TableRights from.
 - **contactId** The owner contact.

**Returns:** NSTableRight

```crmscript
NSSentryAgent agent;
String tableName;
Integer contactId;
NSTableRight res = agent.GetTableRightByContactOwnership(tableName, contactId);
```

