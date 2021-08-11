---
uid: crmscript_ref_NSCustomerServiceStartup_SetRecaptchaSiteKey
title: SetRecaptchaSiteKey(String recaptchaSiteKey)
intellisense: NSCustomerServiceStartup.SetRecaptchaSiteKey
keywords: NSCustomerServiceStartup, GetRecaptchaSiteKey
so.topic: reference
---

# SetRecaptchaSiteKey(String recaptchaSiteKey)

A global recaptcha site key, used with the google recaptcha component. This value is taken from the web.config file

**Parameter:** 
 - **recaptchaSiteKey** String

```crmscript
NSCustomerServiceStartup thing;
String recaptchaSiteKey;
thing.SetRecaptchaSiteKey(recaptchaSiteKey);
```

