---
uid: crmscript_ref_NSCustomerServiceStartup_GetRecaptchaSiteKey
title: String GetRecaptchaSiteKey()
intellisense: NSCustomerServiceStartup.GetRecaptchaSiteKey
keywords: NSCustomerServiceStartup, GetRecaptchaSiteKey
so.topic: reference
---

# String GetRecaptchaSiteKey()

A global recaptcha site key, used with the google recaptcha component. This value is taken from the web.config file

**Returns:** String

```crmscript
NSCustomerServiceStartup thing;
String recaptchaSiteKey  = thing.GetRecaptchaSiteKey();
```

