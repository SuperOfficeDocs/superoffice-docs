---
uid: crmscript_ref_NSSelectionEntity_GetTargetTableName
title: String GetTargetTableName()
intellisense: NSSelectionEntity.GetTargetTableName
keywords: NSSelectionEntity, GetTargetTableName
so.topic: reference
---

# String GetTargetTableName()

TargetTableName contains the name of the table in lowercase. defines the type of selection members this selection contains. e.g. 'contact', or 'project' or 'sale'

**Returns:** String

```crmscript
NSSelectionEntity thing;
String targetTableName  = thing.GetTargetTableName();
```

