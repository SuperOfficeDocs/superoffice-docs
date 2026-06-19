---
uid: ErpConnection
title: ErpConnection
description: Archive of ERP Connections, used by the ERP Integration Server
keywords: ErpConnection archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "ErpConnection"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.ErpConnectionProvider">SuperOffice.CRM.ArchiveLists.ErpConnectionProvider</see> inside NetServer's SODatabase assembly.

Archive of ERP Connections, used by the ERP Integration Server

## Supported Entities
| Name | Description |
| ---- | ----- |
|"erpConnection"|[[SR_ERPCONN_CONNECTIONS]]|
|"deleted"|[[SR_ARCHIVE_DELETED]]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|id|int|SR\_ERPCONN\_ID: SR\_ERPCONN\_ID\_TOOLTIP|  |
|name|string|SR\_ERPCONN\_NAME: SR\_ERPCONN\_NAME\_TOOLTIP|  |
|description|string|SR\_ERPCONN\_DESCRIPTION: SR\_ERPCONN\_DESCRIPTION\_TOOLTIP|  |
|active|bool|SR\_ERPCONN\_ACTIVE: SR\_ERPCONN\_ACTIVE\_TOOLTIP|  |
|erpId|string|SR\_ERPCONN\_ERPID: SR\_ERPCONN\_ERPID\_TOOLTIP|  |
|mostRecent|string|SR\_ERPCONN\_MOSTRECENT: SR\_ERPCONN\_MOSTRECENT\_TOOLTIP|  |
|allAccess|bool|SR\_ERPCONN\_ALLACCESS: SR\_ERPCONN\_ALLACCESS\_TOOLTIP|  |
|deleted|bool|SR\_ERPCONN\_CONNECTIONDELETED: SR\_ERPCONN\_CONNECTIONDELETED\_TOOLTIP|  |
|updatedBy|associate|SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|updatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|registeredBy|associate|SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|registeredDate|date|SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|connector/id|stringorPK|SR\_ERPCONN\_ID: SR\_ERPCONN\_ID\_TOOLTIP| x |
|connector/url|string|SR\_ERPCONN\_URL: SR\_ERPCONN\_URL\_TOOLTIP| x |
|connector/name|string|SR\_ERPCONN\_NAME: SR\_ERPCONN\_NAME\_TOOLTIP| x |
|connector/updatedBy|associate|SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|connector/updatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|connector/registeredBy|associate|SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|connector/registeredDate|date|SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |

## Sample

```http!
GET /api/v1/archive/ErpConnection?$select=mostRecent,updatedBy
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

