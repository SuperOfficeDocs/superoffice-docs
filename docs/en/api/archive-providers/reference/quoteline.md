---
uid: QuoteLine
title: QuoteLine
description: This is the archive Provider for the QuoteLine Archive.
keywords: QuoteLine archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "QuoteLine"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.QuoteLineProvider">SuperOffice.CRM.ArchiveLists.QuoteLineProvider</see> inside NetServer's SODatabase assembly.

This is the archive Provider for the QuoteLine Archive.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"quoteLineIsIncluded"|[[SR_QUOTE_PLURAL_QUOTELINES]]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|quoteLineId|int|SR\_QUOTE\_QUOTELINE\_QUOTELINEID: SR\_QUOTE\_QUOTELINE\_QUOTELINEID\_TOOLTIP| x |
|quoteAlternativeId|int|SR\_QUOTE\_QUOTELINE\_QUOTEALTERNATIVEID: SR\_QUOTE\_QUOTELINE\_QUOTEALTERNATIVEID\_TOOLTIP| x |
|erpProductKey|string|SR\_QUOTE\_QUOTELINE\_PRODUCTKEY: SR\_QUOTE\_QUOTELINE\_PRODUCTKEY\_TOOLTIP| x |
|rank|int|SR\_QUOTE\_QUOTELINE\_RANK: SR\_QUOTE\_QUOTELINE\_RANK\_TOOLTIP| x |
|quantity|decimal|SR\_QUOTE\_QUOTELINE\_QUANTITY: SR\_QUOTE\_QUOTELINE\_QUANTITY\_TOOLTIP| x |
|name|string|SR\_QUOTE\_QUOTELINE\_NAME: SR\_QUOTE\_QUOTELINE\_NAME\_TOOLTIP| x |
|description|string|SR\_QUOTE\_QUOTELINE\_DESCRIPTION: SR\_QUOTE\_QUOTELINE\_DESCRIPTION\_TOOLTIP| x |
|code|string|SR\_QUOTE\_QUOTELINE\_CODE: SR\_QUOTE\_QUOTELINE\_CODE\_TOOLTIP| x |
|quantityUnit|string|SR\_QUOTE\_QUOTELINE\_UNIT: SR\_QUOTE\_QUOTELINE\_UNIT\_TOOLTIP| x |
|priceUnit|string|SR\_QUOTE\_QUOTELINE\_PRICEUNIT: SR\_QUOTE\_QUOTELINE\_PRICEUNIT\_TOOLTIP| x |
|url|string|SR\_QUOTE\_QUOTELINE\_URL: SR\_QUOTE\_QUOTELINE\_URL\_TOOLTIP| x |
|subscriptionUnit|string|SR\_QUOTE\_QUOTELINE\_SUBSCRIPTIONUNIT: SR\_QUOTE\_QUOTELINE\_SUBSCRIPTIONUNIT\_TOOLTIP| x |
|subscriptionQuantity|decimal|SR\_QUOTE\_QUOTELINE\_SUBSCRIPTIONQUANTITY: SR\_QUOTE\_QUOTELINE\_SUBSCRIPTIONQUANTITY\_TOOLTIP| x |
|UnitListPriceSubscriptionQuantity| *None* |SR\_SUBSCRIPTIONLISTPRICE: SR\_SUBSCRIPTIONLISTPRICE\_TOOLTIP|  |
|PriceUnitSubscriptionUnit| *None* |SR\_PRICESUBUNIT: SR\_PRICESUBUNIT\_TOOLTIP|  |
|PriceUnitSubscriptionQuantityUnit| *None* |SR\_EXPANDEDUNIT: SR\_EXPANDEDUNIT\_TOOLTIP|  |
|vatInfo|string|SR\_QUOTE\_QUOTELINE\_VATINFO: SR\_QUOTE\_QUOTELINE\_VATINFO\_TOOLTIP| x |
|vat|decimal|SR\_QUOTE\_QUOTELINE\_VAT: SR\_QUOTE\_QUOTELINE\_VAT\_TOOLTIP| x |
|unitCost|decimal|SR\_QUOTE\_QUOTELINE\_UNITCOST: SR\_QUOTE\_QUOTELINE\_UNITCOST\_TOOLTIP| x |
|unitMinimumPrice|decimal|SR\_QUOTE\_QUOTELINE\_UNITMINIMUMPRICE: SR\_QUOTE\_QUOTELINE\_UNITMINIMUMPRICE\_TOOLTIP| x |
|unitListPrice|decimal|SR\_QUOTE\_QUOTELINE\_UNITLISTPRICE: SR\_QUOTE\_QUOTELINE\_UNITLISTPRICE\_TOOLTIP| x |
|totalPrice|decimal|SR\_QUOTE\_QUOTELINE\_TOTALPRICE: SR\_QUOTE\_QUOTELINE\_TOTALPRICE\_TOOLTIP| x |
|totalCost|decimal|SR\_QUOTE\_QUOTEALTERNATIVE\_TOTALCOST|  |
|quoteLineThumbnail| *None* |SR\_QUOTE\_QUOTELINE\_THUMBNAIL: SR\_QUOTE\_QUOTELINE\_THUMBNAIL\_TOOLTIP|  |
|quoteLineThumbnailLarge| *None* |SR\_QUOTE\_QUOTELINE\_THUMBNAIL: SR\_QUOTE\_QUOTELINE\_THUMBNAIL\_TOOLTIP|  |
|discountAmount|decimal|SR\_QUOTE\_QUOTELINE\_DISCOUNTAMOUNT: SR\_QUOTE\_QUOTELINE\_DISCOUNTAMOUNT\_TOOLTIP| x |
|discountPercent|decimal|SR\_QUOTE\_QUOTELINE\_DISCOUNTPERCENT: SR\_QUOTE\_QUOTELINE\_DISCOUNTPERCENT\_TOOLTIP| x |
|earningAmount|decimal|SR\_QUOTE\_QUOTELINE\_EARNINGAMOUNT: SR\_QUOTE\_QUOTELINE\_EARNINGAMOUNT\_TOOLTIP| x |
|earningPercent|decimal|SR\_QUOTE\_QUOTELINE\_EARNINGPERCENT: SR\_QUOTE\_QUOTELINE\_EARNINGPERCENT\_TOOLTIP| x |
|updatedBy|associate|SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|updatedByFullName|associate|SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|updatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|registeredBy|associate|SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|registeredByFullName|associate|SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|registeredDate|date|SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|productCategoryKey|listExternal|SR\_QUOTE\_QUOTELINE\_PRODUCTCATEGORYKEY: SR\_QUOTE\_QUOTELINE\_PRODUCTCATEGORYKEY\_TOOLTIP|  |
|productFamilyKey|listExternal|SR\_QUOTE\_QUOTELINE\_PRODUCTFAMILYKEY: SR\_QUOTE\_QUOTELINE\_PRODUCTFAMILYKEY\_TOOLTIP|  |
|productTypeKey|listExternal|SR\_QUOTE\_QUOTELINE\_PRODUCTTYPEKEY: SR\_QUOTE\_QUOTELINE\_PRODUCTTYPEKEY\_TOOLTIP|  |
|status|listAny|SR\_QUOTE\_QUOTELINE\_QUOTESTATUS: SR\_QUOTE\_QUOTELINE\_QUOTESTATUS\_TOOLTIP| x |
|subTotal|decimal|SR\_QUOTE\_QUOTELINE\_SUBTOTAL: SR\_QUOTE\_QUOTELINE\_SUBTOTAL\_TOOLTIP| x |
|vatAmount|decimal|SR\_QUOTE\_QUOTELINE\_VATAMNT: SR\_QUOTE\_QUOTELINE\_VATAMNT\_TOOLTIP| x |
|totalPriceIncVAT|decimal|SR\_QUOTE\_QUOTELINE\_TOTINCVAT: SR\_QUOTE\_QUOTELINE\_TOTINCVAT\_TOOLTIP| x |
|totalPriceWithAlternativeDiscount|decimal|SR\_QUOTE\_QUOTELINE\_TOTINCALTDIS: SR\_QUOTE\_QUOTELINE\_TOTINCALTDIS\_TOOLTIP| x |

## Sample

```http!
GET /api/v1/archive/QuoteLine?$select=UnitListPriceSubscriptionQuantity,unitListPrice
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

