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
|"item"|[[SR_ARCHIVE_EXTDOC_ITEMS]]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|title|string|SR\_ARCHIVE\_EXTDOC\_TITLE: SR\_ARCHIVE\_EXTDOC\_TITLE\_TOOLTIP| x |
|description|string|SR\_ARCHIVE\_EXTDOC\_DESCRIPTION: SR\_ARCHIVE\_EXTDOC\_DESCRIPTION\_TOOLTIP| x |
|createdBy|listAny|SR\_TICKETARCHIVE\_CREATEDBY| x |
|created|date|SR\_TICKETARCHIVE\_CREATEDAT: SR\_TICKETARCHIVE\_CREATEDAT\_TOOLTIP| x |
|createdFullName| *None* |SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|ownerHierarchyId|int|HierarchyId| x |
|isInHistory|bool|IsInHistory: Restriction only: in order to retrieve items that have relation in history table|  |
|contentType|string|SR\_ARCHIVE\_ATTACHMENT\_CONTENTTYPE: SR\_ARCHIVE\_ATTACHMENT\_CONTENTTYPE\_TOOLTIP| x |
|name|string|SR\_ARCHIVE\_ATTACHMENT\_NAME: SR\_ARCHIVE\_ATTACHMENT\_NAME\_TOOLTIP| x |
|size|int|SR\_ARCHIVE\_ATTACHMENT\_SIZE: SR\_ARCHIVE\_ATTACHMENT\_SIZE\_TOOLTIP| x |
|hierarchyId|int|SR\_HIERARCHY\_ID: SR\_HIERARCHY\_ID\_TOOLTIP| x |
|hierarchyFullname|string|SR\_HIERARCHY\_FULLNAME: SR\_HIERARCHY\_FULLNAME\_TOOLTIP| x |
|hierarchyName|string|SR\_HIERARCHY\_FULLNAME: SR\_HIERARCHY\_FULLNAME\_TOOLTIP| x |
|hierarchyParentId|int|SR\_HIERARCHY\_ID: SR\_HIERARCHY\_ID\_TOOLTIP| x |
|hierarchyFullpathIds| *None* |SR\_ARCHIVE\_HIERARCHY\_FULLPATHIDS: SR\_ARCHIVE\_HIERARCHY\_FULLPATHIDS\_TOOLTIP|  |

## Sample

```http!
GET /api/v1/archive/externaldocumentitems?$select=created,isInHistory
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

