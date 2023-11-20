---
uid: externaldocumentfolders
title: externaldocumentfolders
description: 
keywords: externaldocumentfolders archive provider
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "externaldocumentfolders"

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
|hierarchyFullpathIds| *None* |Folder path IDs: An integer array of nodes leading to a hierarchy/folder item, in root => leaf order|  |
|title|string|Title: Title of an External Document| x |
|description|string|Description: Description of an External Document| x |
|created|date|Created: Displays when the request was created| x |
|ownerHierarchyId|int|HierarchyId| x |

## Sample

```http!
GET /api/v1/archive/externaldocumentfolders?$select=hierarchyParentId,hierarchyFullname,hierarchyParentId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

