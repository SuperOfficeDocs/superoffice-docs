---
uid: crmscript_ref_NSFormEntity_GetRecaptchaMode
title: Integer GetRecaptchaMode()
intellisense: NSFormEntity.GetRecaptchaMode
keywords: NSFormEntity, GetRecaptchaMode
so.topic: reference
---

# Integer GetRecaptchaMode()

What is the state of the recaptcha configuration? This is a read-only member

**Returns:** Integer

     - Enum: 0 = NotAvailable 
     - Enum: 1 = GlobalKeysExist 
     - Enum: 2 = KeysNeeded 

```crmscript
NSFormEntity thing;
Integer recaptchaMode  = thing.GetRecaptchaMode();
```

