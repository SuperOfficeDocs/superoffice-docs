---
uid: Dynamic
title: Dynamic
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

# "Dynamic"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.DotSyntaxProvider">SuperOffice.CRM.ArchiveLists.DotSyntaxProvider</see> inside NetServer's SODatabase assembly.

## Supported Entities
| Name | Description |
| ---- | ----- |

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |

## Sample

```http!
GET /api/v1/archive/Dynamic?$select=
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

