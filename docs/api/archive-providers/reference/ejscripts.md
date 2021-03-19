---
uid: Ejscripts
title: Ejscripts
description: Archive of CRM Scripts - used by the web api and partners.
Lists all CRM Scripts in the ejScript table.
keywords:
  - "archive"
  - "provider"
  - "archive provider"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "Ejscripts"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.EjscriptsProvider">SuperOffice.CRM.ArchiveLists.EjscriptsProvider</see> inside NetServer's SODatabase assembly.

Archive of CRM Scripts - used by the web api and partners.
Lists all CRM Scripts in the ejScript table.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"ejscript"|[ejscript]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|name|string|Name: Name of script. Can be used in file name.| x |
|description|string|Description: Description of script| x |
|uniqueIdentifier|string|UniqueIdentifier: An identifier that is globally unique, across all scripts and customers| x |
|updatedBy|associate|Updated by: The user who last updated the data| x |
|updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|registeredBy|associate|Registered by: The user who registered the data| x |
|registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|path|string|Path: Full path that identifies the type of script| x |
|ejscriptId|int|CRMScript ID: Primary key from the CRMScript table| x |
|includeId|string|IncludeID: Name to be used when including this script in another script| x |
|accessKey|string|Access key: Key to be used when calling this script externally| x |
|htmlOutput|bool|HTML: Read the script output as HTML| x |
|extraMenuId|int|ExtraMenuId: Foreign key to the extra\_menu table| x |
|hierarchyId|int|Hierarchy ID: Foreign key to hierarchy table| x |
|hierarchyFullname|string|Hierarchy name: The full name/path from table hierarchy| x |

## Sample

```http!
GET /api/v1/archive/Ejscripts?$select=updatedBy,registeredDate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

