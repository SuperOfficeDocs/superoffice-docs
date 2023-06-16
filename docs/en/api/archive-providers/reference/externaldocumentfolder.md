---
uid: externaldocumentfolder
title: externaldocumentfolder
description: 
keywords:
  - "archive"
  - "provider"
  - "archive provider"
  - "externaldocumentfolder"
so.generated: true
so.date: 05.25.2023
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "externaldocumentfolder"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.ExternalDocumentFolderProvider">SuperOffice.CRM.ArchiveLists.ExternalDocumentFolderProvider</see> inside NetServer's SODatabase assembly.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"folder"|Folder|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|hierarchyId|int|Hierarchy ID: Foreign key to hierarchy table| x |
|hierarchyFullname|string|Hierarchy name: The full name/path from table hierarchy| x |
|hierarchyName|string|Hierarchy name: The full name/path from table hierarchy| x |
|hierarchyParentId|int|Hierarchy ID: Foreign key to hierarchy table| x |
|title|string|Title: Title of an External Document| x |
|description|string|Description: Description of an External Document| x |
|created|date|Created: Displays when the request was created| x |
|ownerHierarchyId|int|HierarchyId| x |

## Sample

```http!
GET /api/v1/archive/externaldocumentfolder?$select=hierarchyFullname,hierarchyParentId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

