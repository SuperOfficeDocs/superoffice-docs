---
uid: crmscript_ref_NSPreferenceAgent_SavePreferenceEntity
title: NSPreference SavePreferenceEntity(NSPreference preference, Bool removeLowerLevels)
intellisense: NSPreferenceAgent.SavePreferenceEntity
keywords: NSPreferenceAgent, SavePreferenceEntity
so.topic: reference
---

# NSPreference SavePreferenceEntity(NSPreference preference, Bool removeLowerLevels)

Saves a complete preference object, on any level and any target. Preference administrator rights are required to use this

**Parameters:**
 - **preference** The preference object to be saved
 - **removeLowerLevels** If this is true, all user preferences on lower levels will be deleted

**Returns:** NSPreference

```crmscript
NSPreferenceAgent agent;
NSPreference preference;
Bool removeLowerLevels;
NSPreference res = agent.SavePreferenceEntity(preference, removeLowerLevels);
```

