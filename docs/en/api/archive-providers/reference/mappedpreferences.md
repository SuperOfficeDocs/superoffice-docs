---
uid: MappedPreferences
title: MappedPreferences
description: Get all the mapped ('fake') Service preferences known to the <see cref="T -SuperOffice.Data.ServicePreferenceMapper" />.
keywords: MappedPreferences archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "MappedPreferences"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.MappedPreferenceProvider">SuperOffice.CRM.ArchiveLists.MappedPreferenceProvider</see> inside NetServer's SODatabase assembly.

Get all the mapped ('fake') Service preferences known to the <see cref="T:SuperOffice.Data.ServicePreferenceMapper" />.
<b>NOTE</b> that only <b>section</b> and <b>key</b> are supported as restrictions, and only with the <b>equals</b> operator.
Anything else needs to be coded!

## Supported Entities
| Name | Description |
| ---- | ----- |
|"system"|system|
|"user"|[[SR_PREFERENCE_USER]]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|userpreferenceId|int|SR\_USERPREFERENCE\_ID: SR\_USERPREFERENCE\_ID\_TOOLTIP| x |
|deflevel|int|SR\_USERPREFERENCE\_DEFLEVEL: SR\_USERPREFERENCE\_DEFLEVEL\_TOOLTIP| x |
|deflevelname|string|SR\_PREFERENCE\_TYPE: SR\_PREFERENCE\_TYPE\_TOOLTIP| x |
|maxlevel|int|SR\_USERPREFERENCE\_MAXLEVEL: SR\_USERPREFERENCE\_MAXLEVEL\_TOOLTIP| x |
|maxlevelname|string|SR\_USERPREFERENCE\_MAXLEVELNAME: SR\_USERPREFERENCE\_MAXLEVELNAME\_TOOLTIP| x |
|ownerId|int|SR\_USERPREFERENCE\_OWNERID: SR\_USERPREFERENCE\_OWNERID\_TOOLTIP| x |
|owner|string|SR\_PREFERENCE\_WHO: SR\_PREFERENCE\_WHO\_TOOLTIP| x |
|prefsection|string|SR\_USERPREFERENCE\_SECTION: SR\_USERPREFERENCE\_SECTION\_TOOLTIP| x |
|prefkey|string|SR\_USERPREFERENCE\_KEY: SR\_USERPREFERENCE\_KEY\_TOOLTIP| x |
|prefvalue|string|SR\_PREFERENCE\_RAWVALUE: SR\_PREFERENCE\_RAWVALUE\_TOOLTIP| x |
|value|string|SR\_PREFERENCE\_VALUE: SR\_PREFERENCE\_VALUE\_TOOLTIP| x |

## Sample

```http!
GET /api/v1/archive/MappedPreferences?$select=maxlevel,ownerId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

