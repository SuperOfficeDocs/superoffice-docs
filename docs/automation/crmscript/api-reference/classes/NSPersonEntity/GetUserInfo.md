---
uid: crmscript_ref_NSPersonEntity_GetUserInfo
title: NSUserInfo GetUserInfo()
intellisense: NSPersonEntity.GetUserInfo
keywords: NSPersonEntity, GetUserInfo
so.topic: reference
---

# NSUserInfo GetUserInfo()

Information about the user if this person is a user.  If IsAssociate (e.g. is user is true) the NSUserInfo will be provided.

**Returns:** NSUserInfo

```crmscript
NSPersonEntity thing;
NSUserInfo userInfo  = thing.GetUserInfo();
```

