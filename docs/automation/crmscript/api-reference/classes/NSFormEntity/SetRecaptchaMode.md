---
uid: crmscript_ref_NSFormEntity_SetRecaptchaMode
title: SetRecaptchaMode(Integer recaptchaMode)
intellisense: NSFormEntity.SetRecaptchaMode
keywords: NSFormEntity, GetRecaptchaMode
so.topic: reference
---

# SetRecaptchaMode(Integer recaptchaMode)

What is the state of the recaptcha configuration? This is a read-only member

**Parameter:** 
 - **recaptchaMode** Integer
     - Enum: 0 = NotAvailable 
     - Enum: 1 = GlobalKeysExist 
     - Enum: 2 = KeysNeeded 

```crmscript
NSFormEntity thing;
Integer recaptchaMode;
thing.SetRecaptchaMode(recaptchaMode);
```

