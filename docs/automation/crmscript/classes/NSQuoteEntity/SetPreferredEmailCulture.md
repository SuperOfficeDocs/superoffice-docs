---
uid: crmscript_ref_NSQuoteEntity_SetPreferredEmailCulture
title: SetPreferredEmailCulture(String preferredEmailCulture)
intellisense: NSQuoteEntity.SetPreferredEmailCulture
keywords: NSQuoteEntity, GetPreferredEmailCulture
so.topic: reference
---

When emails are sent (offer or confirmation), a language can be chosen in the GUI; this field saves the most recent choice and can be used to default the next such choice. Default-default is user's current language

**Parameter:** 
 - **preferredEmailCulture** String

```crmscript
NSQuoteEntity thing;
String preferredEmailCulture;
thing.SetPreferredEmailCulture(preferredEmailCulture);
```

