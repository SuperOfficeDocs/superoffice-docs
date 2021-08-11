---
uid: crmscript_ref_NSRelationDefinitionEntity_GetSource
title: Integer GetSource()
intellisense: NSRelationDefinitionEntity.GetSource
keywords: NSRelationDefinitionEntity, GetSource
so.topic: reference
---

# Integer GetSource()

The source of the relation

**Returns:** Integer

     - Enum: 0 = None 
     - Enum: 1 = Contact 
     - Enum: 2 = Person 
     - Enum: 3 = Both 

```crmscript
NSRelationDefinitionEntity thing;
Integer source  = thing.GetSource();
```

