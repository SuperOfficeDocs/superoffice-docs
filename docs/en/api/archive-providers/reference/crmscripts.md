---
uid: CRMScripts
title: CRMScripts
description: 
keywords: CRMScripts archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "CRMScripts"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.CrmScriptsProvider">SuperOffice.CRM.ArchiveLists.CrmScriptsProvider</see> inside NetServer's SODatabase assembly.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"ejscript"|ejscript|
|"eventHandler"|eventHandler|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|name|string|SR\_SCRIPT\_NAME: SR\_SCRIPT\_NAME\_TOOLTIP| x |
|description| *None* |SR\_SCRIPT\_DESCRIPTION: SR\_SCRIPT\_DESCRIPTION\_TOOLTIP|  |
|uniqueIdentifier|string|SR\_SCRIPT\_UU: SR\_SCRIPT\_UU\_TOOLTIP| x |
|updatedBy|associate|SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|updatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|registeredBy|associate|SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|registeredDate|date|SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|path|string|SR\_SCRIPT\_PATH: SR\_SCRIPT\_PATH\_TOOLTIP| x |
|type| *None* |SR\_SCRIPT\_TYPE: SR\_SCRIPT\_TYPE\_TOOLTIP|  |
|ejscriptId| *None* |SR\_EJSCRIPT\_ID: SR\_EJSCRIPT\_ID\_TOOLTIP|  |
|includeId| *None* |SR\_EJSCRIPT\_INCLUDEID: SR\_EJSCRIPT\_INCLUDEID\_TOOLTIP|  |
|accessKey| *None* |SR\_EJSCRIPT\_ACCESSKEY: SR\_EJSCRIPT\_ACCESSKEY\_TOOLTIP|  |
|htmlOutput| *None* |SR\_EJSCRIPT\_HTMLOUTPUT: SR\_EJSCRIPT\_HTMLOUTPUT\_TOOLTIP|  |
|extraMenuId| *None* |SR\_EJSCRIPT\_EXTRAMENUID: SR\_EJSCRIPT\_EXTRAMENUID\_TOOLTIP|  |
|hierarchyId| *None* |SR\_HIERARCHY\_ID: SR\_HIERARCHY\_ID\_TOOLTIP|  |
|hierarchyFullname| *None* |SR\_HIERARCHY\_FULLNAME: SR\_HIERARCHY\_FULLNAME\_TOOLTIP|  |
|hierarchyName| *None* |SR\_HIERARCHY\_FULLNAME: SR\_HIERARCHY\_FULLNAME\_TOOLTIP|  |
|hierarchyParentId| *None* |SR\_HIERARCHY\_ID: SR\_HIERARCHY\_ID\_TOOLTIP|  |
|hierarchyFullpathIds| *None* |SR\_ARCHIVE\_HIERARCHY\_FULLPATHIDS: SR\_ARCHIVE\_HIERARCHY\_FULLPATHIDS\_TOOLTIP|  |
|screenChooserId| *None* |SR\_SCREENCHOOSER\_ID: SR\_SCREENCHOOSER\_ID\_TOOLTIP|  |
|screenType| *None* |SR\_SCREENCHOOSER\_SCREENTYPE: SR\_SCREENCHOOSER\_SCREENTYPE\_TOOLTIP|  |
|enabled| *None* |SR\_SCREENCHOOSER\_ENABLED: SR\_SCREENCHOOSER\_ENABLED\_TOOLTIP|  |

## Sample

```http!
GET /api/v1/archive/CRMScripts?$select=registeredDate,includeId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

