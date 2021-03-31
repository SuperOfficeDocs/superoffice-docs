---
title: crmscript_ref_NSUserDefinedFieldInfoAgent_SetUserDefinedPageOneField
description: Void SetUserDefinedPageOneField(Integer ownerType, Integer udefFieldId, Integer userGroupId, Integer fieldLineNo)
intellisense: NSUserDefinedFieldInfoAgent.SetUserDefinedPageOneField
keywords: NSUserDefinedFieldInfoAgent,SetUserDefinedPageOneField
so.topic: reference
---

Sets a user defined fields as page one field.

**Parameters:**
 - **ownerType** The user-defined field owner entity
     - Enum: 0 = Invalid 
     - Enum: 7 = Contact 
     - Enum: 8 = Person 
     - Enum: 9 = Project 
     - Enum: 10 = Sale 
     - Enum: 11 = Temp 
     - Enum: 12 = Appointment 
     - Enum: 13 = Document 
     - Enum: 14 = None 
 - **udefFieldId** The id of the udeffield to set as page one field
 - **userGroupId** The usergroup id to associate the page one field with.
 - **fieldLineNo** Page one line number
