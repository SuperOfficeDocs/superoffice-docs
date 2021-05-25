---
title: Price calculations and field changes
uid: quote_connectors_calculate_price
description: How to calculate the price on field-changes
author: {github-id}
so.date:
keywords: quote
so.topic: howto
---

# Price calculations and field changes

![15][img1]

Some installations will be able to compute a price by various means (customer frame agreements chief among these). These calculations are presumably handled by the ERP system. SuperOffice asks the connector to handle changes to the QuoteLine. The ERP connector requests calculations from the ERP system and updates the Quote information in the CRM system.

![16][img2]

The ERP Connector is responsible for performing the calculations when the user changes values in the quote, like quantity in a quoteline or Earning on the quote alternative.

## QuoteLineInfo OnQuoteLineChanged( QuoteContextInfo context, QuoteLineInfo ql, string[] changedFields )

Called when the user has changed a field in the `QuoteLine`.

The `QuoteContextInfo` is read-only. `QuoteLine` may be changed in the return value.

> [!NOTE]
> Response time must be fast since this method is called often (every time a field is changed).

## QuoteAlternativeWithLinesInfo RecalculateQuoteAlternative( QuoteAlternativeContextInfo context )

The user is finished with entering the quote lines and wants to calculate the order discount (alternative discount) on this alternative.

This method is called whenever the quote lines are changed, or when the user clicks the **RECALCULATE** button.

| Field | Read-only? |
|---|---|
| QuoteLines | no |
| Alternative | no |
| QuoteVersion | yes |
| Quote | yes |
| Sale | yes |
| Associate | yes |
| Contact | yes |

Fields that are not read-only can be changed in the return value. The connector may signal problems with the quote by setting the Quote Alternative Status.

## QuoteVersionResponseInfo ValidateQuoteVersion ( QuoteVersionContextInfo context, QuoteAction action )

The user is finished with entering the `QuoteLines`, and wants to send or publish the quote. This method is called whenever the user clicks the **Send** button or **Place Order**.

| Field | Read-only? |
|---|---|
| QuoteLines | no |
| Alternative | no |
| Version | no |
| Quote | no |
| Sale | yes |
| Associate | yes |
| Contact | yes |

Fields that are not read-only can be changed in the return value.

A draft quote version will have `state = DraftNotCalculated` when called. The connector should set the version state to `DraftCalculated` if the calculations were successful. Leave the state as `DraftNotCalculated` if the ERP system was not available or some other factor that made the calculation unsuccessful.

The system will try to hint about why it is asking with the action parameter, it will tell you if the user has pressed **Send quote** or **Place order**.

The connector can trigger the approval workflow by setting the state to `DraftNeedsApproval`. When a user with the approval permission has approved or rejected the quote, the quote version state will be `DraftApproved` or `DraftApprovalRejected`.

> [!NOTE]
> Recalculate may also be called when the quote is Approved, or Archived.  In these cases, please leave the quote version state alone.

The connector may signal problems with the quote by setting the Quote Version, Quote Alternative, or a quote line’s Status to Error, Warning, or OkWithInfo, and fill in the Reason field with an explanation.

## QuoteVersionResponseInfo UpdateQuoteVersionPrices ( QuoteVersionContextInfo context )

The user knows that the prices have changed in the price list, and would like to update the quote with the latest product information from the price list.

This method is called whenever the user clicks the **UPDATE PRICES** button in the **Quote** dialog.

| Field | Read-only? |
|---|---|
| QuoteLines | no |
| Alternative | no |
| Version | no |
| Quote | no |
| Sale | yes |
| Associate | yes |
| Contact | yes |

Fields that are not read-only can be changed in the return value.

The connector should look up the product in the price list and update each list with new prices and other relevant details.

The connector may signal problems with the quote by setting the Quote Version, Quote Alternative, or a quote line’s Status to Error, Warning, or OkWithInfo, and fill in the Reason field with an explanation.

![17][img3]

A default implementation of price calculations can be found in the plugin’s `QuoteCalculation` class.

<!-- Referenced images -->
[img1]: media/image015.jpg
[img2]: media/image016.jpg
[img3]: media/image017.jpg
