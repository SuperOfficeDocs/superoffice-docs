---
uid: ErpSyncLog
title: ErpSyncLog
description: 
keywords: ErpSyncLog archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "ErpSyncLog"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.ErpSyncLogProvider">SuperOffice.CRM.ArchiveLists.ErpSyncLogProvider</see> inside NetServer's SODatabase assembly.

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
|connection|string|Connection| x |
|source|string|Source| x |
|target|string|Target| x |
|crmfieldkey|string|Field| x |
|oldvalue|string|Old Value| x |
|newvalue|string|New Value| x |
|updated|string|When| x |

## Sample

```http!
GET /api/v1/archive/ErpSyncLog?$select=connection,target
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

