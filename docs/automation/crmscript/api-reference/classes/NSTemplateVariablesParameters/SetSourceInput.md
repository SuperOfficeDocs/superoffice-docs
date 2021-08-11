---
uid: crmscript_ref_NSTemplateVariablesParameters_SetSourceInput
title: SetSourceInput(String sourceInput)
intellisense: NSTemplateVariablesParameters.SetSourceInput
keywords: NSTemplateVariablesParameters, GetSourceInput
so.topic: reference
---

# SetSourceInput(String sourceInput)

Source string to parse for template variables. Such variables must have delimiters corresponding to the standard for the given generator encoding.Non-text source data (such as the binary content of a .doc file) should be passed in as Base64.

**Parameter:** 
 - **sourceInput** String

```crmscript
NSTemplateVariablesParameters thing;
String sourceInput;
thing.SetSourceInput(sourceInput);
```

