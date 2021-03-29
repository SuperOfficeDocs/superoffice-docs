---
title: crmscript_ref_NSPreferenceAgent_GetPreferenceByName_String_p_0_String_p_1_Integer_p_2
description: NSPreferenceAgent.GetPreferenceByName(String p_0, String p_1, Integer p_2)
intellisense: NSPreferenceAgent.GetPreferenceByName
keywords: GetPreferenceByName(String,String,Integer)
so.topic: reference
---


Get a preference by name



* **prefSection:** The preference section name. e.g. 'Functions'. See SuperOffice.CRM.UserPreferenceStrings for constants.
* **prefKey:** The preference key name. e.g. 'ShowTipsAtStart'. See SuperOffice.CRM.UserPreferenceStrings for constants.
* **prefLevel:** The preference level to read. Undefined (0) means to return the preference defined closest to the user.
* **Returns:** The preference. Note that id = 0 and value = null if preference not found in the database at the requested pref-level.


