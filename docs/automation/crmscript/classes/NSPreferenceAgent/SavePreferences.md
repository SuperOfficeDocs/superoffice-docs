---
title: crmscript_ref_NSPreferenceAgent_SavePreferences
description: Void SavePreferences(PreferenceArray preferences)
intellisense: NSPreferenceAgent.SavePreferences
keywords: NSPreferenceAgent,SavePreferences
so.topic: reference
---

Save this set of preferences. Note this method DOES NOT look at level/targetId - it only saves on behalf of the CURRENT USER.

**Parameters:**
 - **preferences** Preferences to be saved. Note that all fields must be filled in, and the preference will be saved on the Associate level only! Setting for other levels is an administrative task and not available through this service.
