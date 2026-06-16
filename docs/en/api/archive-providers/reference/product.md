---
uid: Product
title: Product
description: This is the archive Provider for the Product Archive is SoAdmin.
keywords: Product archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "Product"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.ProductProvider">SuperOffice.CRM.ArchiveLists.ProductProvider</see> inside NetServer's SODatabase assembly.

This is the archive Provider for the Product Archive is SoAdmin.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"productInAssortment"|[[SR_PRODUCT_PLURAL_PRODUCTS]]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|inAssortment|bool|SR\_QUOTE\_QUOTELINE\_INASSORTMENT: SR\_QUOTE\_QUOTELINE\_INASSORTMENT\_TOOLTIP| x |
|productId|int|SR\_PRODUCT\_PRODUCTID: SR\_PRODUCT\_PRODUCTID\_TOOLTIP| x |
|priceListId|int|SR\_QUOTE\_QUOTELINE\_PRICELISTID: SR\_QUOTE\_QUOTELINE\_PRICELISTID\_TOOLTIP| x |
|erpProductKey|string|SR\_QUOTE\_QUOTELINE\_ERPPRODUCTKEY: SR\_QUOTE\_QUOTELINE\_ERPPRODUCTKEY\_TOOLTIP| x |
|name|string|SR\_QUOTE\_QUOTELINE\_NAME: SR\_QUOTE\_QUOTELINE\_NAME\_TOOLTIP| x |
|description|string|SR\_QUOTE\_QUOTELINE\_DESCRIPTION: SR\_QUOTE\_QUOTELINE\_DESCRIPTION\_TOOLTIP| x |
|code|string|SR\_QUOTE\_QUOTELINE\_CODE: SR\_QUOTE\_QUOTELINE\_CODE\_TOOLTIP| x |
|quantityUnit| *None* |SR\_QUOTE\_QUOTELINE\_UNIT: SR\_QUOTE\_QUOTELINE\_UNIT\_TOOLTIP| x |
|priceUnit| *None* |SR\_QUOTE\_QUOTELINE\_PRICEUNIT: SR\_QUOTE\_QUOTELINE\_PRICEUNIT\_TOOLTIP| x |
|subscriptionUnit|string|SR\_QUOTE\_QUOTELINE\_SUBSCRIPTIONUNIT: SR\_QUOTE\_QUOTELINE\_SUBSCRIPTIONUNIT\_TOOLTIP| x |
|defaultSubscriptionQuantity|decimal|SR\_QUOTE\_PRODUCT\_DEFAULTSUBSCRIPTIONQUANTITY: SR\_QUOTE\_PRODUCT\_DEFAULTSUBSCRIPTIONQUANTITY\_TOOLTIP| x |
|isSubscription|bool|SR\_QUOTE\_QUOTELINE\_ISSUBSCRIPTION: SR\_QUOTE\_QUOTELINE\_ISSUBSCRIPTION\_TOOLTIP| x |
|itemNumber|string|SR\_QUOTE\_QUOTELINE\_ITEMNUMBER: SR\_QUOTE\_QUOTELINE\_ITEMNUMBER\_TOOLTIP| x |
|url|string|SR\_QUOTE\_QUOTELINE\_URL: SR\_QUOTE\_QUOTELINE\_URL\_TOOLTIP| x |
|productCategoryKey|listAny|SR\_QUOTE\_QUOTELINE\_PRODUCTCATEGORYKEY: SR\_QUOTE\_QUOTELINE\_PRODUCTCATEGORYKEY\_TOOLTIP| x |
|productFamilyKey|listAny|SR\_QUOTE\_QUOTELINE\_PRODUCTFAMILYKEY: SR\_QUOTE\_QUOTELINE\_PRODUCTFAMILYKEY\_TOOLTIP| x |
|productTypeKey|listAny|SR\_QUOTE\_QUOTELINE\_PRODUCTTYPEKEY: SR\_QUOTE\_QUOTELINE\_PRODUCTTYPEKEY\_TOOLTIP| x |
|vatInfo|string|SR\_QUOTE\_QUOTELINE\_VATINFO: SR\_QUOTE\_QUOTELINE\_VATINFO\_TOOLTIP| x |
|vat|decimal|SR\_QUOTE\_QUOTELINE\_VAT: SR\_QUOTE\_QUOTELINE\_VAT\_TOOLTIP| x |
|cost|decimal|SR\_QUOTE\_QUOTELINE\_UNITCOST: SR\_QUOTE\_QUOTELINE\_UNITCOST\_TOOLTIP| x |
|minimumPrice|decimal|SR\_QUOTE\_QUOTELINE\_UNITMINIMUMPRICE: SR\_QUOTE\_QUOTELINE\_UNITMINIMUMPRICE\_TOOLTIP| x |
|listPrice|decimal|SR\_QUOTE\_QUOTELINE\_UNITLISTPRICE: SR\_QUOTE\_QUOTELINE\_UNITLISTPRICE\_TOOLTIP| x |
|thumbnail| *None* |SR\_QUOTE\_QUOTELINE\_THUMBNAIL: SR\_QUOTE\_QUOTELINE\_THUMBNAIL\_TOOLTIP|  |
|updatedBy|associate|SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|updatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|registeredBy|associate|SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|registeredDate|date|SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|extraField1|string|SR\_QUOTE\_QUOTELINE\_EXTRAFIELD1: SR\_QUOTE\_QUOTELINE\_EXTRAFIELD1\_TOOLTIP| x |
|extraField2|string|SR\_QUOTE\_QUOTELINE\_EXTRAFIELD2: SR\_QUOTE\_QUOTELINE\_EXTRAFIELD2\_TOOLTIP| x |
|extraField3|string|SR\_QUOTE\_QUOTELINE\_EXTRAFIELD3: SR\_QUOTE\_QUOTELINE\_EXTRAFIELD3\_TOOLTIP| x |
|extraField4|string|SR\_QUOTE\_QUOTELINE\_EXTRAFIELD4: SR\_QUOTE\_QUOTELINE\_EXTRAFIELD4\_TOOLTIP| x |
|extraField5|string|SR\_QUOTE\_QUOTELINE\_EXTRAFIELD5: SR\_QUOTE\_QUOTELINE\_EXTRAFIELD5\_TOOLTIP| x |
|extraInfo|string|SR\_QUOTE\_QUOTELINE\_EXTRAINFO: SR\_QUOTE\_QUOTELINE\_EXTRAINFO\_TOOLTIP| x |
|supplier|string|SR\_QUOTE\_QUOTELINE\_SUPPLIER: SR\_QUOTE\_QUOTELINE\_SUPPLIER\_TOOLTIP| x |
|supplierCode|string|SR\_QUOTE\_QUOTELINE\_SUPPLIERCODE: SR\_QUOTE\_QUOTELINE\_SUPPLIERCODE\_TOOLTIP| x |
|priceList/priceListId|int|SR\_PRODUCT\_LABEL\_PRICELIST - SR\_QUOTE\_QUOTELINE\_PRICELISTID: SR\_QUOTE\_QUOTELINE\_PRICELISTID\_TOOLTIP| x |
|priceList/erpPriceListKey|string|SR\_PRODUCT\_LABEL\_PRICELIST - SR\_QUOTE\_QUOTELINE\_ERPPRODUCTKEY: SR\_QUOTE\_QUOTELINE\_ERPPRODUCTKEY\_TOOLTIP| x |
|priceList/name|string|SR\_PRODUCT\_LABEL\_PRICELIST - SR\_QUOTE\_QUOTELINE\_NAME: SR\_QUOTE\_QUOTELINE\_NAME\_TOOLTIP| x |
|priceList/description|string|SR\_PRODUCT\_LABEL\_PRICELIST - SR\_QUOTE\_QUOTELINE\_DESCRIPTION: SR\_QUOTE\_QUOTELINE\_DESCRIPTION\_TOOLTIP| x |
|priceList/quoteConnection|listAny|SR\_PRODUCT\_LABEL\_PRICELIST - SR\_QUOTE\_ERP\_CONNECTION| x |
|priceList/currency|listAny|SR\_PRODUCT\_LABEL\_PRICELIST - SR\_ARCHIVE\_SALE\_CURRENCY: SR\_SALE\_CURRENCY\_TOOLTIP| x |
|priceList/validFrom|date|SR\_PRODUCT\_LABEL\_PRICELIST - SR\_PRICELIST\_VALIDFROM: SR\_PRICELIST\_VALIDFROM\_TOOLTIP| x |
|priceList/validTo|date|SR\_PRODUCT\_LABEL\_PRICELIST - SR\_PRICELIST\_VALIDTO: SR\_PRICELIST\_VALIDTO\_TOOLTIP| x |
|priceList/isERPCopy|bool|SR\_PRODUCT\_LABEL\_PRICELIST - SR\_PRICELIST\_ISERPCOPY: SR\_PRICELIST\_ISERPCOPY\_TOOLTIP| x |
|priceList/isActive|bool|SR\_PRODUCT\_LABEL\_PRICELIST - SR\_PRICELIST\_ISACTIVE: SR\_PRICELIST\_ISACTIVE\_TOOLTIP| x |
|priceList/updatedBy|associate|SR\_PRODUCT\_LABEL\_PRICELIST - SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|priceList/updatedDate|date|SR\_PRODUCT\_LABEL\_PRICELIST - SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|priceList/registeredBy|associate|SR\_PRODUCT\_LABEL\_PRICELIST - SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|priceList/registeredDate|date|SR\_PRODUCT\_LABEL\_PRICELIST - SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |

## Sample

```http!
GET /api/v1/archive/Product?$select=productFamilyKey,updatedBy
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

