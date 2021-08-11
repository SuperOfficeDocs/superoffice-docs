---
uid: crmscript_ref_NSPersonAgent_GetBestSoLanguageForTemplate
title: String GetBestSoLanguageForTemplate(Integer personId, Integer templateId)
intellisense: NSPersonAgent.GetBestSoLanguageForTemplate
keywords: NSPersonAgent, GetBestSoLanguageForTemplate
so.topic: reference
---

# String GetBestSoLanguageForTemplate(Integer personId, Integer templateId)

Get the best language for this person on this template

**Parameters:**
 - **personId** The id of the person
 - **templateId** The id of the template to find languages on

**Returns:** String

```crmscript
NSPersonAgent agent;
Integer personId;
Integer templateId;
String res = agent.GetBestSoLanguageForTemplate(personId, templateId);
```

