---
uid: enum-valueoverride
title: Enum values for ValueOverride
description: Lists the enum values for ValueOverride.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# ValueOverride Enum

Has the pre-calculated (from ERP) price information been overridden, and how. If the user has filled out the discountpercentage field, then the UserValueOverride field is set to OverridePercent. (The DiscountAmount, EarningPercent, EarningAmount and TotalPrice fields are calculated based on the DiscountPercent.)

| Name | Value | Description |
|------|-------|-------------|
|None|0|Discount data is from the ERP system and has not been overridden|
|Total|1|The Total amount has been overridden; all other fields should be recalculated|
|DiscountPercent|2|The discount percentage has been overriden; all other fields should be recalculated|
|DiscountAmount|3|The discount amount has been overridden; all other fields should be recalculated|
|EarningPercent|4|The earning percent has been overridden; all other fields should be recalculated|
|EarningAmount|5|The earning amount has been overridden; all other fields should be recalculated|

## Usage

* [QuoteAlternative](../quotealternative.md).UserValueOverride - Quote Version is made up of one or more Alternatives. One of 1..n possible alternatives in a Quote Version. The reason we have alternatives is that a quote can say to a customer, “we can solve you problem in two (or more) different ways, with different technology and sideeffects (and price)”. An Alternative may have discounts on the total amount. The Alternative tracks whether the user on the order level entered the Discount , Earning amount or the TotalPrice fields so that the discount and earning and total can be re-calculated correctly when Quote Lines are added or changed.
* [QuoteLine](../quoteline.md).UserValueOverride - One line in a QuoteAlternative. QuoteLines are mainly information copied from the Products provider. Products information is sometimes edited by the user before being included in the quote, so most information is duplicated from Product rather than referenced directly.
