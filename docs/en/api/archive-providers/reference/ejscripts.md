---
uid: Ejscripts
title: Ejscripts
description: Archive of CRM Scripts - used by the web api and partners.
keywords: Ejscripts archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "Ejscripts"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.EjscriptsProvider">SuperOffice.CRM.ArchiveLists.EjscriptsProvider</see> inside NetServer's SODatabase assembly.

Archive of CRM Scripts - used by the web api and partners.
Lists all CRM Scripts in the ejScript table.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"ejscript"|ejscript|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|name|string|SR\_SCRIPT\_NAME: SR\_SCRIPT\_NAME\_TOOLTIP| x |
|description|string|SR\_SCRIPT\_DESCRIPTION: SR\_SCRIPT\_DESCRIPTION\_TOOLTIP| x |
|uniqueIdentifier|string|SR\_SCRIPT\_UU: SR\_SCRIPT\_UU\_TOOLTIP| x |
|updatedBy|associate|SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|updatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|registeredBy|associate|SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|registeredDate|date|SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|path|string|SR\_SCRIPT\_PATH: SR\_SCRIPT\_PATH\_TOOLTIP| x |
|type|int|SR\_SCRIPT\_TYPE: SR\_SCRIPT\_TYPE\_TOOLTIP| x |
|ejscriptId|int|SR\_EJSCRIPT\_ID: SR\_EJSCRIPT\_ID\_TOOLTIP| x |
|includeId|string|SR\_EJSCRIPT\_INCLUDEID: SR\_EJSCRIPT\_INCLUDEID\_TOOLTIP| x |
|accessKey|string|SR\_EJSCRIPT\_ACCESSKEY: SR\_EJSCRIPT\_ACCESSKEY\_TOOLTIP| x |
|htmlOutput|bool|SR\_EJSCRIPT\_HTMLOUTPUT: SR\_EJSCRIPT\_HTMLOUTPUT\_TOOLTIP| x |
|extraMenuId|int|SR\_EJSCRIPT\_EXTRAMENUID: SR\_EJSCRIPT\_EXTRAMENUID\_TOOLTIP| x |
|hierarchyId|int|SR\_HIERARCHY\_ID: SR\_HIERARCHY\_ID\_TOOLTIP| x |
|hierarchyFullname|string|SR\_HIERARCHY\_FULLNAME: SR\_HIERARCHY\_FULLNAME\_TOOLTIP| x |
|hierarchyName|string|SR\_HIERARCHY\_FULLNAME: SR\_HIERARCHY\_FULLNAME\_TOOLTIP| x |
|hierarchyParentId|int|SR\_HIERARCHY\_ID: SR\_HIERARCHY\_ID\_TOOLTIP| x |
|hierarchyFullpathIds| *None* |SR\_ARCHIVE\_HIERARCHY\_FULLPATHIDS: SR\_ARCHIVE\_HIERARCHY\_FULLPATHIDS\_TOOLTIP|  |

## Sample

```http!
GET /api/v1/archive/Ejscripts?$select=includeId,registeredBy,type
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

