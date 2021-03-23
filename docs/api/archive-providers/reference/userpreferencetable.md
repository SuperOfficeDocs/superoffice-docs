---
uid: UserPreferenceTable
title: UserPreferenceTable
description: Archive provider for preferences that live in the <b>userpreference</b> table. <see cref="T -SuperOffice.CRM.ArchiveLists.MappedPreferenceProvider" /> for those that
keywords:
  - "archive"
  - "provider"
  - "archive provider"
  - "UserPreferenceTable"
so.generated: true
so.date: 23.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "UserPreferenceTable"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.UserPreferenceTableProvider">SuperOffice.CRM.ArchiveLists.UserPreferenceTableProvider</see> inside NetServer's SODatabase assembly.

Archive provider for preferences that live in the <b>userpreference</b> table. <see cref="T:SuperOffice.CRM.ArchiveLists.MappedPreferenceProvider" /> for those that
actually live in the Service tables.

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
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
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
GET /api/v1/archive/UserPreferenceTable?$select=deflevelname,maxlevelname
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

