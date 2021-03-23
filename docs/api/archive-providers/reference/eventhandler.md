---
uid: EventHandler
title: EventHandler
description: 
keywords:
  - "archive"
  - "provider"
  - "archive provider"
  - "EventHandler"
so.generated: true
so.date: 23.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "EventHandler"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.EventHandlersProvider">SuperOffice.CRM.ArchiveLists.EventHandlersProvider</see> inside NetServer's SODatabase assembly.

Archive of Event handlers - triggers - used by the web api and partners.
Lists all triggers in screenchooser table with screenType &gt;= 100.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"eventHandler"|[eventHandler]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|name|string|Name: Name of script. Can be used in file name.| x |
|uniqueIdentifier|string|UniqueIdentifier: An identifier that is globally unique, across all scripts and customers| x |
|path|string|Path: Full path that identifies the type of script| x |
|screenChooserId|int|ScreenChooser ID: Primary key for table ScreenChooser| x |
|screenType|string|ScreenType: Determines type of ScreenChooser| x |
|enabled|bool|Enabled: Enables or disables this ScreenChooser| x |
|updatedBy|associate|Updated by: The user who last updated the data| x |
|updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|registeredBy|associate|Registered by: The user who registered the data| x |
|registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |

## Sample

```http!
GET /api/v1/archive/EventHandler?$select=registeredDate,path,screenType
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

