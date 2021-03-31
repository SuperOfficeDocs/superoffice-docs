---
title: crmscript_ref_NSUserAgent_ChangeUserType
description: User ChangeUserType(User user, Integer userType)
intellisense: NSUserAgent.ChangeUserType
keywords: NSUserAgent,ChangeUserType
so.topic: reference
---

Get a user from the user name.

**Parameters:**
 - **user** User name of the user to get.
 - **userType** 
     - Enum: 0 = Unknown 
     - Enum: 1 = InternalAssociate 
     - Enum: 2 = ResourceAssociate 
     - Enum: 3 = ExternalAssociate 
     - Enum: 4 = AnonymousAssociate 
     - Enum: 5 = SystemAssociate 

**Returns:** User retrieved by name

```crmscript
NSUserAgent agent;
User user;
Integer userType;
User res = agent.ChangeUserType(user, userType);
```

