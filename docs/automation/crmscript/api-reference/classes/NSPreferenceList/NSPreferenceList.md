---
uid: crmscript_ref_NSPreferenceList
title: NSPreferenceList
intellisense: Void.NSPreferenceList
keywords: NSPreferenceList
so.topic: reference
---

# NSPreferenceList

Use this service to retrieve one or more preferences. Preferences follow a multi-level structure that starts with system-wide and goes via database, group to associate level. The lowermost (closest to associate) definition wins. Preference values are always calculated relative to the current associate; you do NOT get raw table values here. Preferences are saved/changed individually, but can be retrieved as a group.
