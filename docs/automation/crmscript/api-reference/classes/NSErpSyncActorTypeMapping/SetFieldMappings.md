---
uid: crmscript_ref_NSErpSyncActorTypeMapping_SetFieldMappings
title: SetFieldMappings(ErpSyncFieldMapping[9] fieldMappings)
intellisense: NSErpSyncActorTypeMapping.SetFieldMappings
keywords: NSErpSyncActorTypeMapping, GetFieldMappings
so.topic: reference
---

Array of individual field mappings; explicitly map to empty CrmFieldKey to indicate non-sync

**Parameter:** 
 - **fieldMappings** ErpSyncFieldMappingArray

```crmscript
NSErpSyncActorTypeMapping thing;
ErpSyncFieldMapping[] fieldMappings;
thing.SetFieldMappings(fieldMappings);
```

