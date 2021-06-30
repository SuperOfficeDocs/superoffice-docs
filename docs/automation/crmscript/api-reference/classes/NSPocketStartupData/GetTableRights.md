---
uid: crmscript_ref_NSPocketStartupData_GetTableRights
title: ETableRight[] GetTableRights()
intellisense: NSPocketStartupData.GetTableRights
keywords: NSPocketStartupData, GetTableRights
so.topic: reference
---

List of tablerights for logged in user, in the same order as the Tables array parameter

**Returns:** ETableRight[]

     - Enum: 0 = None 
     - Enum: 1 = Select 
     - Enum: 2 = Update 
     - Enum: 4 = Insert 
     - Enum: 8 = Delete 
     - Enum: 16 = Filtering 
     - Enum: 32 = RestrictedUpdate 
     - Enum: 64 = Unused1 
     - Enum: 128 = Uninitialized 
     - Enum: 15 = FULL 
     - Enum: 38 = WRITE 
     - Enum: 34 = URU 
     - Enum: 11 = UDR 
     - Enum: 3 = UR 
     - Enum: 7 = URI 
     - Enum: 1 = R 
     - Enum: 5 = RI 
     - Enum: 17 = RF 
     - Enum: 16 = F 
     - Enum: 20 = FI 

```crmscript
NSPocketStartupData thing;
ETableRight[] tableRights  = thing.GetTableRights();
```


