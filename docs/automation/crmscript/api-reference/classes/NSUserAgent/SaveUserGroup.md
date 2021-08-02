---
uid: crmscript_ref_NSUserAgent_SaveUserGroup
title: NSUserGroup SaveUserGroup(NSUserGroup userGroup)
intellisense: NSUserAgent.SaveUserGroup
keywords: NSUserAgent, SaveUserGroup
so.topic: reference
---

Save a user group.  Set UserGroup.Deleted to mark a user group as deleted and invisible in the user interface.

**Parameters:**
 - **userGroup** UserGroup to save

**Returns:** NSUserGroup

```crmscript
NSUserAgent agent;
NSUserGroup userGroup;
NSUserGroup res = agent.SaveUserGroup(userGroup);
```

