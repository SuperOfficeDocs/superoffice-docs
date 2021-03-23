---
uid: ReportProvider
title: ReportProvider
description: 
keywords:
  - "archive"
  - "provider"
  - "archive provider"
  - "ReportProvider"
so.generated: true
so.date: 23.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "ReportProvider"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.ReportProvider">SuperOffice.CRM.ArchiveLists.ReportProvider</see> inside NetServer's SODatabase assembly.

This archive provider is made for getting the available criteria for a given report.
The report id is set when instanciating the object through the

## Supported Entities
| Name | Description |
| ---- | ----- |

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |

## Sample

```http!
GET /api/v1/archive/ReportProvider?$select=
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

