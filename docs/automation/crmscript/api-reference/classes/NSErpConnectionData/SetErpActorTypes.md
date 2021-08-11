---
uid: crmscript_ref_NSErpConnectionData_SetErpActorTypes
title: SetErpActorTypes(NSErpActorType[] erpActorTypes)
intellisense: NSErpConnectionData.SetErpActorTypes
keywords: NSErpConnectionData, GetErpActorTypes
so.topic: reference
---

# SetErpActorTypes(NSErpActorType[] erpActorTypes)

Contains all mapped NSErpActorType for this NSCrmActorType

**Parameter:** 
 - **erpActorTypes** NSErpActorType[]
     - Enum: 0 = Unknown 
     - Enum: 1 = Customer 
     - Enum: 2 = Supplier 
     - Enum: 3 = Partner 
     - Enum: 4 = Person 
     - Enum: 5 = Project 
     - Enum: 6 = Employee 
     - Enum: 7 = Sale 

* **Returns:** NSErpActorType[]

```crmscript
NSErpConnectionData thing;
NSErpActorType[] erpActorTypes;
thing.SetErpActorTypes(erpActorTypes);
```

