---
title: crmscript_ref_NSPreferenceAgent_GetPreferenceByName
description: Preference GetPreferenceByName(String prefSection, String prefKey, Integer prefLevel)
intellisense: NSPreferenceAgent.GetPreferenceByName
keywords: NSPreferenceAgent,GetPreferenceByName
so.topic: reference
---

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

**Returns:** The preference. Note that id = 0 and value = null if preference not found in the database at the requested pref-level.

```crmscript
NSPreferenceAgent agent;
String prefSection;
String prefKey;
Integer prefLevel;
Preference res = agent.GetPreferenceByName(prefSection, prefKey, prefLevel);
```

