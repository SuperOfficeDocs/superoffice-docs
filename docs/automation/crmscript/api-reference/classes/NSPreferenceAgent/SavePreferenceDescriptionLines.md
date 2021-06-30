---
uid: crmscript_ref_NSPreferenceAgent_SavePreferenceDescriptionLines
title: PreferenceDescriptionLine[] SavePreferenceDescriptionLines(PreferenceDescriptionLine[] preferenceDescriptionLines)
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
PreferenceDescriptionLine[] preferenceDescriptionLines;
PreferenceDescriptionLine[] res = agent.SavePreferenceDescriptionLines(preferenceDescriptionLines);
```

