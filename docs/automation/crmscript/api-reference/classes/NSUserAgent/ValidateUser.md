---
uid: crmscript_ref_NSUserAgent_ValidateUser
title: StringDictionary ValidateUser(NSUser user)
intellisense: NSUserAgent.ValidateUser
keywords: NSUserAgent, ValidateUser
so.topic: reference
---

# StringDictionary ValidateUser(NSUser user)

Check that entity is ready for saving, return error messages by field.

**Parameters:**
 - **user** Entity to be checked for errors.

**Returns:** StringDictionary

```crmscript
NSUserAgent agent;
NSUser user;
StringDictionary res = agent.ValidateUser(user);
```

