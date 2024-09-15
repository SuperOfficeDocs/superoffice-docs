---
uid: enum-preferencelevel
title: Enum values for PreferenceLevel
description: Lists the enum values for PreferenceLevel.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# PreferenceLevel Enum

Highest override level allowed

| Name | Value | Description |
|------|-------|-------------|
|Undefined|0|Undefined value (error)|
|HardDefault|1|Default value used if no other value has been specified|
|SystemWide|2|Value valid for all databases under this licence|
|Database|3|Value valid for this database|
|Group|4|Value valid for this group|
|Individual|5|Value valid for this user|
|PC|6|Value valid for this computer (note: stored in the Registry, not in the database)|

## Usage

* [UserPreference](../userpreference.md).deflevel - Preference system. If deflevel is set to 5; the user may change the preferences
* [UserPreference](../userpreference.md).maxlevel - Preference system. If deflevel is set to 5; the user may change the preferences
* [PrefDesc](../prefdesc.md).maxLevel - Preference description, drives the Preference GUI. Maintenance client - controls all preferences in SuperOffice. You find an overview off all standard preference on http://techdoc.superoffice.com.  May be used by third-party developers to add system preferences to be updated from SuperOffice Maintenance client, instead of ini-files. 
* [PrefDesc](../prefdesc.md).sysMaxLevel - Preference description, drives the Preference GUI. Maintenance client - controls all preferences in SuperOffice. You find an overview off all standard preference on http://techdoc.superoffice.com.  May be used by third-party developers to add system preferences to be updated from SuperOffice Maintenance client, instead of ini-files. 
