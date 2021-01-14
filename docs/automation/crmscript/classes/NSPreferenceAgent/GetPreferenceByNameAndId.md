---
title: NSPreference GetPreferenceByNameAndId(String prefSection, String prefKey, Integer prefLevel, Integer ownerId)
path: /EJScript/Classes/NSPreferenceAgent/Member functions/NSPreference GetPreferenceByNameAndId(String p_0, String p_1, Integer p_2, Integer p_3)
intellisense: 1
classref: 1
keywords: GetPreferenceByNameAndId(String,String,Integer,Integer)
---


Get a preference by name and owner id.



* **prefSection:** The preference section name. e.g. 'Functions'. See SuperOffice.CRM.UserPreferenceStrings for constants.
* **prefKey:** The preference key name. e.g. 'ShowTipsAtStart'. See SuperOffice.CRM.UserPreferenceStrings for constants.
* **prefLevel:** The preference level to read. Undefined (0) means to return the preference defined closest to the user.
* **ownerId:** The preference owner id, individual or group.
* **Returns:** The preference. Note that id = 0 and value = null if preference not found in the database at the requested pref-level.


