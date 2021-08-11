---
uid: crmscript_ref_NSErpConnectionData_GetErpActorType
title: Integer GetErpActorType()
intellisense: NSErpConnectionData.GetErpActorType
keywords: NSErpConnectionData, GetErpActorType
so.topic: reference
---

# Integer GetErpActorType()

The erp actor type which these fields belongs to

**Returns:** Integer

     - Enum: 0 = Unknown 
     - Enum: 1 = Customer 
     - Enum: 2 = Supplier 
     - Enum: 3 = Partner 
     - Enum: 4 = Person 
     - Enum: 5 = Project 
     - Enum: 6 = Employee 
     - Enum: 7 = Sale 

```crmscript
NSErpConnectionData thing;
Integer erpActorType  = thing.GetErpActorType();
```

