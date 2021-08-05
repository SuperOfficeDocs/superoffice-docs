---
uid: ErpConnection
title: ErpConnection
description: Archive of ERP Connections, used by the ERP Integration Server
keywords:
  - "archive"
  - "provider"
  - "archive provider"
  - "ErpConnection"
so.generated: true
so.date: 03.23.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "ErpConnection"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.ErpConnectionProvider">SuperOffice.CRM.ArchiveLists.ErpConnectionProvider</see> inside NetServer's SODatabase assembly.

Archive of ERP Connections, used by the ERP Integration Server

## Supported Entities
| Name | Description |
| ---- | ----- |
|"erpConnection"|ERP connections|
|"deleted"|Deleted|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|id|int|Connection ID: Database key for an ERP connection|  |
|name|string|Name: Name of the ERP connection in the CRM system|  |
|description|string|Description: The description of the ERP connection in the CRM system|  |
|active|bool|Active: Is the ERP connection currently active?|  |
|erpId|string|ERP ID: The global unique ID of this ERP connection, as used by the Sync Connector|  |
|mostRecent|string|Timestamp: The timestamp of the most recent synchronization on this ERP connection|  |
|allAccess|bool|Unrestricted: There are no access restrictions on this ERP connection|  |
|deleted|bool|Deleted: Column showing if the ERP connection has been marked as deleted|  |
|updatedBy|associate|Updated by: The user who last updated the data| x |
|updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|registeredBy|associate|Registered by: The user who registered the data| x |
|registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|connector/id|stringorPK|Connection ID: Database key for an ERP connection| x |
|connector/url|string|URL of Sync Connector: The URL to the location where the Sync Connector is installed| x |
|connector/name|string|Name: Name of the ERP connection in the CRM system| x |
|connector/updatedBy|associate|Updated by: The user who last updated the data| x |
|connector/updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|connector/registeredBy|associate|Registered by: The user who registered the data| x |
|connector/registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |

## Sample

```http!
GET /api/v1/archive/ErpConnection?$select=updatedDate,mostRecent,updatedBy
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

