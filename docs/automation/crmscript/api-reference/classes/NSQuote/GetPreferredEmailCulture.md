---
uid: crmscript_ref_NSQuote_GetPreferredEmailCulture
title: String GetPreferredEmailCulture()
intellisense: NSQuote.GetPreferredEmailCulture
keywords: NSQuote, GetPreferredEmailCulture
so.topic: reference
---

# String GetPreferredEmailCulture()

When emails are sent (offer or confirmation), a language can be chosen in the GUI; this field saves the most recent choice and can be used to default the next such choice. Default-default is user's current language

**Returns:** String

```crmscript
NSQuote thing;
String preferredEmailCulture  = thing.GetPreferredEmailCulture();
```

