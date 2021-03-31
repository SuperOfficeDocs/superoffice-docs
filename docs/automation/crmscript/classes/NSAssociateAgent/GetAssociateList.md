---
title: crmscript_ref_NSAssociateAgent_GetAssociateList
description: NSAssociate[] GetAssociateList(Integer[]  associateIds);
intellisense: NSAssociateAgent.GetAssociateList
keywords: NSAssociateAgent,GetAssociateList
so.topic: reference
---

Gets a vector of Associate objects.

**Parameters:**
 - **associateIds** The identifiers of the NSAssociate objects

**Returns:** Vector of NSAssociate objects

```crmscript
Integer[] ids;
NSAssociateAgent agent;
agent.GetAssociateList(ids);
```

