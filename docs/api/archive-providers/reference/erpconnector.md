---
uid: ErpConnector
title: ErpConnector
description: Archive of ERP Connectors, used by the ERP Integrator Server
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

# "ErpConnector"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.ErpConnectorProvider">SuperOffice.CRM.ArchiveLists.ErpConnectorProvider</see> inside NetServer's SODatabase assembly.

Archive of ERP Connectors, used by the ERP Integrator Server

## Supported Entities
| Name | Description |
| ---- | ----- |
|"erpConnector"|Sync Connectors|
|"deleted"|Deleted|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|id|stringorPK|Connection ID: Database key for an ERP connection| x |
|url|string|URL of Sync Connector: The URL to the location where the Sync Connector is installed| x |
|name|string|Name: Name of the ERP connection in the CRM system| x |
|updatedBy|associate|Updated by: The user who last updated the data| x |
|updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|registeredBy|associate|Registered by: The user who registered the data| x |
|registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |

## Sample

```http!
GET /api/v1/archive/ErpConnector?$select=url,name
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

