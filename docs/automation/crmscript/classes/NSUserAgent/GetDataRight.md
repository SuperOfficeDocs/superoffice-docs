---
title: crmscript_ref_NSUserAgent_GetDataRight
description: String GetDataRight(Integer roleId, String tableName, Integer relationToOwner)
intellisense: NSUserAgent.GetDataRight
keywords: NSUserAgent,GetDataRight
so.topic: reference
---

Read one specific data right at the given position. An exception will be thrown if non existing position is specified.

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

**Returns:** The data right value at the specified position (C, CR, CRU, or CRUD)

```crmscript
NSUserAgent agent;
Integer roleId;
String tableName;
Integer relationToOwner;
String res = agent.GetDataRight(roleId, tableName, relationToOwner);
```

