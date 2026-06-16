---
uid: ErpConnector
title: ErpConnector
description: Archive of ERP Connectors, used by the ERP Integrator Server
keywords: ErpConnector archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "ErpConnector"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.ErpConnectorProvider">SuperOffice.CRM.ArchiveLists.ErpConnectorProvider</see> inside NetServer's SODatabase assembly.

Archive of ERP Connectors, used by the ERP Integrator Server

## Supported Entities
| Name | Description |
| ---- | ----- |
|"erpConnector"|[[SR_ERPCONN_CONNECTORS]]|
|"deleted"|[[SR_ARCHIVE_DELETED]]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|id|stringorPK|SR\_ERPCONN\_ID: SR\_ERPCONN\_ID\_TOOLTIP| x |
|url|string|SR\_ERPCONN\_URL: SR\_ERPCONN\_URL\_TOOLTIP| x |
|name|string|SR\_ERPCONN\_NAME: SR\_ERPCONN\_NAME\_TOOLTIP| x |
|updatedBy|associate|SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|updatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|registeredBy|associate|SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|registeredDate|date|SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |

## Sample

```http!
GET /api/v1/archive/ErpConnector?$select=url,name
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

