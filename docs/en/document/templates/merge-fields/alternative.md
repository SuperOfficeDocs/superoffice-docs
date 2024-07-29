---
uid: help-en-mergefield-alternative
title: Alternative (merge fields)
description: Alternative (merge fields)
keywords: quote template, merge field, quote field, quote alternative, quote, totalPrice, discountAmount, discountPercent, subTotal, vatAmount, VAT
author: Bergfrid Dias
date: 07.31.2024
version: 10.3
topic: reference
language: en
---

# Alternative (merge fields)

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
| alternative/subTotal | Sub total | Sum of all the quote lines' totalPrice, which is the same as alternative.totalPrice + alternative.discountAmount |
| alternative/sumDiscountAmount | Sum of discounts | Sum of all discounts in alternative |
| alternative/totalPrice | Total | Total price of all items in the quote alternative, including all discounts |
| alternative/totalPriceIncVAT | Total | Total price of all items in the quote alternative, including all discounts and VAT |
| alternative/vat | VAT | Value-added and other tax, total amount |
| alternative/vatAmount | VAT | Value-added and other tax, total amount. The quote line VAT field is interpreted as a percentage  and used to calculate from the line-total |
| alternative/vatInfo | VAT Info | Information about value-added and other taxes |
