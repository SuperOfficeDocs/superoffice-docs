---
title: quote_connector_carrier_quoteversioninfo
description:  ERP Quote Connector Interface data carrier - QuoteVersionInfo
so.date:
keywords: quote
so.topic: reference
---

# QuoteVersionInfo

Represent a version of a quote

A quote is divided into one or more versions (or revisions, if you like), so a quote has 1..n `QuoteVersions`. A `QuoteVersion` always has a quote.

Even if versioning is disabled, a single version will exist.  When versioning is disabled, new versions are not created, but the only one is reused.

## int QuoteVersionId

Primary key in CRM database.

## string ERPQuoteVersionKey

Key in the ERP system that uniquely identifies this Version within the ERP system (if available, the field may be empty).

## int QuoteId

Foreign key to CRM quote (the conceptual parent).

Owning Quote of this Quote Version

## string Description

Description of Version.

Potentially longer text description, typically used in a tooltip.

Max 2K.

## string Number

A quote number that the user (or ERP connector) can fill out.

## QuoteVersionStateInfo State

Current state of this quote version.

The states will be like: CalculatedDraft, NotCalculatedDraft, Published, etc.

## int LikelyQuoteAlternativeId

The alternative that is considered most likely to be accepted.

Used to calculate probable income.

## DateTime SentDate

The date the version was sent to the customer.

## int FollowupId

Link to a follow-up activity, created when this quote version was sent to the customer.

## DateTime ExpirationDate

Last date the quote Version is valid, expiration is at midnight end of this day.

## string DeliveryCountry

The quote has an address for delivery.  Should be stored as ISO code or something…

## bool HasOwnDeliveryAddress

The delivery address is not the same as the contact's Street address

## string InvoiceCountry

The quote has an address for invoicing. Should be stored as ISO code or something…

## bool HasOwnInvoiceAddress

The quote has an address for invoicing. This will typically be copied from the company's addresses.

## string ERPPaymentTermsKey

Either a list ID to an ID from a connector provided list, or, if the connection doesn't support lists, a text.

For example: "Standard 30 days".

## string ERPPaymentTypeKey

Either a list ID to an ID from a connector provided list, or, if the connection doesn't support lists, a text.

For example: "Invoice".

## string ERPDeliveryTermsKey

Either a list ID to an ID from a connector provided list, or, if the connection doesn't support lists, a text.

For : "FOB" ("Free on board").

## string ERPDeliveryTypeKey

Either a list ID to an ID from a connector provided list, or, if the connection doesn't support lists, a text.

For example: "Air".

## int Rank

Rank/Version number, starts at 1.

## QuoteStatus Status

If there was a problem with for instance calculation, this field is set to warning or error.

## string Reason

If there was a problem, this field contains a localized explanation of the problem and possible steps to fix it that the user can be shown.

## string ExtraField1

[!include[ALT](./includes/quoteversion-extrafield.md)]

## string ExtraField2

[!include[ALT](./includes/quoteversion-extrafield.md)]

## string ExtraField3

[!include[ALT](./includes/quoteversion-extrafield.md)]

## string ExtraField4

[!include[ALT](./includes/quoteversion-extrafield.md)]

## string ExtraField5

[!include[ALT](./includes/quoteversion-extrafield.md)]

## int ApprovedBy

Not yet implemented:

ID of associate who approved (or rejected approval) for this version.

## string ApprovedText

Not yet implemented:

Text with comments on why approval was granted (or rejected)

## int ApprovedRegisteredBy

Not yet implemented:

ID of associate who actually entered the approval; might be different from ApprovedBy (due to telephone consultation/approval)

## DateTime ApprovedRegisteredDate

When was approval granted or rejected

## DateTime LastRecalculated

When this version was last subjected to a total recalculation. This field must be set by the connector, since the connector may choose to ignore a RecalculateVersion call based on policies and possibly the current value of this field. SuperOffice will set this field to 1.1.1760 whenever any change occurs to the quote, to indicate that a recalculation is needed.
