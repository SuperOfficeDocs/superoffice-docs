---
uid: ReportLabelLayout
title: ReportLabelLayout
description: This archive provider enables access to the information regarding report label layout.
keywords: ReportLabelLayout archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "ReportLabelLayout"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.ReportLabelLayoutProvider">SuperOffice.CRM.ArchiveLists.ReportLabelLayoutProvider</see> inside NetServer's SODatabase assembly.

This archive provider enables access to the information regarding report label layout.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"reportLabelLayout"|reportLabelLayout|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|labelLayoutId| *None* |labelLayoutId|  |
|name| *None* |SR\_REPORTER\_NAME|  |
|description| *None* |SR\_REPORTER\_DESCRIPTION\_SHORT|  |
|layout| *None* |SR\_REPORTER\_LAYOUT|  |
|papersize| *None* |SR\_REPORTER\_PAPER\_SIZE|  |
|orientation| *None* |SR\_REPORTER\_ORIENTATION|  |

## Sample

```http!
GET /api/v1/archive/ReportLabelLayout?$select=labelLayoutId,description
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

