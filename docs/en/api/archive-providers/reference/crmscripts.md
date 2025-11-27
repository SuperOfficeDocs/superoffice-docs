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
|name|string|Name: Name of script. Can be used in file name.| x |
|description| *None* |Description: Description of script|  |
|uniqueIdentifier|string|UniqueIdentifier: An identifier that is globally unique, across all scripts and customers| x |
|updatedBy|associate|Updated by: The user who last updated the data| x |
|updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|registeredBy|associate|Registered by: The user who registered the data| x |
|registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|path|string|Path: Full path that identifies the type of script| x |
|type| *None* |Type: The type/language of this script|  |
|ejscriptId| *None* |CRMScript ID: Primary key from the CRMScript table|  |
|includeId| *None* |IncludeID: Name to be used when including this script in another script|  |
|accessKey| *None* |Access key: Key to be used when calling this script externally|  |
|htmlOutput| *None* |HTML: Read the script output as HTML|  |
|extraMenuId| *None* |ExtraMenuId: Foreign key to the extra\_menu table|  |
|hierarchyId| *None* |Hierarchy ID: Foreign key to hierarchy table|  |
|hierarchyFullname| *None* |Hierarchy name: The full name/path from table hierarchy|  |
|hierarchyName| *None* |Hierarchy name: The full name/path from table hierarchy|  |
|hierarchyParentId| *None* |Hierarchy ID: Foreign key to hierarchy table|  |
|hierarchyFullpathIds| *None* |Folder path IDs: An integer array of nodes leading to a hierarchy/folder item, in root => leaf order|  |
|screenChooserId| *None* |ScreenChooser ID: Primary key for table ScreenChooser|  |
|screenType| *None* |ScreenType: Determines type of ScreenChooser|  |
|enabled| *None* |Enabled: Enables or disables this ScreenChooser|  |

## Sample

```http!
GET /api/v1/archive/CRMScripts?$select=name,registeredDate,includeId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

