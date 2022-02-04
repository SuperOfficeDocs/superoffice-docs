---
uid: ReportLabelLayout
title: ReportLabelLayout
description: This archive provider enables access to the information regarding report label layout.
keywords:
  - "archive"
  - "provider"
  - "archive provider"
  - "ReportLabelLayout"
so.generated: true
so.date: 03.23.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "ReportLabelLayout"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.ReportLabelLayoutProvider">SuperOffice.CRM.ArchiveLists.ReportLabelLayoutProvider</see> inside NetServer's SODatabase assembly.

This archive provider enables access to the information regarding report label layout.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"reportLabelLayout"|[reportLabelLayout]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|labelLayoutId| *None* |labelLayoutId|  |
|name| *None* |Name|  |
|description| *None* |Description|  |
|layout| *None* |Layout|  |
|papersize| *None* |Paper size|  |
|orientation| *None* |Orientation|  |

## Sample

```http!
GET /api/v1/archive/ReportLabelLayout?$select=description,labelLayoutId,description
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

