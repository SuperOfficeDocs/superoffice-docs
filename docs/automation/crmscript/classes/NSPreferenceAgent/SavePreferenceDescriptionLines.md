---
uid: crmscript_ref_NSPreferenceAgent_SavePreferenceDescriptionLines
title: PreferenceDescriptionLineArray SavePreferenceDescriptionLines(PreferenceDescriptionLineArray preferenceDescriptionLines)
intellisense: NSPreferenceAgent.SavePreferenceDescriptionLines
keywords: NSPreferenceAgent, SavePreferenceDescriptionLines
so.topic: reference
---

Saves the PreferenceDescriptionLine array in the SuperOffice database

**Parameters:**
 - **preferenceDescriptionLines** The PreferenceDescriptionLine array to save.

**Returns:** The updated PrefDesc lines (If the PreferenceDescriptionLine array was new, it returns with id's set.

```crmscript
NSPreferenceAgent agent;
PreferenceDescriptionLineArray preferenceDescriptionLines;
PreferenceDescriptionLineArray res = agent.SavePreferenceDescriptionLines(preferenceDescriptionLines);
```

