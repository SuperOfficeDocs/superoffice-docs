---
title: crmscript_ref_NSUserAgent_SaveUserGroup
description: UserGroup SaveUserGroup(UserGroup userGroup)
intellisense: NSUserAgent.SaveUserGroup
keywords: NSUserAgent,SaveUserGroup
so.topic: reference
---

Save a user group.  Set UserGroup.Deleted to mark a user group as deleted and invisible in the user interface.

**Parameters:**
 - **userGroup** UserGroup to save

**Returns:** UserGroup as saved to the database

```crmscript
NSUserAgent agent;
UserGroup userGroup;
UserGroup res = agent.SaveUserGroup(userGroup);
```

