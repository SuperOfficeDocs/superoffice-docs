---
uid: QuoteConnection
title: QuoteConnection
description: This is the archive Provider for the QuoteConnection Archive in SoAdmin.
keywords: QuoteConnection archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "QuoteConnection"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.QuoteConnectionProvider">SuperOffice.CRM.ArchiveLists.QuoteConnectionProvider</see> inside NetServer's SODatabase assembly.

This is the archive Provider for the QuoteConnection Archive in SoAdmin.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"quoteConnection"|[[SR_QUOTE_PLURAL_CONNECTIONS]]|
|"deleted"|[[SR_ARCHIVE_DELETED]]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|quoteConnectionId|int|SR\_QUOTE\_CONNECTIONID: SR\_QUOTE\_CONNECTIONID\_TOOLTIP| x |
|deleted|bool|SR\_QUOTE\_CONNECTIONDELETED: SR\_QUOTE\_CONNECTIONDELETED\_TOOLTIP| x |
|allAccess|bool|SR\_QUOTE\_CONNECTIONALLACCESS: SR\_QUOTE\_CONNECTIONALLACCESS\_TOOLTIP| x |
|erpName|int|SR\_QUOTE\_CONNECTIONERPNAME: SR\_QUOTE\_CONNECTIONERPNAME\_TOOLTIP| x |
|displayName|string|SR\_QUOTE\_CONNECTIONDISPLAYNAME: SR\_QUOTE\_CONNECTIONDISPLAYNAME\_TOOLTIP| x |
|displayDescription|string|SR\_QUOTE\_CONNECTIONDISPLAYDESCRIPTION: SR\_QUOTE\_CONNECTIONDISPLAYDESCRIPTION\_TOOLTIP| x |
|connectorName|string|SR\_QUOTE\_CONNECTIONCONNECTORNAME: SR\_QUOTE\_CONNECTIONCONNECTORNAME\_TOOLTIP| x |
|extraData|string|SR\_QUOTE\_CONNECTIONEXTRADATA: SR\_QUOTE\_CONNECTIONEXTRADATA\_TOOLTIP| x |
|updatedBy|associate|SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|updatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|registeredBy|associate|SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|registeredDate|date|SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|erpConnection/id|int|SR\_ERPCONN\_CONNECTIONS - SR\_ERPCONN\_ID: SR\_ERPCONN\_ID\_TOOLTIP|  |
|erpConnection/name|string|SR\_ERPCONN\_CONNECTIONS - SR\_ERPCONN\_NAME: SR\_ERPCONN\_NAME\_TOOLTIP|  |
|erpConnection/description|string|SR\_ERPCONN\_CONNECTIONS - SR\_ERPCONN\_DESCRIPTION: SR\_ERPCONN\_DESCRIPTION\_TOOLTIP|  |
|erpConnection/active|bool|SR\_ERPCONN\_CONNECTIONS - SR\_ERPCONN\_ACTIVE: SR\_ERPCONN\_ACTIVE\_TOOLTIP|  |
|erpConnection/erpId|string|SR\_ERPCONN\_CONNECTIONS - SR\_ERPCONN\_ERPID: SR\_ERPCONN\_ERPID\_TOOLTIP|  |
|erpConnection/mostRecent|string|SR\_ERPCONN\_CONNECTIONS - SR\_ERPCONN\_MOSTRECENT: SR\_ERPCONN\_MOSTRECENT\_TOOLTIP|  |
|erpConnection/allAccess|bool|SR\_ERPCONN\_CONNECTIONS - SR\_ERPCONN\_ALLACCESS: SR\_ERPCONN\_ALLACCESS\_TOOLTIP|  |
|erpConnection/deleted|bool|SR\_ERPCONN\_CONNECTIONS - SR\_ERPCONN\_CONNECTIONDELETED: SR\_ERPCONN\_CONNECTIONDELETED\_TOOLTIP|  |
|erpConnection/updatedBy|associate|SR\_ERPCONN\_CONNECTIONS - SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|erpConnection/updatedDate|date|SR\_ERPCONN\_CONNECTIONS - SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|erpConnection/registeredBy|associate|SR\_ERPCONN\_CONNECTIONS - SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|erpConnection/registeredDate|date|SR\_ERPCONN\_CONNECTIONS - SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|erpConnection/connector/id|stringorPK|SR\_ERPCONN\_CONNECTIONS - SR\_ERPCONN\_ID: SR\_ERPCONN\_ID\_TOOLTIP| x |
|erpConnection/connector/url|string|SR\_ERPCONN\_CONNECTIONS - SR\_ERPCONN\_URL: SR\_ERPCONN\_URL\_TOOLTIP| x |
|erpConnection/connector/name|string|SR\_ERPCONN\_CONNECTIONS - SR\_ERPCONN\_NAME: SR\_ERPCONN\_NAME\_TOOLTIP| x |
|erpConnection/connector/updatedBy|associate|SR\_ERPCONN\_CONNECTIONS - SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|erpConnection/connector/updatedDate|date|SR\_ERPCONN\_CONNECTIONS - SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|erpConnection/connector/registeredBy|associate|SR\_ERPCONN\_CONNECTIONS - SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|erpConnection/connector/registeredDate|date|SR\_ERPCONN\_CONNECTIONS - SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |

## Sample

```http!
GET /api/v1/archive/QuoteConnection?$select=updatedDate,erpConnection/description
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

