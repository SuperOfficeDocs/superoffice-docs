---
title: crmscript_ref_NSUserAgent_CreateExternalUser
description: Integer CreateExternalUser(Integer personId, String userName, String password, Integer roleId, Bool isActive)
intellisense: NSUserAgent.CreateExternalUser
keywords: NSUserAgent,CreateExternalUser
so.topic: reference
---

Creates an associate of type external user.

**Parameters:**
 - **personId** The personId to create an external user for.
 - **userName** Login username.
 - **password** Login password.
 - **roleId** Id of role for the external user. The role must be a role of type external users.
 - **isActive** Set isActive to true to enable the external user to log in.

**Returns:** Returns the created associateId.

```crmscript
NSUserAgent agent;
Integer personId;
String userName;
String password;
Integer roleId;
Bool isActive;
Integer res = agent.CreateExternalUser(personId, userName, password, roleId, isActive);
```

