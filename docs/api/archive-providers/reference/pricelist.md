---
uid: PriceList
title: PriceList
description: Archive of Pricelists - used by the web api.
keywords:
  - "archive"
  - "provider"
  - "archive provider"
  - "PriceList"
so.generated: true
so.date: 23.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "PriceList"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.PriceListProvider">SuperOffice.CRM.ArchiveLists.PriceListProvider</see> inside NetServer's SODatabase assembly.

Archive of Pricelists - used by the web api.
Lists all Pricelist in table.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"pricelist"|[pricelist]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|priceListId|int|Price list ID : The database ID of the price list that the product is a part of.| x |
|erpPriceListKey|string|ERP product key: The product key identifying the product in the ERP system| x |
|name|string|Name: The name of the product that is being offered.  This name can be changed to accommodate the customer's needs.| x |
|description|string|Description: Description of the product that is offered| x |
|quoteConnection|listAny|ERP connection| x |
|currency|listAny|Currency: The currency of the sale| x |
|validFrom|date|Valid from: Price list is valid from this date| x |
|validTo|date|Valid to: Price list is valid until this date| x |
|isERPCopy|bool|Is ERP copy?: Is the price list copied from ERP?| x |
|isActive|bool|Active?: Is the price list active?| x |
|updatedBy|associate|Updated by: The user who last updated the data| x |
|updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|registeredBy|associate|Registered by: The user who registered the data| x |
|registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |

## Sample

```http!
GET /api/v1/archive/PriceList?$select=description,validFrom
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

