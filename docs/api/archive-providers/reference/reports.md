---
uid: Reports
title: Reports
description: Archive provider for the list of reports
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

# "Reports"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.ReportsProviderBase">SuperOffice.CRM.ArchiveLists.ReportsProviderBase</see> inside NetServer's SODatabase assembly.

Archive provider for the list of reports

## Supported Entities
| Name | Description |
| ---- | ----- |
|"all"|[all]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|reportId|int|ID| x |
|reportName|string|Name| x |
|reportLayoutName|int|Layout| x |
|reportTypeName|int|Type| x |
|reportOwnerName|associate|Owner| x |
|reportPublished|int|Published| x |

## Sample

```http!
GET /api/v1/archive/Reports?$select=reportId,reportLayoutName
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

