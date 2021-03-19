<properties generated="1" SortOrder="990" />

# ValueOverride Enum

Has the pre-calculated (from ERP) price information been overridden, and how. If the user has filled out the discountpercentage field, then the UserValueOverride field is set to OverridePercent. (The DiscountAmount, EarningPercent, EarningAmount and TotalPrice fields are calculated based on the discountPercent.)

* None = 0
* Total = 1
* DiscountPercent = 2
* DiscountAmount = 3
* EarningPercent = 4
* EarningAmount = 5

## Usage
* [QuoteAlternative](QuoteAlternative.md).UserValueOverride - Quote Version is made up of one or more Alternatives. One of 1..n possible alternatives in a Quote Version. The reason we have alternatives is that a quote can say to a customer, “we can solve you problem in two (or more) different ways, with different technology and sideeffects (and price)”. An Alternative may have discounts on the total amount. The Alternative tracks whether the user on the order level entered the Discount , Earning amount or the TotalPrice fields so that the discount and earning and total can be re-calculated correctly when Quote Lines are added or changed.
* [QuoteLine](QuoteLine.md).UserValueOverride - One line in a QuoteAlternative. QuoteLines are mainly information copied from the Products provider. Products information is sometimes edited by the user before being included in the quote, so most information is duplicated from Product rather than referenced directly.

