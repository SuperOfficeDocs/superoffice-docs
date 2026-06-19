---
uid: EventHandler
title: EventHandler
description: Archive of Event handlers - triggers - used by the web api and partners.
keywords: EventHandler archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "EventHandler"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.EventHandlersProvider">SuperOffice.CRM.ArchiveLists.EventHandlersProvider</see> inside NetServer's SODatabase assembly.

Archive of Event handlers - triggers - used by the web api and partners.
Lists all triggers in screenchooser table with screenType &gt;= 100.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"eventHandler"|eventHandler|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|name|string|SR\_SCRIPT\_NAME: SR\_SCRIPT\_NAME\_TOOLTIP| x |
|uniqueIdentifier|string|SR\_SCRIPT\_UU: SR\_SCRIPT\_UU\_TOOLTIP| x |
|path|string|SR\_SCRIPT\_PATH: SR\_SCRIPT\_PATH\_TOOLTIP| x |
|screenChooserId|int|SR\_SCREENCHOOSER\_ID: SR\_SCREENCHOOSER\_ID\_TOOLTIP| x |
|screenType|string|SR\_SCREENCHOOSER\_SCREENTYPE: SR\_SCREENCHOOSER\_SCREENTYPE\_TOOLTIP| x |
|enabled|bool|SR\_SCREENCHOOSER\_ENABLED: SR\_SCREENCHOOSER\_ENABLED\_TOOLTIP| x |
|updatedBy|associate|SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|updatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|registeredBy|associate|SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|registeredDate|date|SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |

## Sample

```http!
GET /api/v1/archive/EventHandler?$select=path,screenType
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

