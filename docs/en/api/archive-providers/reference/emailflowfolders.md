---
uid: EmailFlowFolders
title: EmailFlowFolders
description: Archive of Email flow folders.
keywords:
  - "archive"
  - "provider"
  - "archive provider"
  - "EmailFlowFolders"
so.generated: true
so.date: 05.09.2023
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "EmailFlowFolders"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.EmailFlowFolderProvider">SuperOffice.CRM.ArchiveLists.EmailFlowFolderProvider</see> inside NetServer's SODatabase assembly.

Archive of Email flow folders.
Lists all email flow folders

## Supported Entities
| Name | Description |
| ---- | ----- |
|"emailflowfolder"|[emailflowfolder]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|hierarchyId|int|Hierarchy ID: Foreign key to hierarchy table| x |
|hierarchyFullname|string|Hierarchy name: The full name/path from table hierarchy| x |
|hierarchyName|string|Hierarchy name: The full name/path from table hierarchy| x |
|hierarchyParentId|int|Hierarchy ID: Foreign key to hierarchy table| x |
|thumbnail| *None* |Thumbnail|  |

## Sample

```http!
GET /api/v1/archive/EmailFlowFolders?$select=hierarchyId,hierarchyFullname
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

