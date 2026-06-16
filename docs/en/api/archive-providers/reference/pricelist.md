---
uid: PriceList
title: PriceList
description: Archive of Pricelists - used by the web api.
keywords: PriceList archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "PriceList"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.PriceListProvider">SuperOffice.CRM.ArchiveLists.PriceListProvider</see> inside NetServer's SODatabase assembly.

Archive of Pricelists - used by the web api.
Lists all Pricelist in table.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"pricelist"|pricelist|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|priceListId|int|SR\_QUOTE\_QUOTELINE\_PRICELISTID: SR\_QUOTE\_QUOTELINE\_PRICELISTID\_TOOLTIP| x |
|erpPriceListKey|string|SR\_QUOTE\_QUOTELINE\_ERPPRODUCTKEY: SR\_QUOTE\_QUOTELINE\_ERPPRODUCTKEY\_TOOLTIP| x |
|name|string|SR\_QUOTE\_QUOTELINE\_NAME: SR\_QUOTE\_QUOTELINE\_NAME\_TOOLTIP| x |
|description|string|SR\_QUOTE\_QUOTELINE\_DESCRIPTION: SR\_QUOTE\_QUOTELINE\_DESCRIPTION\_TOOLTIP| x |
|quoteConnection|listAny|SR\_QUOTE\_ERP\_CONNECTION| x |
|currency|listAny|SR\_ARCHIVE\_SALE\_CURRENCY: SR\_SALE\_CURRENCY\_TOOLTIP| x |
|validFrom|date|SR\_PRICELIST\_VALIDFROM: SR\_PRICELIST\_VALIDFROM\_TOOLTIP| x |
|validTo|date|SR\_PRICELIST\_VALIDTO: SR\_PRICELIST\_VALIDTO\_TOOLTIP| x |
|isERPCopy|bool|SR\_PRICELIST\_ISERPCOPY: SR\_PRICELIST\_ISERPCOPY\_TOOLTIP| x |
|isActive|bool|SR\_PRICELIST\_ISACTIVE: SR\_PRICELIST\_ISACTIVE\_TOOLTIP| x |
|updatedBy|associate|SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|updatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|registeredBy|associate|SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|registeredDate|date|SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |

## Sample

```http!
GET /api/v1/archive/PriceList?$select=description,validFrom
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

