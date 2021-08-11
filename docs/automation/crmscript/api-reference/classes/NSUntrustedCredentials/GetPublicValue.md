---
uid: crmscript_ref_NSUntrustedCredentials_GetPublicValue
title: String GetPublicValue()
intellisense: NSUntrustedCredentials.GetPublicValue
keywords: NSUntrustedCredentials, GetPublicValue
so.topic: reference
---

# String GetPublicValue()

Data stored unencrypted in the db.  Typically server and or username. Max 238 characters.

**Returns:** String

```crmscript
NSUntrustedCredentials thing;
String publicValue  = thing.GetPublicValue();
```

