---
uid: crmscript_ref_NSQuote_SetPreferredEmailCulture
title: SetPreferredEmailCulture(String preferredEmailCulture)
intellisense: NSQuote.SetPreferredEmailCulture
keywords: NSQuote, GetPreferredEmailCulture
so.topic: reference
---

# SetPreferredEmailCulture(String preferredEmailCulture)

When emails are sent (offer or confirmation), a language can be chosen in the GUI; this field saves the most recent choice and can be used to default the next such choice. Default-default is user's current language

**Parameter:** 
 - **preferredEmailCulture** String

```crmscript
NSQuote thing;
String preferredEmailCulture;
thing.SetPreferredEmailCulture(preferredEmailCulture);
```

