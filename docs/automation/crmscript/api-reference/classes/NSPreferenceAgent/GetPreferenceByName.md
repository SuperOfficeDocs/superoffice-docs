---
uid: crmscript_ref_NSPreferenceAgent_GetPreferenceByName
title: NSPreference GetPreferenceByName(String prefSection, String prefKey, Integer prefLevel)
intellisense: NSPreferenceAgent.GetPreferenceByName
keywords: NSPreferenceAgent, GetPreferenceByName
so.topic: reference
---

# NSPreference GetPreferenceByName(String prefSection, String prefKey, Integer prefLevel)

Get a preference by name

**Parameters:**
 - **prefSection** The preference section name. e.g. 'Functions'. See SuperOffice.CRM.UserPreferenceStrings for constants. 
 - **prefKey** The preference key name. e.g. 'ShowTipsAtStart'. See SuperOffice.CRM.UserPreferenceStrings for constants.
 - **prefLevel** The preference level to read. Undefined (0) means to return the preference defined closest to the user.
     - Enum: 0 = Undefined 
     - Enum: 1 = HardDefault 
     - Enum: 2 = SystemWide 
     - Enum: 3 = Database 
     - Enum: 4 = Group 
     - Enum: 5 = Individual 
     - Enum: 6 = PC 

**Returns:** NSPreference

```crmscript
NSPreferenceAgent agent;
String prefSection;
String prefKey;
Integer prefLevel;
NSPreference res = agent.GetPreferenceByName(prefSection, prefKey, prefLevel);
```

