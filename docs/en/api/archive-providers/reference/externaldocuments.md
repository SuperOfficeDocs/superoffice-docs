---
uid: externaldocuments
title: externaldocuments
description: 
keywords:
  - "archive"
  - "provider"
  - "archive provider"
  - "externaldocuments"
so.generated: true
so.date: 05.25.2023
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "externaldocuments"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.ExternalDocumentsProvider">SuperOffice.CRM.ArchiveLists.ExternalDocumentsProvider</see> inside NetServer's SODatabase assembly.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"item"|Items|
|"folder"|Folder|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|title|string|Title: Title of an External Document| x |
|description|string|Description: Description of an External Document| x |
|createdBy| *None* |Created by|  |
|created|date|Created: Displays when the request was created| x |
|createdFullName| *None* |Full name: Displays full name of user (first, middle, last - according to settings)|  |
|ownerHierarchyId|int|HierarchyId| x |
|contentType| *None* |!!!Content type: !!!Content type|  |
|name| *None* |!!!Name: !!!Name|  |
|size| *None* |!!!Size: !!!Size|  |
|hierarchyId|int|Hierarchy ID: Foreign key to hierarchy table| x |
|hierarchyFullname|string|Hierarchy name: The full name/path from table hierarchy| x |
|hierarchyName|string|Hierarchy name: The full name/path from table hierarchy| x |
|hierarchyParentId|int|Hierarchy ID: Foreign key to hierarchy table| x |

## Sample

```http!
GET /api/v1/archive/externaldocuments?$select=created,ownerHierarchyId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

