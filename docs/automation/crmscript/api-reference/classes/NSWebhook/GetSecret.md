---
uid: crmscript_ref_NSWebhook_GetSecret
title: String GetSecret()
intellisense: NSWebhook.GetSecret
keywords: NSWebhook, GetSecret
so.topic: reference
---

# String GetSecret()

Shared secret key used for generating SHA256 HMAC signature, so that receiver can verify that call came from this server

**Returns:** String

```crmscript
NSWebhook thing;
String secret  = thing.GetSecret();
```

