---
uid: QuoteLine
title: QuoteLine
description: This is the archive Provider for the QuoteLine Archive.
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

# "QuoteLine"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.QuoteLineProvider">SuperOffice.CRM.ArchiveLists.QuoteLineProvider</see> inside NetServer's SODatabase assembly.

This is the archive Provider for the QuoteLine Archive.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"quoteLineIsIncluded"|Products|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|quoteLineId|int|Quote line ID: Database identity of the quote line| x |
|quoteAlternativeId|int|Alternative ID: The database identity of the quote alternative| x |
|erpProductKey|string|Product key: The foreign key of the product the quote line is based on.| x |
|rank|int|Rank: Shows the rank of a product| x |
|quantity|decimal|Quantity: The quantity that is offered| x |
|name|string|Name: The name of the product that is being offered.  This name can be changed to accommodate the customer's needs.| x |
|description|string|Description: Description of the product that is offered| x |
|code|string|Code: The product or article code. This code is created to help you quickly find products you offer regularly.| x |
|quantityUnit|string|Unit: The unit of the product that is offered.| x |
|priceUnit|string|Price unit: What is the price unit defined in| x |
|url|string|Web address: The web address of the product info.| x |
|subscriptionUnit|string|Subscription unit: Unit the subscription is sold/renewed in, such as year/quarter/month| x |
|subscriptionQuantity|decimal|Subscription quantity: Number of subscription units offered| x |
|UnitListPriceSubscriptionQuantity| *None* |Subscription list price: Unit price * subscription quantity|  |
|PriceUnitSubscriptionUnit| *None* |P/S Unit: Price unit/subscription unit|  |
|PriceUnitSubscriptionQuantityUnit| *None* |Expanded unit: Price unit @ subscription quantity + unit|  |
|vatInfo|string|VAT info: | x |
|vat|decimal|VAT: May be filled out by the ERP system| x |
|unitCost|decimal|Cost: Cost per item.| x |
|unitMinimumPrice|decimal|Unit minimum price: Minimum price per item. Users are not allowed to send quotes with prices lower than the minimum price.| x |
|unitListPrice|decimal|List price: List price of a unit| x |
|totalPrice|decimal|Total: List price * Quantity - Discount Amount| x |
|totalCost|decimal|Total cost|  |
|quoteLineThumbnail| *None* |Thumbnail: A miniature version of the product picture|  |
|quoteLineThumbnailLarge| *None* |Thumbnail: A miniature version of the product picture|  |
|discountAmount|decimal|Discount: Discount amount given by salesperson| x |
|discountPercent|decimal|Discount (%: Discount percent given by salesperson| x |
|earningAmount|decimal|Earnings: Amount of Earnings (Total - Cost) on the line, after discount| x |
|earningPercent|decimal|Earnings (%: Percentage Earnings on the line (Total - Cost / Total), after discount| x |
|updatedBy|associate|Updated by: The user who last updated the data| x |
|updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|registeredBy|associate|Registered by: The user who registered the data| x |
|registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|productCategoryKey|listExternal|Product category: The category the product is defined in|  |
|productFamilyKey|listExternal|Product family: The family the product is defined in|  |
|productTypeKey|listExternal|Product type: The type of product|  |
|status|listAny|Quote status: Status field showing the status of each line.| x |
|subTotal|decimal|Sum: Sum of Quantity * Unit list price| x |
|vatAmount|decimal|VAT (amount: The calculated VAT amount| x |
|totalPriceIncVAT|decimal|Total incl. VAT: Total including VAT| x |
|totalPriceWithAlternativeDiscount|decimal|Total incl. alt. disc: Total, including any discount percentage set on the alternative| x |

## Sample

```http!
GET /api/v1/archive/QuoteLine?$select=subscriptionQuantity,unitMinimumPrice
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

