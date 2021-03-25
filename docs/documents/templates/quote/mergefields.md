---
title: 
description: Quote merge-field reference
author:
keywords:
so.topic: reference
so.date: 

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Quote merge-field reference

## Sale / Quote / Version

| Merge field tag | Name | Description |
|---|---|---|
| quote/contactDepartment | Sale - Owning department | Name of the department at the company the user belongs to |
| quote/contactName | Sale - Owning company | Name of the company the user belongs to |
| quote/currency | Sale – Currency | The currency of the sale |
| quote/description | Description | Description of the quote version |
| quote/expiration | Expiration | The last date that the quote is valid |
| quote/saleType | Sale – sale type | The sale type of the sale |
| quote/extraField1 | Extra field 1 | One of the extra fields on the product; meaning is installation dependent |
| quote/extraField2 | Extra field 2 | One of the extra fields on the product; meaning is installation dependent |
| quote/extraField3 | Extra field 3 | One of the extra fields on the product; meaning is installation dependent |
| quote/extraField4 | Extra field 4 | One of the extra fields on the product; meaning is installation dependent |
| quote/extraField5 | Extra field 5 | One of the extra fields on the product; meaning is installation dependent |
| quote/fullName | Sale - Full name | Displays full name of user (first, middle, last - according to settings) |
| quote/mrMrs | Sale - Mr/Ms | Displays whether the contact is addressed as Mr or Ms |
| quote/number | Number | Reference number for the quote version |
| quote/orderComment | Comment | Customer's comment |
| quote/paymentTerms | Payment terms | Payment terms |
| quote/paymentType | Payment type | Payment type |
| quote/deliveryTerms | Delivery terms | Delivery terms |
| quote/deliveryType | Delivery type | Delivery type |
| quote/approvedBy | Approved by | Associate who approved a Quote that broke one or more of the workflow rules that trigger an approval process |
| quote/approvalRegisteredBy | Approval reg by | Associate who entered the approval (not necessarily the one who approved!) of a Quote that broke one or more of the workflow rules that trigger an approval process |
| quote/approvedText | Approval comment | Comment added to the approval of a Quote that broke one or more of the workflow rules that trigger an approval process |
| quote/approvedDate | Approved date | Date of approval of a Quote that broke one or more of the workflow rules that trigger an approval process |
| quote/poNumber | P.O.Number | Customer's purchase order number |
| Image:quote/portraitThumbnail | Sale - Portrait | Portrait of sale’s associate – *note the **Image**: prefix*, without it you will get a **lot** of funny letters and digits |
| quote/quoteId | Quote ID | SuperOffice database id of quote record
| quote/quoteVersionId | ID | Database ID of QuoteVersion record |
| quote/saleAmount | Sale - Amount | The gross sales total |
| quote/saleDescription | Sale - Text | Displays the text entered in the description field |
| quote/saleEarning | Sale - Profit | Gross profit (gross sales total - cost) for the sale |
| quote/saleEarningPercent | Sale - Profit as %: | The profit as a percentage of the gross sales total |
| quote/saleHeading | Sale - Sale | Displays a descriptive text for the item |
| quote/saleNumber | Sale - Number | Number |
| quote/sent | Sent | Quote sent date |
| quote/title | Sale - Title | Displays whether the contact is addressed as Mr or Ms |

## Alternative

| Merge field tag | Name | Description |
|---|---|---|
| alternative/description | Description | Description of the quote alternative |
| alternative/discountAmount | Discount | Enter total discount for entire alternative |
| alternative/discountPercent | Discount % | Enter discount in percent for entire alternative |
| alternative/earningAmount | Earnings | Total Earning of all lines in the quote alternative, including all discounts |
| alternative/earningPercent | Earnings % | Total Earning as a percentage of the total price, of all lines in the quote alternative, including all discounts |
| alternative/erpDiscountAmount | ERP Discount | Discount amount suggested by ERP system |
| alternative/erpDiscountPercent | ERP Discount % | Discount percentage suggested by ERP system |
| alternative/extraField1 | Extra 1 | Extra field 1 on the quote alternative |
| alternative/extraField2 | Extra 2 | Extra field 2 on the quote alternative |
| alternative/extraField3 | Extra 3 | Extra field 3on the quote alternative |
| alternative/extraField4 | Extra 4 | Extra field 4 on the quote alternative |
| alternative/extraField5 | Extra 5 | Extra field 5 on the quote alternative |
| alternative/name | Name | Name of the quote alternative |
| alternative/numLines | Number of lines | Number of lines in alternative |
| alternative/quoteAlternativeId | QuoteAlternative ID | SuperOffice database ID of QuoteAlternative record |
| alternative/quoteVersionId | ID | Database ID of QuoteVersion record |
| alternative/sumDiscountAmount | Sum of discounts | Sum of all discounts in alternative |
| alternative/subTotal | Sub total | Sum of all the quotelines' Totalprice, which is the same as alternative.totalPrice + alternative.discountAmount |
| alternative/totalPrice | Total | Total price of all items in the quote alternative, including all discounts |
| alternative/vatInfo | VAT Info | Information about value-added and other taxes |
| alternative/vat | VAT | Value-added and other tax, total amount |
| alternative/vatAmount | VAT | Value-added and other tax, total amount. The quoteline VAT field is interpreted as a percentage  and used to calculate from the line-total |
| alternative/totalPriceIncVAT | Total | Total price of all items in the quote alternative, including all discounts and VAT |

### Group (user-selectable on Sale Type)

| Merge field tag | Name | Description |
|---|---|---|
| group/sumDiscountAmount | Sum of discounts | Sum of all discounts in the group |
| group/sumtotalPrice | Sum of price | Total price of all lines in the group |
| group/sumVat | Sum of VAT |Sum of VAT of all lines in the group |
| group/numLines | Number of lines | Number of lines in the group |
| group/groupField | Group field value | The value of whatever field has been designated the group field |

### Line

| Merge field tag | Name | Description |
|---|---|---|
| line/code | Code | The product or article code. This code is created to help you quickly find products you offer regularly. |
| line/description | Description | Description of the product that is offered |
| line/discountAmount | Discount | Discount amount given by salesperson |
| line/discountPercent | Discount (%) | Discount percent given by salesperson |
| line/earningAmount | Earning | Amount of Earning (Total - Cost) on the line, after discount |
| line/earningPercent | Earning (%) | Percentage Earnings on the line (Total - Cost / Total), after discount |
| line/name | Name | The name of the product that is being offered |
| line/priceUnit | Price unit | What is the price unit defined in |
| line/PriceUnitSubscriptionQuantityUnit | Expanded unit | Price unit @ subscription quantity + unit |
| line/PriceUnitSubscriptionUnit | P/S Unit | Price unit/subscription unit |
| line/productCategoryKey | Product category | The category the product is defined in |
| line/productFamilyKey | Product family | The family the product is defined in |
| line/productTypeKey | Product type | The type of product |
| line/quantity | Quantity | The amount that is offered |
| line/quantityUnit | Unit | The unit of the product that is offered. |
| line/quoteAlternativeId | Alternative ID | The database identity of the quote alternative |
| Image:line/quoteLineThumbnail | Thumbnail | A miniature version of the product picture – _*note the **Image:** prefix*, without it you will get a **lot** of funny letters and digits |
| line/rank | Rank | Shows the rank of a quote line |
| line/status | Quote status | Status field showing the status of each line. |
| line/subTotal | SubTotal | List price \* Quantity, and if the quoteline is a subscription, we also multiply in the SubscriptionQuantity. |
| line/totalPrice | Total | SubTotal - Discount Amount |
| line/totalPriceWithAlternativeDiscount | Total with alternative discount | TotalPrice \* (1 – (Alternative.DiscountPercent / 100)) |
| line/totalPriceIncVAT | Total inc VAT | TotalPrice + VAT |
| line/unitCost | Cost | Cost per item. |
| line/unitListPrice | Unit list price | List price of a unit |
| line/UnitListPriceSubscriptionQuantity | Subscription unit list price | Unit price \* subscription quantity |
| line/unitMinimumPrice | Unit minimum price | Minimum price per item. Users are not allowed to send quotes with prices lower than the minimum price. |
| line/url | Web address | The web address of the product info. |
| line/vatInfo | VAT info | |
| line/vat | VAT | May be filled out by the ERP system. (Should be the VAT percentage, but can be the amount) |
| line/vatAmount | VAT | Will be the VAT amount |
| line/supplier | Supplier | Supplier |
| line/supplierCode | Supplier code | Supplier code |
| line/isSubscription | Subscription? | Is this line a subscription line |
| line/subscriptionUnit | Subscription unit | Subscription lines have an additional unit, usually a time (month, week quarter etc.), so you can sell n tons / m months |
| line/subscriptionStart | Subscription start | Start date of subscription |
| line/subscriptionQuantity | Subscription quantity | The quantity tied to the subscription unit, as opposed to the quantity tied to the price/sale units |
| line/itemNumber | Item number | Item number |
| line/extraField1 | Extra field 1 | The installation-defined extra field 1 |
| line/extraField2 | Extra field 2 | The installation-defined extra field 2 |
| line/extraField3 | Extra field 3 | The installation-defined extra field 3 |
| line/extraField4 | Extra field 4 | The installation-defined extra field 4 |
| line/extraField5 | Extra field 5 | The installation-defined extra field 5 |
