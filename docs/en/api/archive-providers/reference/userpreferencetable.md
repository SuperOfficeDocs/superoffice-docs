---
uid: UserPreferenceTable
title: UserPreferenceTable
description: Archive provider for preferences that live in the <b>userpreference</b> table. <see cref="T -SuperOffice.CRM.ArchiveLists.MappedPreferenceProvider" /> for those that
keywords: UserPreferenceTable archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "UserPreferenceTable"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.UserPreferenceTableProvider">SuperOffice.CRM.ArchiveLists.UserPreferenceTableProvider</see> inside NetServer's SODatabase assembly.

Archive provider for preferences that live in the <b>userpreference</b> table. <see cref="T:SuperOffice.CRM.ArchiveLists.MappedPreferenceProvider" /> for those that
actually live in the Service tables.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"default"|default|
|"system"|system|
|"database"|[[SR_PREFERENCE_DATABASE]]|
|"group"|[[SR_PREFERENCE_GROUP]]|
|"user"|[[SR_PREFERENCE_USER]]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
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
GET /api/v1/archive/UserPreferenceTable?$select=deflevelname,maxlevelname
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

