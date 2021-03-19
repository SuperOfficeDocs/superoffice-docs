<properties generated="1" SortOrder="990" />

# PreferenceLevel Enum

Lowest allowed setting level, set by user, but not lower than sysMaxLevel

* Undefined = 0
* HardDefault = 1
* SystemWide = 2
* Database = 3
* Group = 4
* Individual = 5
* PC = 6

## Usage
* [UserPreference](UserPreference.md).deflevel - Preference system. If deflevel is set to 5; the user may change the preferences
* [UserPreference](UserPreference.md).maxlevel - Preference system. If deflevel is set to 5; the user may change the preferences
* [PrefDesc](PrefDesc.md).maxLevel - Preference description, drives the Preference GUI. Maintenance client - controls all preferences in SuperOffice. You find an overview off all standard preference on http://techdoc.superoffice.com.  May be used by third-party developers to add system preferences to be updated from SuperOffice Maintenance client, instead of ini-files. 
* [PrefDesc](PrefDesc.md).sysMaxLevel - Preference description, drives the Preference GUI. Maintenance client - controls all preferences in SuperOffice. You find an overview off all standard preference on http://techdoc.superoffice.com.  May be used by third-party developers to add system preferences to be updated from SuperOffice Maintenance client, instead of ini-files. 

