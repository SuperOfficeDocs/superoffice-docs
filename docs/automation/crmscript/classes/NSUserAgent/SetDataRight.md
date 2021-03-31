---
title: crmscript_ref_NSUserAgent_SetDataRight
description: Void SetDataRight(Integer roleId, String tableName, Integer relationToOwner, String dataRightValue)
intellisense: NSUserAgent.SetDataRight
keywords: NSUserAgent,SetDataRight
so.topic: reference
---

Set one specific data right at the given position. An exception will be thrown if non existing position is specified.

**Parameters:**
 - **roleId** The role id to set the data right for
 - **tableName** The name of the entity/table
 - **relationToOwner** The id of the relation to owner
     - Enum: 0 = MyOwn 
     - Enum: 1 = PrimaryGroup 
     - Enum: 2 = OtherGroups 
     - Enum: 3 = OtherAssociates 
     - Enum: 4 = ExternalUser 
     - Enum: 5 = Anonymous 
     - Enum: 6 = MyCompany 
     - Enum: 7 = SameProject 
 - **dataRightValue** The data right value to set at the specified position (CRUD)
