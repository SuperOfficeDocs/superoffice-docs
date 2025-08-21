---
title: Approving the quote
uid: quote_connectors_approve_quote
description: Approving the quote
author: SuperOffice Product and Engineering
date:
keywords: quote
content_type: howto
redirect_from: /en/api/netserver/plugins/quote-connectors/approve-quote
---

# Approving the quote

When a [quote is about to be sent][1], the quote connector can decide that the quote needs to be approved before being sent to the customer.

![Quote needs approval before sending][img1]

The user chooses who they want to approve the quote from the list of users with the `can-approve-quote` function right.

The request for approval is sent in:

![Quote approval request][img2]

The quote connector must implement `IQuoteConnector2` interface for this function to be called:

## QuoteVersionResponseInfo OnQuoteVersionRequestApproval( QuoteVersionContextInfo context )

The context's `QuoteVersion.RequestAssociateId` and `RequestComment` are filled in with the values from the dialog.

The quote connector can update the quote state, or choose to send its own notification to the recipient.

## Approved

The approver is notified in Mobile, and clicks **Approved** or **Reject**.

![Quote is approved][img3]

<!-- Referenced links -->
[1]: send-quote.md

<!-- Referenced images -->
[img1]: media/needs-approval.png
[img2]: media/request-approval.png
[img3]: media/request-approved.png
