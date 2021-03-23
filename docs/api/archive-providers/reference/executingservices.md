---
uid: ExecutingServices
title: ExecutingServices
description: 
keywords:
  - "archive"
  - "provider"
  - "archive provider"
  - "ExecutingServices"
so.generated: true
so.date: 23.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "ExecutingServices"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.ExecutingServicesProvider">SuperOffice.CRM.ArchiveLists.ExecutingServicesProvider</see> inside NetServer's SODatabase assembly.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"current"|[Current]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|contextId|string|Context ID: Context ID| x |
|threadId|int|Thread ID: Thread ID| x |
|threadName|string|Thread: Thread| x |
|agent|string|Agent: Agent| x |
|method|string|Method: Method| x |
|parameters|string|Parameters: Parameters| x |
|runtime|int|Time ms: Time ms| x |
|assocName|string|User: User| x |
|appToken|string|App token: App token| x |
|opSeqNo|int|Seq no: Seq no| x |
|dbOps|int|DbOps: DbOps| x |
|dbRows|int|DbRows: DbRows| x |

## Sample

```http!
GET /api/v1/archive/ExecutingServices?$select=method,runtime
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

