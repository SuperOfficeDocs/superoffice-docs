---
uid: crmscript_ref_NSTemplateVariablesParameters_GetCultureName
title: String GetCultureName()
intellisense: NSTemplateVariablesParameters.GetCultureName
keywords: NSTemplateVariablesParameters, GetCultureName
so.topic: reference
---

Name of culture to be used for culture-sensitive data, such as dates or multi-language texts. Use a blank string to accept current culture that is set on the server.

**Returns:** String


```crmscript
NSTemplateVariablesParameters thing;
String cultureName  = thing.GetCultureName();
```


