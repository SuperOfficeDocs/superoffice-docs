<!-- markdownlint-disable-file MD041 -->
| Merge field tag | Name | Description |
|---|---|---|
| line/code | Code | The product or article code. This code is created to help you quickly find products you offer regularly. |
| line/description | Description | Description of the product that is offered |
| line/discountAmount | Discount | Discount amount given by salesperson |
| line/discountPercent | Discount (%) | Discount percent given by salesperson |
| line/earningAmount | Earning | Amount of Earning (Total - Cost) on the line, after discount |
| line/earningPercent | Earning (%) | Percentage Earnings on the line (Total - Cost / Total), after discount |
| line/extraField1 | Extra field 1 | The installation-defined extra field 1 |
| line/extraField2 | Extra field 2 | The installation-defined extra field 2 |
| line/extraField3 | Extra field 3 | The installation-defined extra field 3 |
| line/extraField4 | Extra field 4 | The installation-defined extra field 4 |
| line/extraField5 | Extra field 5 | The installation-defined extra field 5 |
| line/isSubscription | Subscription? | Is this line a subscription line |
| line/itemNumber | Item number | Item number |
| line/name | Name | The name of the product that is being offered |
| line/priceUnit | Price unit | What is the price unit defined in |
| line/priceUnitSubscriptionQuantityUnit | Expanded unit | Price unit @ subscription quantity + unit |
| line/priceUnitSubscriptionUnit | P/S Unit | Price unit/subscription unit |
| line/productCategoryKey | Product category | The category the product is defined in |
| line/productFamilyKey | Product family | The family the product is defined in |
| line/productTypeKey | Product type | The type of product |
| line/quantity | Quantity | The amount that is offered |
| line/quantityUnit | Unit | The unit of the product that is offered. |
| line/quoteAlternativeId | Alternative ID | The database identity of the quote alternative |
| Image:line/quoteLineThumbnail | Thumbnail | A miniature version of the product picture – _*note the **Image:** prefix*, without it you will get a **lot** of funny letters and digits |
| line/rank | Rank | Shows the rank of a quote line |
| line/status | Quote status | Status field showing the status of each line. |
| line/subTotal | SubTotal | List price \* Quantity, and if the quote line is a subscription, we also multiply in the SubscriptionQuantity. |
| line/subscriptionQuantity | Subscription quantity | The quantity tied to the subscription unit, as opposed to the quantity tied to the price/sale units |
| line/subscriptionStart | Subscription start | Start date of subscription |
| line/subscriptionUnit | Subscription unit | Subscription lines have an additional unit, usually a time (month, week quarter etc.), so you can sell n tons / m months |
| line/supplier | Supplier | Supplier |
| line/supplierCode | Supplier code | Supplier code |
| line/totalPrice | Total | SubTotal - Discount Amount |
| line/totalPriceIncVAT | Total inc VAT | TotalPrice + VAT |
| line/totalPriceWithAlternativeDiscount | Total with alternative discount | TotalPrice \* (1 – (Alternative.DiscountPercent / 100)) |
| line/unitCost | Cost | Cost per item. |
| line/unitListPrice | Unit list price | List price of a unit |
| line/unitListPriceSubscriptionQuantity | Subscription unit list price | Unit price \* subscription quantity |
| line/unitMinimumPrice | Unit minimum price | Minimum price per item. Users are not allowed to send quotes with prices lower than the minimum price. |
| line/url | Web address | The web address of the product info. |
| line/vat | VAT | May be filled out by the ERP system. (Should be the VAT percentage, but can be the amount) |
| line/vatAmount | VAT | Will be the VAT amount |
| line/vatInfo | VAT info | |
