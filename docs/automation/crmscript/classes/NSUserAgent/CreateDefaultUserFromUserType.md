---
title: NSUser CreateDefaultUserFromUserType(Integer userType)
path: /EJScript/Classes/NSUserAgent/Member functions/NSUser CreateDefaultUserFromUserType(Integer p_0)
intellisense: 1
classref: 1
keywords: CreateDefaultUserFromUserType(Integer)
---


Create default User providing the user type.  Only System and Anonymous users can be created without an exsisting person.  Use CreateDefaultUserFromUserTypeAndPersonId to create internal (i.e. Employee) or external users.



* **userType:** Type of associate for the user.  This can only be System or Anonymous. Use CreateDefaultUserFromUserTypeAndPersonId to create internal (i.e. Employee) or external users.
* **Returns:** New user object with defalt values set.


