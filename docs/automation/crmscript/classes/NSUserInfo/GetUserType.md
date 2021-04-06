---
uid: crmscript_ref_NSUserInfo_GetUserType
title: Integer GetUserType()
intellisense: NSUserInfo.GetUserType
keywords: NSUserInfo, GetUserType
so.topic: reference
---



**Returns:** Integer

     - Enum: 0 = Unknown 
     - Enum: 1 = InternalAssociate 
     - Enum: 2 = ResourceAssociate 
     - Enum: 3 = ExternalAssociate 
     - Enum: 4 = AnonymousAssociate 
     - Enum: 5 = SystemAssociate 

```crmscript
NSUserInfo thing;
Integer userType  = thing.GetUserType();
```


