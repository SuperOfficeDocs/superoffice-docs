---
title: q1uote_connector_carrier_isaleinfo
description: ERP Quote Connector Interface data carrier - ISaleInfo
so.date:
keywords: quote
so.topic: reference
---

# ISaleInfo

Read-only sale information.

How sale and quote conceptually fit together:

![25][img1]

## int SaleId

Primary key of the sale record in CRM database

## string Associate

Owner of the sale

## string Number

Sale number

## string Title

Title of the sale

## double Amount

Total sale amount

## string Currency

Sale currency name

## string PublishStartDate

Sale, start date for publishing

## string PublishEndDate

Sale, end date for publishing

## string Type

Sale type - an MDO list item name

## string Stage

Sale stage - an MDO list item name

## string Credited

Credited to - an MDO list item name

## string Competitor

Main Competitor for sale - an MDO list item name

## short Probability

Probability percent - default derived from Stage list

## string NextDueDate

Date of the first uncompleted activity.

## string Reason

Reason the sale is lost/sold etc.

## string SaleDate

Expected closing date

## string Status

Open/Sold/Lost/Stalled

## Decimal Cost

Total cost

## Decimal Profit

Total profit (Amount - Cost)

<!-- Referenced images -->
[img1]: media/image025.png <!-- http://www.yuml.me/diagram/scruffy;/class/%5BSale%5D-%3E%5BQuote%5D,%20%5BQuote%5D-%3E%5BQuoteRevision%5D,%20%5BQuoteRevision%5D-%3E%5BQuoteAlternative%5D.png -->
