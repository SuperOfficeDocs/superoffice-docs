---
uid: crmscript_ref_NSFieldInfoBase_GetFieldType
title: Integer GetFieldType()
intellisense: NSFieldInfoBase.GetFieldType
keywords: NSFieldInfoBase, GetFieldType
so.topic: reference
---

# Integer GetFieldType()

What sort of data does this field contain. 1 = int, 2 = short text, ...

**Returns:** Integer

     - Enum: 0 = Unknown 
     - Enum: 1 = Integer 
     - Enum: 2 = ShortText 
     - Enum: 3 = LongText 
     - Enum: 4 = Date 
     - Enum: 5 = Blob 
     - Enum: 6 = Checkbox 
     - Enum: 7 = MdoList 
     - Enum: 8 = Decimal 
     - Enum: 9 = DateTime 
     - Enum: 10 = Time 
     - Enum: 11 = TimeSpan 
     - Enum: 12 = RelationTo 
     - Enum: 13 = Attachment 
     - Enum: 14 = DynamicLink 
     - Enum: 15 = ListText 

```crmscript
NSFieldInfoBase thing;
Integer fieldType  = thing.GetFieldType();
```

