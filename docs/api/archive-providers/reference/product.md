---
uid: Product
title: Product
description: This is the archive Provider for the Product Archive is SoAdmin.
keywords:
  - "archive"
  - "provider"
  - "archive provider"
so.generated: true
so.date: 18.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "Product"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.ProductProvider">SuperOffice.CRM.ArchiveLists.ProductProvider</see> inside NetServer's SODatabase assembly.

This is the archive Provider for the Product Archive is SoAdmin.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"productInAssortment"|Products|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|inAssortment|bool|In assortment : Is the product in the currently available assortment?| x |
|productId|int|Database ID: A unique ID of the product| x |
|priceListId|int|Price list ID : The database ID of the price list that the product is a part of.| x |
|erpProductKey|string|ERP product key: The product key identifying the product in the ERP system| x |
|name|string|Name: The name of the product that is being offered.  This name can be changed to accommodate the customer's needs.| x |
|description|string|Description: Description of the product that is offered| x |
|code|string|Code: The product or article code. This code is created to help you quickly find products you offer regularly.| x |
|quantityUnit| *None* |Unit: The unit of the product that is offered.| x |
|priceUnit| *None* |Price unit: What is the price unit defined in| x |
|subscriptionUnit|string|Subscription unit: Unit the subscription is sold/renewed in, such as year/quarter/month| x |
|defaultSubscriptionQuantity|decimal|Subscription Quantity: Default number of subscription units to be used when adding this product to a quote| x |
|isSubscription|bool|Subscription: Is this a subscription product? If yes, then the subscription unit and amount fields will be shown| x |
|itemNumber|string|Item number: The item number in a hierarchy.| x |
|url|string|Web address: The web address of the product info.| x |
|productCategoryKey|listAny|Product category: The category the product is defined in| x |
|productFamilyKey|listAny|Product family: The family the product is defined in| x |
|productTypeKey|listAny|Product type: The type of product| x |
|vatInfo|string|VAT info: | x |
|vat|decimal|VAT: May be filled out by the ERP system| x |
|cost|decimal|Cost: Cost per item.| x |
|minimumPrice|decimal|Unit minimum price: Minimum price per item. Users are not allowed to send quotes with prices lower than the minimum price.| x |
|listPrice|decimal|List price: List price of a unit| x |
|thumbnail| *None* |Thumbnail: A miniature version of the product picture|  |
|updatedBy|associate|Updated by: The user who last updated the data| x |
|updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|registeredBy|associate|Registered by: The user who registered the data| x |
|registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|extraField1|string|Extra field 1: Extra field 1 used by ERP system| x |
|extraField2|string|Extra field 2: Extra field 2 used by ERP system| x |
|extraField3|string|Extra field 3: Extra field 3 used by ERP system| x |
|extraField4|string|Extra field 4: Extra field 4 used by ERP system| x |
|extraField5|string|Extra field 5: Extra field 5 used by ERP system| x |
|extraInfo|string|Extra info: Extra info| x |
|supplier|string|Supplier: Supplier company| x |
|supplierCode|string|Supplier's code: Supplier's code for the product.| x |
|priceList/priceListId|int|Price list - Price list ID: The database ID of the price list that the product is a part of.| x |
|priceList/erpPriceListKey|string|Price list - ERP product key: The product key identifying the product in the ERP system| x |
|priceList/name|string|Price list - Name: The name of the product that is being offered.  This name can be changed to accommodate the customer's needs.| x |
|priceList/description|string|Price list - Description: Description of the product that is offered| x |
|priceList/quoteConnection|listAny|Price list - ERP connection| x |
|priceList/currency|listAny|Price list - Currency: The currency of the sale| x |
|priceList/validFrom|date|Price list - Valid from: Price list is valid from this date| x |
|priceList/validTo|date|Price list - Valid to: Price list is valid until this date| x |
|priceList/isERPCopy|bool|Price list - Is ERP copy?: Is the price list copied from ERP?| x |
|priceList/isActive|bool|Price list - Active?: Is the price list active?| x |
|priceList/updatedBy|associate|Price list - Updated by: The user who last updated the data| x |
|priceList/updatedDate|date|Price list - Updated: The date/time the data was last updated in UTC.| x |
|priceList/registeredBy|associate|Price list - Registered by: The user who registered the data| x |
|priceList/registeredDate|date|Price list - Registered date: The date/time the data was registered in UTC.| x |

## Sample

```http!
GET /api/v1/archive/Product?$select=priceList/updatedDate,productFamilyKey,updatedBy
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

