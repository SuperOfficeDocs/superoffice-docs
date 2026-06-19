---
uid: externaldocuments
title: externaldocuments
description: 
keywords: externaldocuments archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "externaldocuments"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.ExternalDocumentsProvider">SuperOffice.CRM.ArchiveLists.ExternalDocumentsProvider</see> inside NetServer's SODatabase assembly.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"item"|[[SR_ARCHIVE_EXTDOC_ITEMS]]|
|"folder"|[[SR_ARCHIVE_EXTDOC_FOLDERS]]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|nodeType|string|SR\_ARCHIVE\_EXTDOC\_NODETYPE| x |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|title|string|SR\_ARCHIVE\_EXTDOC\_TITLE: SR\_ARCHIVE\_EXTDOC\_TITLE\_TOOLTIP| x |
|description|string|SR\_ARCHIVE\_EXTDOC\_DESCRIPTION: SR\_ARCHIVE\_EXTDOC\_DESCRIPTION\_TOOLTIP| x |
|createdBy| *None* |SR\_TICKETARCHIVE\_CREATEDBY|  |
|created|date|SR\_TICKETARCHIVE\_CREATEDAT: SR\_TICKETARCHIVE\_CREATEDAT\_TOOLTIP| x |
|createdFullName| *None* |SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP|  |
|ownerHierarchyId|int|HierarchyId| x |
|isInHistory| *None* |IsInHistory: Restriction only: in order to retrieve items that have relation in history table|  |
|contentType| *None* |SR\_ARCHIVE\_ATTACHMENT\_CONTENTTYPE: SR\_ARCHIVE\_ATTACHMENT\_CONTENTTYPE\_TOOLTIP|  |
|name| *None* |SR\_ARCHIVE\_ATTACHMENT\_NAME: SR\_ARCHIVE\_ATTACHMENT\_NAME\_TOOLTIP|  |
|size| *None* |SR\_ARCHIVE\_ATTACHMENT\_SIZE: SR\_ARCHIVE\_ATTACHMENT\_SIZE\_TOOLTIP|  |
|hierarchyId|int|SR\_HIERARCHY\_ID: SR\_HIERARCHY\_ID\_TOOLTIP| x |
|hierarchyFullname|string|SR\_HIERARCHY\_FULLNAME: SR\_HIERARCHY\_FULLNAME\_TOOLTIP| x |
|hierarchyName|string|SR\_HIERARCHY\_FULLNAME: SR\_HIERARCHY\_FULLNAME\_TOOLTIP| x |
|hierarchyParentId|int|SR\_HIERARCHY\_ID: SR\_HIERARCHY\_ID\_TOOLTIP| x |
|hierarchyFullpathIds| *None* |SR\_ARCHIVE\_HIERARCHY\_FULLPATHIDS: SR\_ARCHIVE\_HIERARCHY\_FULLPATHIDS\_TOOLTIP|  |

## Sample

```http!
GET /api/v1/archive/externaldocuments?$select=created,isInHistory
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

