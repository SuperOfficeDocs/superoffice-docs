---
uid: crmscript_ref_NSPreferenceAgent_SavePreferenceEntity
title: Preference SavePreferenceEntity(Preference preference, Bool removeLowerLevels)
intellisense: NSPreferenceAgent.SavePreferenceEntity
keywords: NSPreferenceAgent, SavePreferenceEntity
so.topic: reference
---

Saves a complete preference object, on any level and any target. Preference administrator rights are required to use this

**Parameters:**
 - **preference** The preference object to be saved
 - **removeLowerLevels** If this is true, all user preferences on lower levels will be deleted

**Returns:** Returns the saved preference

```crmscript
NSPreferenceAgent agent;
Preference preference;
Bool removeLowerLevels;
Preference res = agent.SavePreferenceEntity(preference, removeLowerLevels);
```

