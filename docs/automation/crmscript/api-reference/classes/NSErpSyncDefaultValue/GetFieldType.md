---
uid: crmscript_ref_NSErpSyncDefaultValue_GetFieldType
title: NSFieldMetadataType GetFieldType()
intellisense: NSErpSyncDefaultValue.GetFieldType
keywords: NSErpSyncDefaultValue, GetFieldType
so.topic: reference
---

# NSFieldMetadataType GetFieldType()

Field type

**Returns:** NSFieldMetadataType

     - Enum: 0 = Checkbox 
     - Enum: 1 = Text 
     - Enum: 2 = Password 
     - Enum: 3 = Integer 
     - Enum: 4 = Double 
     - Enum: 5 = List 
     - Enum: 6 = Date 
     - Enum: 99 = Label 

```crmscript
NSErpSyncDefaultValue thing;
NSFieldMetadataType fieldType  = thing.GetFieldType();
```

