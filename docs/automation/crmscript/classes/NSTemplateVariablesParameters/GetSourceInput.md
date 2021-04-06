---
uid: crmscript_ref_NSTemplateVariablesParameters_GetSourceInput
title: String GetSourceInput()
intellisense: NSTemplateVariablesParameters.GetSourceInput
keywords: NSTemplateVariablesParameters, GetSourceInput
so.topic: reference
---

Source string to parse for template variables. Such variables must have delimiters corresponding to the standard for the given generator encoding.Non-text source data (such as the binary content of a .doc file) should be passed in as Base64.

**Returns:** String


```crmscript
NSTemplateVariablesParameters thing;
String sourceInput  = thing.GetSourceInput();
```


