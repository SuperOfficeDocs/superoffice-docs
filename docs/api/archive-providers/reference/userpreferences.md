---
uid: UserPreferences
title: UserPreferences
description: User (and system) preference settings, at all levels
keywords:
  - "archive"
  - "provider"
  - "archive provider"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "UserPreferences"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.UserPreferencesProvider">SuperOffice.CRM.ArchiveLists.UserPreferencesProvider</see> inside NetServer's SODatabase assembly.

User (and system) preference settings, at all levels

The <see cref="T:SuperOffice.Data.SoPreference" /> class will return the <b>current</b> setting for a preference for the current principal.
This archive provider is for administrative purposes, and returns <b>all</b> settings for the preference(s) selected.
<br />
Preferences have multiple sources: the userpreference table (<see cref="T:SuperOffice.CRM.ArchiveLists.UserPreferenceTableProvider" />, and various
Service settings that are mapped into preferences, retrieved by <see cref="T:SuperOffice.CRM.ArchiveLists.MappedPreferenceProvider" />.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"default"|[default]|
|"system"|[system]|
|"database"|Database|
|"group"|Group|
|"user"|User|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|sectionKey|string|Section!Key|  |
|getAllRows| *None* |GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows| *None* |GetNone: Do not get any rows from the archive|  |
|userpreferenceId|int|Database ID: The database ID of the row in the userpreference table| x |
|deflevel|int|Level: The level at which the preference is defined; closest-to-the-user wins| x |
|deflevelname|string|Level: The type of the preference value (string, company, yes/no etc)| x |
|maxlevel|int|Max level: The maximum (closest to the user) level this preference is allowed on| x |
|maxlevelname|string|Max level: The maximum (closest to the user) level this preference is allowed on| x |
|ownerId|int|Owner: The owner of the preference value| x |
|owner|string|Who: Who is the owner of this preference value| x |
|prefsection|string|Section: The prefsection field in the database| x |
|prefkey|string|Key: The prefkey field in the database| x |
|prefvalue|string|Raw value: The raw value as it is in the database| x |
|value|string|Value: The value of the preference| x |

## Sample

```http!
GET /api/v1/archive/UserPreferences?$select=maxlevel,deflevel,maxlevelname
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

