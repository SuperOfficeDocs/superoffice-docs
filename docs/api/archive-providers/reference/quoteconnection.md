---
uid: QuoteConnection
title: QuoteConnection
description: This is the archive Provider for the QuoteConnection Archive in SoAdmin.
keywords:
  - "archive"
  - "provider"
  - "archive provider"
  - "QuoteConnection"
so.generated: true
so.date: 23.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "QuoteConnection"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.QuoteConnectionProvider">SuperOffice.CRM.ArchiveLists.QuoteConnectionProvider</see> inside NetServer's SODatabase assembly.

This is the archive Provider for the QuoteConnection Archive in SoAdmin.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"quoteConnection"|ERP connections|
|"deleted"|Deleted|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|quoteConnectionId|int|DB-ID: Database ID| x |
|deleted|bool|Deleted: Column showing if the ERP connection has been marked as deleted| x |
|allAccess|bool|Unrestricted: There are no access restrictions on this ERP connection| x |
|erpName|int|ERP name: Name of ERP system| x |
|displayName|string|Name: Localized display name| x |
|displayDescription|string|Description: Describes the connection in more detail.| x |
|connectorName|string|Quote Connector name: Name of Quote Connector module. Defined by the developer of the module.| x |
|extraData|string|Extra data: XML encoded data.| x |
|updatedBy|associate|Updated by: The user who last updated the data| x |
|updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|registeredBy|associate|Registered by: The user who registered the data| x |
|registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|erpConnection/id|int|ERP connections - Connection ID: Database key for an ERP connection|  |
|erpConnection/name|string|ERP connections - Name: Name of the ERP connection in the CRM system|  |
|erpConnection/description|string|ERP connections - Description: The description of the ERP connection in the CRM system|  |
|erpConnection/active|bool|ERP connections - Active: Is the ERP connection currently active?|  |
|erpConnection/erpId|string|ERP connections - ERP ID: The global unique ID of this ERP connection, as used by the Sync Connector|  |
|erpConnection/mostRecent|string|ERP connections - Timestamp: The timestamp of the most recent synchronization on this ERP connection|  |
|erpConnection/allAccess|bool|ERP connections - Unrestricted: There are no access restrictions on this ERP connection|  |
|erpConnection/deleted|bool|ERP connections - Deleted: Column showing if the ERP connection has been marked as deleted|  |
|erpConnection/updatedBy|associate|ERP connections - Updated by: The user who last updated the data| x |
|erpConnection/updatedDate|date|ERP connections - Updated: The date/time the data was last updated in UTC.| x |
|erpConnection/registeredBy|associate|ERP connections - Registered by: The user who registered the data| x |
|erpConnection/registeredDate|date|ERP connections - Registered date: The date/time the data was registered in UTC.| x |
|erpConnection/connector/id|stringorPK|ERP connections - Connection ID: Database key for an ERP connection| x |
|erpConnection/connector/url|string|ERP connections - URL of Sync Connector: The URL to the location where the Sync Connector is installed| x |
|erpConnection/connector/name|string|ERP connections - Name: Name of the ERP connection in the CRM system| x |
|erpConnection/connector/updatedBy|associate|ERP connections - Updated by: The user who last updated the data| x |
|erpConnection/connector/updatedDate|date|ERP connections - Updated: The date/time the data was last updated in UTC.| x |
|erpConnection/connector/registeredBy|associate|ERP connections - Registered by: The user who registered the data| x |
|erpConnection/connector/registeredDate|date|ERP connections - Registered date: The date/time the data was registered in UTC.| x |

## Sample

```http!
GET /api/v1/archive/QuoteConnection?$select=displayDescription,updatedDate,erpConnection/description
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

