---
uid: TimeZones
title: TimeZones
description: 
keywords:
  - "archive"
  - "provider"
  - "archive provider"
so.generated: true
so.date: 18.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "TimeZones"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.TimeZonesProvider">SuperOffice.CRM.ArchiveLists.TimeZonesProvider</see> inside NetServer's SODatabase assembly.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"all"|All|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|id| *None* ||  |
|isActive| *None* || x |
|flag| *None* || x |
|timeZone|string|Time zone| x |
|country|string|Country| x |
|region|string|Region| x |
|cities|string|Cities| x |
|offset| *None* |Offset| x |
|daylight| *None* |Daylight| x |
|offsetRaw| *None* |Offset| x |
|daylightRaw| *None* |Daylight| x |

## Sample

```http!
GET /api/v1/archive/TimeZones?$select=flag,country
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

