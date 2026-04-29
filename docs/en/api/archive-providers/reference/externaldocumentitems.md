---
uid: externaldocumentitems
title: externaldocumentitems
description: <b>External Documents</b> is the same as the Image Library in service - images (and maybe other things?) that
keywords: externaldocumentitems archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "externaldocumentitems"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.ExternalDocumentItemsProvider">SuperOffice.CRM.ArchiveLists.ExternalDocumentItemsProvider</see> inside NetServer's SODatabase assembly.

<b>External Documents</b> is the same as the Image Library in service - images (and maybe other things?) that
can be added to messages. They are a special kind of attachment, and conencted to a folder hierarchy.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"item"|Items|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|title|string|Title: Title of an External Document| x |
|description|string|Description: Description of an External Document| x |
|createdBy|listAny|Created by| x |
|created|date|Created: Displays when the request was created| x |
|createdFullName| *None* |Full name: Displays full name of user (first, middle, last - according to settings)| x |
|ownerHierarchyId|int|HierarchyId| x |
|isInHistory|bool|IsInHistory: Restriction only: in order to retrieve items that have relation in history table|  |
|contentType|string|Content type: SR\_ARCHIVE\_ATTACHMENT\_CONTENTTYPE\_TOOLTIP| x |
|name|string|Name: SR\_ARCHIVE\_ATTACHMENT\_NAME\_TOOLTIP| x |
|size|int|Size: SR\_ARCHIVE\_ATTACHMENT\_SIZE\_TOOLTIP| x |
|hierarchyId|int|Hierarchy ID: Foreign key to hierarchy table| x |
|hierarchyFullname|string|Hierarchy name: The full name/path from table hierarchy| x |
|hierarchyName|string|Hierarchy name: The full name/path from table hierarchy| x |
|hierarchyParentId|int|Hierarchy ID: Foreign key to hierarchy table| x |
|hierarchyFullpathIds| *None* |Folder path IDs: An integer array of nodes leading to a hierarchy/folder item, in root => leaf order|  |

## Sample

```http!
GET /api/v1/archive/externaldocumentitems?$select=created,isInHistory
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

