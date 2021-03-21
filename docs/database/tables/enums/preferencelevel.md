---
uid: enum-preferencelevel
title: Enum values for PreferenceLevel
description: Lists the enum values for PreferenceLevel.
so.generated: true
keywords:
  - "database"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# PreferenceLevel Enum

Highest override level allowed

* Undefined = 0
* HardDefault = 1
* SystemWide = 2
* Database = 3
* Group = 4
* Individual = 5
* PC = 6

## Usage

* [UserPreference](../userpreference.md).deflevel - Preference system. If deflevel is set to 5; the user may change the preferences
* [UserPreference](../userpreference.md).maxlevel - Preference system. If deflevel is set to 5; the user may change the preferences
* [PrefDesc](../prefdesc.md).maxLevel - Preference description, drives the Preference GUI. Maintenance client - controls all preferences in SuperOffice. You find an overview off all standard preference on http://techdoc.superoffice.com.  May be used by third-party developers to add system preferences to be updated from SuperOffice Maintenance client, instead of ini-files. 
* [PrefDesc](../prefdesc.md).sysMaxLevel - Preference description, drives the Preference GUI. Maintenance client - controls all preferences in SuperOffice. You find an overview off all standard preference on http://techdoc.superoffice.com.  May be used by third-party developers to add system preferences to be updated from SuperOffice Maintenance client, instead of ini-files. 
