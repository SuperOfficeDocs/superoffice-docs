---
uid: crmscript_ref_NSRelationDefinitionEntity_SetDestination
title: SetDestination(Integer destination)
intellisense: NSRelationDefinitionEntity.SetDestination
keywords: NSRelationDefinitionEntity, GetDestination
so.topic: reference
---

# SetDestination(Integer destination)

The destination of the relation

**Parameter:** 
 - **destination** Integer
     - Enum: 0 = None 
     - Enum: 1 = Contact 
     - Enum: 2 = Person 
     - Enum: 3 = Both 

```crmscript
NSRelationDefinitionEntity thing;
Integer destination;
thing.SetDestination(destination);
```

