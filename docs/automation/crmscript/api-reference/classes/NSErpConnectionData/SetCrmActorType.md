---
uid: crmscript_ref_NSErpConnectionData_SetCrmActorType
title: SetCrmActorType(Integer crmActorType)
intellisense: NSErpConnectionData.SetCrmActorType
keywords: NSErpConnectionData, GetCrmActorType
so.topic: reference
---

The crm actor type which these fields belongs to

**Parameter:** 
 - **crmActorType** Integer
     - Enum: 0 = Unknown 
     - Enum: 1 = Contact 
     - Enum: 2 = Person 
     - Enum: 3 = Project 
     - Enum: 4 = Sale 

```crmscript
NSErpConnectionData thing;
Integer crmActorType;
thing.SetCrmActorType(crmActorType);
```

