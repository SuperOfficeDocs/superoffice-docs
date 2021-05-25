---
title: Sending quotes
uid: quote_connectors_send_quote
description: Sending the quote
author: {github-id}
so.date:
keywords: quote
so.topic: howto
---

# Sending quotes

![19][img1]

When a user sends a quote to the customer, the quote version is frozen, and the quote version cannot be edited further.

This happens outside the Quote Connector. SuperOffice will generate a PDF document containing the overview document and the order details, and generate an e-mail to the customer if asked.

The connector is not involved in this process.

The QuoteConnector is called after all this is done so that the connector can sync information about the published quote to the ERP system.

## QuoteSentResponseInfo OnAfterSentQuoteVersion( QuoteContextInfo context )

Called after a quote version is sent to the customer. Can return a URL or SO Protocol, or a status message to indicate success/failure. Cannot prevent the version from becoming archived.

![20][img2]

<!-- Referenced images -->
[img1]: media/image019.png
[img2]: media/image020.jpg
