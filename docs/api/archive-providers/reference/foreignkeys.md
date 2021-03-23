---
uid: ForeignKeys
title: ForeignKeys
description: Archive of Foreign Keys - used by the web api and partners.
keywords:
  - "archive"
  - "provider"
  - "archive provider"
  - "ForeignKeys"
so.generated: true
so.date: 23.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "ForeignKeys"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.ForeignKeysProvider">SuperOffice.CRM.ArchiveLists.ForeignKeysProvider</see> inside NetServer's SODatabase assembly.

Archive of Foreign Keys - used by the web api and partners.
Lists all foreign apps, and outer joins any devices + keys associated with the app.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"foreignKey"|[foreignKey]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|appId|int|App id: ForeignAppId| x |
|appName|string|App name: ForeignAppName| x |
|deviceId|int|Device id: ForeignDeviceId| x |
|deviceName|string|Device name: ForeignDeviceName| x |
|deviceIdentifier|string|Device identifier: ForeignDeviceIdentifier| x |
|deviceOwner|associate|Device owner: ForeignDeviceOwner|  |
|deviceLastSync|date|Device last synced: ForeignDeviceLastSynced|  |
|deviceLastSyncTrans|date|Device last sync trans: ForeignDeviceLastSyncedTrans|  |
|keyId|int|Key id: ForeignKeyId| x |
|keyName|string|Key name: ForeignKeyName| x |
|keyValue|string|Key value: ForeignKeyValue| x |
|tableId|int|Table id: ForeignKeyTable id| x |
|recordId|int|Record id: ForeignKeyRecordId| x |
|keyUpdatedBy|associate|Updated by: The user who last updated the data|  |
|keyUpdatedDate|date|Updated: The date/time the data was last updated in UTC.|  |
|keyRegisteredBy|associate|Registered by: The user who registered the data|  |
|keyRegisteredDate|date|Registered date: The date/time the data was registered in UTC.|  |

## Sample

```http!
GET /api/v1/archive/ForeignKeys?$select=keyRegisteredBy,deviceIdentifier,deviceLastSyncTrans
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

