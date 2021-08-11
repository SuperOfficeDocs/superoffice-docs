---
uid: crmscript_ref_NSUserDefinedFieldInfoAgent_GetChangedPageOneFields
title: Bool[] GetChangedPageOneFields(Integer ownerType, Integer userGroupId)
intellisense: NSUserDefinedFieldInfoAgent.GetChangedPageOneFields
keywords: NSUserDefinedFieldInfoAgent, GetChangedPageOneFields
so.topic: reference
---

# Bool[] GetChangedPageOneFields(Integer ownerType, Integer userGroupId)

Gets which page one fields have changed from the current version

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
 - **userGroupId** ID of UserGroup

**Returns:** Bool[]
