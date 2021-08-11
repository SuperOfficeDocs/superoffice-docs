---
uid: crmscript_ref_NSPreferenceAgent_SavePreferenceDescriptionLines
title: NSPreferenceDescriptionLine[] SavePreferenceDescriptionLines(NSPreferenceDescriptionLine[] preferenceDescriptionLines)
intellisense: NSPreferenceAgent.SavePreferenceDescriptionLines
keywords: NSPreferenceAgent, SavePreferenceDescriptionLines
so.topic: reference
---

# NSPreferenceDescriptionLine[] SavePreferenceDescriptionLines(NSPreferenceDescriptionLine[] preferenceDescriptionLines)

Saves the PreferenceDescriptionLine array in the SuperOffice database

**Parameters:**
 - **preferenceDescriptionLines** The NSPreferenceDescriptionLine array to save.

**Returns:** NSPreferenceDescriptionLine[]

```crmscript
NSPreferenceAgent agent;
NSPreferenceDescriptionLine[] preferenceDescriptionLines;
NSPreferenceDescriptionLine[] res = agent.SavePreferenceDescriptionLines(preferenceDescriptionLines);
```

