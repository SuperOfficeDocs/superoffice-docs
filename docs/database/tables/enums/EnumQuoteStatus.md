<properties generated="1" SortOrder="990" />

# QuoteStatus Enum

If there was a problem with for instance calculation, this field is set to warning or error.

* Ok = 0
* OkWithInfo = 1
* Warning = 2
* Error = 3

## Usage
* [QuoteVersion](QuoteVersion.md).Status - There may be multiple Versions of a Quote, with one of them active
* [QuoteAlternative](QuoteAlternative.md).Status - Quote Version is made up of one or more Alternatives. One of 1..n possible alternatives in a Quote Version. The reason we have alternatives is that a quote can say to a customer, “we can solve you problem in two (or more) different ways, with different technology and sideeffects (and price)”. An Alternative may have discounts on the total amount. The Alternative tracks whether the user on the order level entered the Discount , Earning amount or the TotalPrice fields so that the discount and earning and total can be re-calculated correctly when Quote Lines are added or changed.
* [QuoteLine](QuoteLine.md).Status - One line in a QuoteAlternative. QuoteLines are mainly information copied from the Products provider. Products information is sometimes edited by the user before being included in the quote, so most information is duplicated from Product rather than referenced directly.

