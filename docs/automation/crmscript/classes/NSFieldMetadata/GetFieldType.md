---
uid: crmscript_ref_NSFieldMetadata_GetFieldType
title: Integer GetFieldType()
intellisense: NSFieldMetadata.GetFieldType
keywords: NSFieldMetadata, GetFieldType
so.topic: reference
---

String, int, decimal, etc.

**Returns:** Integer

     - Enum: 0 = Checkbox 
     - Enum: 1 = Text 
     - Enum: 2 = Password 
     - Enum: 3 = Integer 
     - Enum: 4 = Double 
     - Enum: 5 = List 
     - Enum: 6 = Date 
     - Enum: 99 = Label 

```crmscript
NSFieldMetadata thing;
Integer fieldType  = thing.GetFieldType();
```


