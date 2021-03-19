---
uid: MappedPreferences
title: MappedPreferences
description: Get all the mapped ('fake') Service preferences known to the <see cref="T:SuperOffice.Data.ServicePreferenceMapper" />.
<b>NOTE</b> that only <b>section</b> and <b>key</b> are supported as restrictions, and only with the <b>equals</b> operator.
Anything else needs to be coded!
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

# "MappedPreferences"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.MappedPreferenceProvider">SuperOffice.CRM.ArchiveLists.MappedPreferenceProvider</see> inside NetServer's SODatabase assembly.

Get all the mapped ('fake') Service preferences known to the <see cref="T:SuperOffice.Data.ServicePreferenceMapper" />.
<b>NOTE</b> that only <b>section</b> and <b>key</b> are supported as restrictions, and only with the <b>equals</b> operator.
Anything else needs to be coded!

## Supported Entities
| Name | Description |
| ---- | ----- |
|"system"|[system]|
|"user"|User|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
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
GET /api/v1/archive/MappedPreferences?$select=prefkey,maxlevel,ownerId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

