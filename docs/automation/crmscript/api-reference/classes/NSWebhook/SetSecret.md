---
uid: crmscript_ref_NSWebhook_SetSecret
title: SetSecret(String secret)
intellisense: NSWebhook.SetSecret
keywords: NSWebhook, GetSecret
so.topic: reference
---

Shared secret key used for generating SHA256 HMAC signature, so that receiver can verify that call came from this server

**Parameter:** 
 - **secret** String

```crmscript
NSWebhook thing;
String secret;
thing.SetSecret(secret);
```

