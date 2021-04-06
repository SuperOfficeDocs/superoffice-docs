---
uid: crmscript_ref_NSUserAgent_CreateDefaultUserFromUserTypeAndPersonId
title: User CreateDefaultUserFromUserTypeAndPersonId(Integer userType, Integer personId)
intellisense: NSUserAgent.CreateDefaultUserFromUserTypeAndPersonId
keywords: NSUserAgent, CreateDefaultUserFromUserTypeAndPersonId
so.topic: reference
---

Create default User providing the associate type and person id.  System and Anonymous users can be created without an exsisting person and permits person id to be 0.

**Parameters:**
 - **userType** Type of associate for the user
     - Enum: 0 = Unknown 
     - Enum: 1 = InternalAssociate 
     - Enum: 2 = ResourceAssociate 
     - Enum: 3 = ExternalAssociate 
     - Enum: 4 = AnonymousAssociate 
     - Enum: 5 = SystemAssociate 
 - **personId** Primary key of the person to become a user.

**Returns:** New user object with defalt values set.

```crmscript
NSUserAgent agent;
Integer userType;
Integer personId;
User res = agent.CreateDefaultUserFromUserTypeAndPersonId(userType, personId);
```

