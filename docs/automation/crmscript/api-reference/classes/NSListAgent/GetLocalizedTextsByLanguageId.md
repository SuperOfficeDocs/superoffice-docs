---
uid: crmscript_ref_NSListAgent_GetLocalizedTextsByLanguageId
title: NSLocalizedText[] GetLocalizedTextsByLanguageId(Integer languageId)
intellisense: NSListAgent.GetLocalizedTextsByLanguageId
keywords: NSListAgent, GetLocalizedTextsByLanguageId
so.topic: reference
---

# NSLocalizedText[] GetLocalizedTextsByLanguageId(Integer languageId)

Gets all localized text belonging to a specific language.

**Parameters:**
 - **languageId** The LCID number of the language.

**Returns:** NSLocalizedText[]

```crmscript
NSListAgent agent;
Integer languageId;
NSLocalizedText[] res = agent.GetLocalizedTextsByLanguageId(languageId);
```

