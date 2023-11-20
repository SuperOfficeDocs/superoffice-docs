---
uid: externaldocuments
title: externaldocuments
description: 
keywords: externaldocuments archive provider
so.generated: true
so.topic: reference
so.envir: onsite, online
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
|nodeType|string|Type| x |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|title|string|Title: Title of an External Document| x |
|description|string|Description: Description of an External Document| x |
|createdBy| *None* |Created by|  |
|created|date|Created: Displays when the request was created| x |
|createdFullName| *None* |Full name: Displays full name of user (first, middle, last - according to settings)|  |
|ownerHierarchyId|int|HierarchyId| x |
|isInHistory| *None* |IsInHistory: Restriction only: in order to retrieve items that have relation in history table|  |
|contentType| *None* |Content type: SR\_ARCHIVE\_ATTACHMENT\_CONTENTTYPE\_TOOLTIP|  |
|name| *None* |Name: SR\_ARCHIVE\_ATTACHMENT\_NAME\_TOOLTIP|  |
|size| *None* |Size: SR\_ARCHIVE\_ATTACHMENT\_SIZE\_TOOLTIP|  |
|hierarchyId|int|Hierarchy ID: Foreign key to hierarchy table| x |
|hierarchyFullname|string|Hierarchy name: The full name/path from table hierarchy| x |
|hierarchyName|string|Hierarchy name: The full name/path from table hierarchy| x |
|hierarchyParentId|int|Hierarchy ID: Foreign key to hierarchy table| x |
|hierarchyFullpathIds| *None* |Folder path IDs: An integer array of nodes leading to a hierarchy/folder item, in root => leaf order|  |

## Sample

```http!
GET /api/v1/archive/externaldocuments?$select=getNoRows,created,isInHistory
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

