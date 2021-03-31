---
uid: crmscript_ref_NSUserAgent_ValidateUser
title: StringDictionary ValidateUser(User user)
intellisense: NSUserAgent.ValidateUser
keywords: NSUserAgent, ValidateUser
so.topic: reference
---

Check that entity is ready for saving, return error messages by field.

**Parameters:**
 - **user** Entity to be checked for errors.

**Returns:** Error messages tagged by field.

```crmscript
NSUserAgent agent;
User user;
StringDictionary res = agent.ValidateUser(user);
```

