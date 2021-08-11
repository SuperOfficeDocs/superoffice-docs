---
uid: crmscript_ref_NSTemplateVariablesParameters_SetCultureName
title: SetCultureName(String cultureName)
intellisense: NSTemplateVariablesParameters.SetCultureName
keywords: NSTemplateVariablesParameters, GetCultureName
so.topic: reference
---

# SetCultureName(String cultureName)

Name of culture to be used for culture-sensitive data, such as dates or multi-language texts. Use a blank string to accept current culture that is set on the server.

**Parameter:** 
 - **cultureName** String

```crmscript
NSTemplateVariablesParameters thing;
String cultureName;
thing.SetCultureName(cultureName);
```

