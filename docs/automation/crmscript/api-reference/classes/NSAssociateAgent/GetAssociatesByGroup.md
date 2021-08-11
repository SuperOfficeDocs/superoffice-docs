---
uid: crmscript_ref_NSAssociateAgent_GetAssociatesByGroup
title: NSAssociate[] GetAssociatesByGroup(Integer groupId, Integer type)
intellisense: NSAssociateAgent.GetAssociatesByGroup
keywords: NSAssociateAgent, GetAssociatesByGroup
so.topic: reference
---

# NSAssociate[] GetAssociatesByGroup(Integer groupId, Integer type)

Method that returns a array of associate , based on DiaryGroupType and groupId. The different types are, Userdefined, Usergroup and ResourceHeadings

**Parameters:**
 - **groupId** Id of the group
 - **type** The type of group. See DiaryGroupType

**Returns:** NSAssociate[]

```crmscript
NSAssociateAgent agent;
Integer groupId;
Integer type;
NSAssociate[] res = agent.GetAssociatesByGroup(groupId, type);
```

