---
uid: crmscript_ref_NSUserDefinedFieldInfoAgent_GetPublishedUserDefinedPageOneFields
title: NSUserDefinedFieldInfo[] GetPublishedUserDefinedPageOneFields(Integer ownerType, Integer userGroupId)
intellisense: NSUserDefinedFieldInfoAgent.GetPublishedUserDefinedPageOneFields
keywords: NSUserDefinedFieldInfoAgent, GetPublishedUserDefinedPageOneFields
so.topic: reference
---

# NSUserDefinedFieldInfo[] GetPublishedUserDefinedPageOneFields(Integer ownerType, Integer userGroupId)

Get a list of page one fields for given Udef type and current user group

**Parameters:**
 - **ownerType** The user-defined field owner-entity.
     - Enum: 0 = Invalid 
     - Enum: 7 = Contact 
     - Enum: 8 = Person 
     - Enum: 9 = Project 
     - Enum: 10 = Sale 
     - Enum: 11 = Temp 
     - Enum: 12 = Appointment 
     - Enum: 13 = Document 
     - Enum: 14 = None 
 - **userGroupId** Id of UserGroup

**Returns:** NSUserDefinedFieldInfo[]

```crmscript
NSUserDefinedFieldInfoAgent agent;
Integer ownerType;
Integer userGroupId;
NSUserDefinedFieldInfo[] res = agent.GetPublishedUserDefinedPageOneFields(ownerType, userGroupId);
```

