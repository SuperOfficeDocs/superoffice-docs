---
uid: crmscript_ref_NSUser_GetType
title: Integer GetType()
intellisense: NSUser.GetType
keywords: NSUser, GetType
so.topic: reference
---

NSUser type: 1=InternalAssociate, 2=ResourceAssociate, 3=ExternalAssociate, 4=AnonymousAssociate, 5=SystemAssociate 

**Returns:** Integer

     - Enum: 0 = Unknown 
     - Enum: 1 = InternalAssociate 
     - Enum: 2 = ResourceAssociate 
     - Enum: 3 = ExternalAssociate 
     - Enum: 4 = AnonymousAssociate 
     - Enum: 5 = SystemAssociate 

```crmscript
NSUser thing;
Integer type  = thing.GetType();
```


