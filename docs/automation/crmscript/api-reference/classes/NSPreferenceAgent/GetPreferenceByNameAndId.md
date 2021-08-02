---
uid: crmscript_ref_NSPreferenceAgent_GetPreferenceByNameAndId
title: NSPreference GetPreferenceByNameAndId(String prefSection, String prefKey, Integer prefLevel, Integer ownerId)
intellisense: NSPreferenceAgent.GetPreferenceByNameAndId
keywords: NSPreferenceAgent, GetPreferenceByNameAndId
so.topic: reference
---

Get a preference by name and owner id.

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
 - **ownerId** The preference owner id, individual or group.

**Returns:** NSPreference

```crmscript
NSPreferenceAgent agent;
String prefSection;
String prefKey;
Integer prefLevel;
Integer ownerId;
NSPreference res = agent.GetPreferenceByNameAndId(prefSection, prefKey, prefLevel, ownerId);
```

