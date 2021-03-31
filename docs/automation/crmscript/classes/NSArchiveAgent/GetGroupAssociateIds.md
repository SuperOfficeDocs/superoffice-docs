---
title: crmscript_ref_NSArchiveAgent_GetGroupAssociateIds
description: IntegerArray GetGroupAssociateIds(IntegerArray groupIds)
intellisense: NSArchiveAgent.GetGroupAssociateIds
keywords: NSArchiveAgent,GetGroupAssociateIds
so.topic: reference
---

Returns the  associate ids that belongs to the given groups

**Parameters:**
 - **groupIds** Array of group ids

**Returns:** Array of associate ids

```crmscript
NSArchiveAgent agent;
IntegerArray groupIds;
IntegerArray res = agent.GetGroupAssociateIds(groupIds);
```

