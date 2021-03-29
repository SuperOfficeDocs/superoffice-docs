---
title: crmscript_ref_NSUserAgent_CreateDefaultUserFromUserType_Integer_p_0
description: NSUserAgent.CreateDefaultUserFromUserType(Integer p_0)
intellisense: NSUserAgent.CreateDefaultUserFromUserType
keywords: CreateDefaultUserFromUserType(Integer)
so.topic: reference
---


Create default User providing the user type.  Only System and Anonymous users can be created without an exsisting person.  Use CreateDefaultUserFromUserTypeAndPersonId to create internal (i.e. Employee) or external users.



* **userType:** Type of associate for the user.  This can only be System or Anonymous. Use CreateDefaultUserFromUserTypeAndPersonId to create internal (i.e. Employee) or external users.
* **Returns:** New user object with defalt values set.


