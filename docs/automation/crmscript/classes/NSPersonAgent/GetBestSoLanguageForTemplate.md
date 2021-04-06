---
uid: crmscript_ref_NSPersonAgent_GetBestSoLanguageForTemplate
title: String GetBestSoLanguageForTemplate(Integer personId, Integer templateId)
intellisense: NSPersonAgent.GetBestSoLanguageForTemplate
keywords: NSPersonAgent, GetBestSoLanguageForTemplate
so.topic: reference
---

Get the best language for this person on this template

**Parameters:**
 - **personId** The id of the person
 - **templateId** The id of the template to find languages on

**Returns:** The solang code for best language, empty string if no best language found

```crmscript
NSPersonAgent agent;
Integer personId;
Integer templateId;
String res = agent.GetBestSoLanguageForTemplate(personId, templateId);
```

