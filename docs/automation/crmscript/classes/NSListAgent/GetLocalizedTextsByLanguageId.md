---
title: crmscript_ref_NSListAgent_GetLocalizedTextsByLanguageId
description: LocalizedTextArray GetLocalizedTextsByLanguageId(Integer languageId)
intellisense: NSListAgent.GetLocalizedTextsByLanguageId
keywords: NSListAgent,GetLocalizedTextsByLanguageId
so.topic: reference
---

Gets all localized text belonging to a specific language.

**Parameters:**
 - **languageId** The LCID number of the language.

**Returns:** Array of LocalizedText objects

```crmscript
NSListAgent agent;
Integer languageId;
LocalizedTextArray res = agent.GetLocalizedTextsByLanguageId(languageId);
```

