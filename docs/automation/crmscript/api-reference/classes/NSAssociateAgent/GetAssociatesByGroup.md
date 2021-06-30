---
uid: crmscript_ref_NSAssociateAgent_GetAssociatesByGroup
title: Associate[] GetAssociatesByGroup(Integer groupId, Integer type)
intellisense: NSAssociateAgent.GetAssociatesByGroup
keywords: NSAssociateAgent, GetAssociatesByGroup
so.topic: reference
---

Method that returns a array of associate , based on DiaryGroupType and groupId. The differernt types are, Userdefined, Usergroup and ResourceHeadings

**Parameters:**
 - **groupId** Id of the group
 - **type** The type of group. See DiaryGroupType

**Returns:** Array of associate

```crmscript
NSAssociateAgent agent;
Integer groupId;
Integer type;
Associate[] res = agent.GetAssociatesByGroup(groupId, type);
```

