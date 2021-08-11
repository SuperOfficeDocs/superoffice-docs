---
uid: crmscript_ref_NSErpSyncFieldMapping_GetFieldType
title: NSFieldMetadataType GetFieldType()
intellisense: NSErpSyncFieldMapping.GetFieldType
keywords: NSErpSyncFieldMapping, GetFieldType
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
NSErpSyncFieldMapping thing;
NSFieldMetadataType fieldType  = thing.GetFieldType();
```

