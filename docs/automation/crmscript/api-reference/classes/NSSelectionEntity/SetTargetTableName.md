---
uid: crmscript_ref_NSSelectionEntity_SetTargetTableName
title: SetTargetTableName(String targetTableName)
intellisense: NSSelectionEntity.SetTargetTableName
keywords: NSSelectionEntity, GetTargetTableName
so.topic: reference
---

TargetTableName contains the name of the table in lowercase. defines the type of selection members this selection contains. e.g. 'contact', or 'project' or 'sale'

**Parameter:** 
 - **targetTableName** String

```crmscript
NSSelectionEntity thing;
String targetTableName;
thing.SetTargetTableName(targetTableName);
```

