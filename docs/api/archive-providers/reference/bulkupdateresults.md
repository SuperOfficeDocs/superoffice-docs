---
uid: BulkUpdateResults
title: BulkUpdateResults
description: 
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

# "BulkUpdateResults"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.BulkUpdateResults">SuperOffice.CRM.ArchiveLists.BulkUpdateResults</see> inside NetServer's SODatabase assembly.

## Supported Entities
| Name | Description |
| ---- | ----- |

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|dbRecordId|int|Record ID| x |
|date|datetime|Date| x |
|entityType|string|Type| x |
|assocId|associate|Associate ID| x |
|assocName|string|ID| x |
|result|string|Result| x |
|resultCount|int|Count| x |

## Sample

```http!
GET /api/v1/archive/BulkUpdateResults?$select=entityType,assocId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

