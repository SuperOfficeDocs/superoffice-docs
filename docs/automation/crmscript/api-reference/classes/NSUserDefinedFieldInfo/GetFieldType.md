---
uid: crmscript_ref_NSUserDefinedFieldInfo_GetFieldType
title: Integer GetFieldType()
intellisense: NSUserDefinedFieldInfo.GetFieldType
keywords: NSUserDefinedFieldInfo, GetFieldType
so.topic: reference
---

# Integer GetFieldType()

Field type: 0 = leadtext only, 1 = Edit, 2 = CheckBox, 3 = dropdown, 4 = listbox

**Returns:** Integer

     - Enum: 1 = Number 
     - Enum: 2 = ShortText 
     - Enum: 3 = LongText 
     - Enum: 4 = Date 
     - Enum: 5 = UnlimitedDate 
     - Enum: 6 = Checkbox 
     - Enum: 7 = List 
     - Enum: 8 = Decimal 

```crmscript
NSUserDefinedFieldInfo thing;
Integer fieldType  = thing.GetFieldType();
```

