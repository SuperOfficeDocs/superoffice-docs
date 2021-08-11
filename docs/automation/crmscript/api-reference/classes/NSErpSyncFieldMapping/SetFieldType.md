---
uid: crmscript_ref_NSErpSyncFieldMapping_SetFieldType
title: SetFieldType(NSFieldMetadataType fieldType)
intellisense: NSErpSyncFieldMapping.SetFieldType
keywords: NSErpSyncFieldMapping, GetFieldType
so.topic: reference
---

# SetFieldType(NSFieldMetadataType fieldType)

Field type

**Parameter:** 
 - **fieldType** NSFieldMetadataType
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
NSFieldMetadataType fieldType;
thing.SetFieldType(fieldType);
```

