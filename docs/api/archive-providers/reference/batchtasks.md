---
uid: BatchTasks
title: BatchTasks
description: Archive of Batch Tasks - used by the web api and partners.
Lists all batch tasks
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

# "BatchTasks"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.BatchTaskProvider">SuperOffice.CRM.ArchiveLists.BatchTaskProvider</see> inside NetServer's SODatabase assembly.

Archive of Batch Tasks - used by the web api and partners.
Lists all batch tasks

## Supported Entities
| Name | Description |
| ---- | ----- |
|"batchtask"|[batchtask]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|DefinitionId|int|Definition id: Defintion id| x |
|DefinitionName|string|Definition name: Defintion Name| x |
|DefinitionDescription|string|Definition descr: Defintion Description| x |
|DefinitionTimeOut|int|Timeout: Timeout| x |
|Description|string|Description: Description| x |
|DbTag|string|DbTag: DbTag| x |
|State|int|State: Task State| x |
|DetailsTable|int|Table: Task Table id| x |
|DetailsRecord|int|Record: Task Record id| x |
|Request|string|Request: Task Request|  |
|Response|string|Response: Task Response|  |
|StartCount|int|Start: Start count| x |
|LastStarted|date|Last Start: Task Last Started| x |
|ProgressPercent|int|Progress: Progress Percent| x |
|ProgressDescription|string|Progress Description: Progress Description|  |
|updatedBy|associate|Updated by: The user who last updated the data| x |
|updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|registeredBy|associate|Registered by: The user who registered the data| x |
|registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |

## Sample

```http!
GET /api/v1/archive/BatchTasks?$select=DbTag,DetailsRecord
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

