---
uid: crmscript_ref_NSRelationDefinitionEntity_SetSource
title: SetSource(Integer source)
intellisense: NSRelationDefinitionEntity.SetSource
keywords: NSRelationDefinitionEntity, GetSource
so.topic: reference
---

The source of the relation

**Parameter:** 
 - **source** Integer
     - Enum: 0 = None 
     - Enum: 1 = Contact 
     - Enum: 2 = Person 
     - Enum: 3 = Both 

```crmscript
NSRelationDefinitionEntity thing;
Integer source;
thing.SetSource(source);
```

