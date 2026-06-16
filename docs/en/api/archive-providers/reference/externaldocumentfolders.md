---
uid: externaldocumentfolders
title: externaldocumentfolders
description: 
keywords: externaldocumentfolders archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "externaldocumentfolders"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.ExternalDocumentFolderProvider">SuperOffice.CRM.ArchiveLists.ExternalDocumentFolderProvider</see> inside NetServer's SODatabase assembly.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"folder"|[[SR_ARCHIVE_EXTDOC_FOLDERS]]|

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
|title|string|SR\_ARCHIVE\_EXTDOC\_TITLE: SR\_ARCHIVE\_EXTDOC\_TITLE\_TOOLTIP| x |
|description|string|SR\_ARCHIVE\_EXTDOC\_DESCRIPTION: SR\_ARCHIVE\_EXTDOC\_DESCRIPTION\_TOOLTIP| x |
|created|date|SR\_TICKETARCHIVE\_CREATEDAT: SR\_TICKETARCHIVE\_CREATEDAT\_TOOLTIP| x |
|ownerHierarchyId|int|HierarchyId| x |

## Sample

```http!
GET /api/v1/archive/externaldocumentfolders?$select=hierarchyFullname,hierarchyParentId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

