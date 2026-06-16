---
uid: EmailFlowFolders
title: EmailFlowFolders
description: Archive of Email flow folders.
keywords: EmailFlowFolders archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "EmailFlowFolders"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.EmailFlowFolderProvider">SuperOffice.CRM.ArchiveLists.EmailFlowFolderProvider</see> inside NetServer's SODatabase assembly.

Archive of Email flow folders.
Lists all email flow folders

## Supported Entities
| Name | Description |
| ---- | ----- |
|"emailflowfolder"|emailflowfolder|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|hierarchyId|int|SR\_HIERARCHY\_ID: SR\_HIERARCHY\_ID\_TOOLTIP| x |
|hierarchyFullname|string|SR\_HIERARCHY\_FULLNAME: SR\_HIERARCHY\_FULLNAME\_TOOLTIP| x |
|hierarchyName|string|SR\_HIERARCHY\_FULLNAME: SR\_HIERARCHY\_FULLNAME\_TOOLTIP| x |
|hierarchyParentId|int|SR\_HIERARCHY\_ID: SR\_HIERARCHY\_ID\_TOOLTIP| x |
|hierarchyFullpathIds| *None* |SR\_ARCHIVE\_HIERARCHY\_FULLPATHIDS: SR\_ARCHIVE\_HIERARCHY\_FULLPATHIDS\_TOOLTIP|  |
|thumbnail| *None* |SR\_ARCHIVE\_EMAILFLOW\_THUMBNAIL|  |

## Sample

```http!
GET /api/v1/archive/EmailFlowFolders?$select=hierarchyId,hierarchyName
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

