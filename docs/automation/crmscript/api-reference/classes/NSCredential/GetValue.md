---
uid: crmscript_ref_NSCredential_GetValue
title: String GetValue()
intellisense: NSCredential.GetValue
keywords: NSCredential, GetValue
so.topic: reference
---

# String GetValue()

This is the actuall value of the credentials.  This will typically be the password or teh users SID in active directory

**Returns:** String

```crmscript
NSCredential thing;
String value  = thing.GetValue();
```

