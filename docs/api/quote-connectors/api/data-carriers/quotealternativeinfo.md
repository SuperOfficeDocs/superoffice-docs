---
title: quote_connector_carrier_quotealternativeinfo
description: ERP Quote Connector Interface data carrier - QuoteAlternativeInfo
author: {github-id}
so.date:
keywords: quote
so.topic: reference
---

# QuoteAlternativeInfo

![27][img2]

Quote Version is made up of one or more Alternatives. One of 1..n possible alternatives in a Quote Version.

The reason we have alternatives is that a quote can say to a customer, "we can solve you problem in two (or more) different ways, with different technology and side effects (and price)".

An Alternative may have discounts on the total amount. The Alternative tracks whether the user on the order level entered the Discount %, the Discount amount, the Earning%, Earning amount or the TotalPrice fields so that the discount and earning and total can be re-calculated correctly when Quote Lines are added or changed.

## int QuoteAlternativeId

Primary key to the Alternative in the CRM system.

## string ERPQuoteAlternativeKey

Key that identifies this alternative in the ERP system, if it exists there.

## int QuoteVersionId

The version that owns this alternative (the chain is Sale 1->1 Quote 1->+ QuoteVersion 1->+ QuoteAlternative.

## string Name

Name of Alternative. Shown in tab in user interface.

## string Description

The tool-tip to use in the user interface (on the tab, for instance).

## QuoteStatus Status

If there was a problem with for instance calculation, this field is set to warning or error.

## string Reason

If there was a problem, this field contains a localized explanation of the problem and possible steps to fix it that the user can be shown.

## double  ERPDiscountPercent

The discount the system calculates based on customer /amount / whatever. Can be overridden by the salesman in the field ‘DiscountPercent’ or ‘DiscountAmount’.

Both the two ‘ERPDiscountPercent’ and ‘ERPDiscountAmount’ shall be filled out.

If UserValueOverride is 'None', then the ERPDiscountAmount shall be copied into DiscountAmount and ERPDiscountPercent into DiscountPercent.
   The Percentage is given in percent form, i.e. ‘12%’ is represented as ‘12’.

## double  ERPDiscountAmount

The discount the system calculates based on customer /amount / whatever. Can be overridden by the user in the field ‘DiscountPercent’ or ‘DiscountAmount’.

Both the two ‘ERPDiscountPercent’ and ‘ERPDiscountAmount’ shall be filled out.

If UserValueOverride is 'None', then the ERPDiscountAmount shall be copied into DiscountAmount and ERPDiscountPercent into DiscountPercent.

## double DiscountPercent

The discount the salesman specifies, in percent.

Both the two ‘DiscountPercent’ and ‘DiscountAmount’ shall be filled out, but the UserValueOverride field must be set to the field the user actually changed.

* If this field is filled out by the user, it overrides the discount suggested by the connector.
* If the user has not filled any values, the system will copy the ERP discount % value into this field.

The Percentage is given in percent form, i.e. ‘12%’ is represented as ‘12’.

## double DiscountAmount

The discount the salesman specifies, in whatever currency the sale is in.

Both the two ‘DiscountPercent’ and ‘DiscountAmount’ shall be filled out, but the UserValueOverride field must be set to the field the user actually changed.

* If this field is filled out by the user, it overrides the discount suggested by the connector.
* If the user has not filled any values, the system will copy the ERP discount amount value into this field.

## ValueOverrideInfo UserValueOverride

Has the pre-calculated (from ERP) price information been overridden, and how.

If the user has filled out the discountpercentage field, then the UserValueOverride field is set to OverridePercent.
(The DiscountAmount, EarningPercent, EarningAmount and TotalPrice fields are calculated based on the discountPercent.)

## string VATInfo

Extra info about VAT that the connector might insert.

This is just to help out the layout of the quote in a document.

In this field we store VAT info that needs to be printed out on the quote, like "Inc VAT" or "12% VAT".

May or may not be filled out.

## double VAT

Tax/VAT if available from ERP system; not used in any business logic.

This is just to help out the layout of the quote in a document, but SuperOffice will not try to calculate this value.

May or may not be filled out.

## double EarningAmount

Earning on this alternative, as an absolute amount (in money).

## double EarningPercent

The earning on this alternative, in percent of total.

The Percentage is given in percent form, i.e. ‘12%’ is represented as ‘12’.

## double SubTotal

The sum of the quotelines totalPrice (and not the sum of their subtotal!!).

Think of it as sum before discount.

## double TotalPrice

Sum of the QuoteLines.TotalPrice - AlternativeDiscount or QuoteLines.TotalCost + Earning
based on what, if anything, the user has entered last.

Shall be calculated by the connector.

## string ExtraField1

Optional information added by Quote Connector; usable in the quote document merge process.

## string ExtraField2

Optional information added by Quote Connector; usable in the quote document merge process.

## string ExtraField3

Optional information added by Quote Connector; usable in the quote document merge process.

## string ExtraField4

Optional information added by Quote Connector; usable in the quote document merge process.

## string ExtraField5

Optional information added by Quote Connector; usable in the quote document merge process.

Quote Alternative Discounts/Earning

Each quote line can have a discount applied. A quote alternative (a set of quote lines) can have a separate discount applied - depending on a company policy preference.

![28][img2]

The discount on the whole quote alternative works much like the discounts on the quote.

The ERP system can suggest a discount (either Percent or a fixed amount) and the user can override the suggestion.

Cost + Earning = SubTotal - Discount = TotalPrice

Another way to set the discount is to set the earning! Since Cost + Earning = TotalPrice and Discount = SubTotal | TotalPrice.

This means that if you set any of the fields:

* DiscountAmount

* DiscountPercent

* EarningAmount

* EarningPercent

* TotalPrice

Then the other 4 values will be adjusted accordingly.

The QuoteCalculation helper class in the plug-in DLL can help you handle the different methods of calculating totals and discounts.

<!-- Referenced images -->
[img2]: media/image027.jpg
[img3]: media/image028.png