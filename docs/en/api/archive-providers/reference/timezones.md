---
uid: TimeZones
title: TimeZones
description: 
keywords: TimeZones archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "TimeZones"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.TimeZonesProvider">SuperOffice.CRM.ArchiveLists.TimeZonesProvider</see> inside NetServer's SODatabase assembly.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"all"|[[SR_VFC_ALL]]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|id| *None* ||  |
|isActive| *None* || x |
|flag| *None* || x |
|timeZone|string|SR\_ADMIN\_SYSTEM\_TIMEZONE\_COLUMN\_TZ| x |
|country|string|SR\_ADMIN\_SYSTEM\_TIMEZONE\_COLUMN\_COUNTRY| x |
|region|string|SR\_ADMIN\_SYSTEM\_TIMEZONE\_COLUMN\_REGION| x |
|cities|string|SR\_ADMIN\_SYSTEM\_TIMEZONE\_COLUMN\_CITIES| x |
|offset| *None* |SR\_ADMIN\_SYSTEM\_TIMEZONE\_COLUMN\_OFFSET|  |
|daylight| *None* |SR\_ADMIN\_SYSTEM\_TIMEZONE\_COLUMN\_DAYLIGHT|  |
|offsetRaw| *None* |SR\_ADMIN\_SYSTEM\_TIMEZONE\_COLUMN\_OFFSET|  |
|daylightRaw| *None* |SR\_ADMIN\_SYSTEM\_TIMEZONE\_COLUMN\_DAYLIGHT|  |

## Sample

```http!
GET /api/v1/archive/TimeZones?$select=offset,flag,country
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

