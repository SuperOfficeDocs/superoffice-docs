---
title: IQuoteConnector2
uid: i_quote_connector2
description: IQuoteConnector2
author: SuperOffice Product and Engineering
date:
keywords: quote
content_type: howto
redirect_from: /en/api/netserver/plugins/quote-connectors/api/iquoteconnector2
---

# IQuoteConnector2

Enhanced Quote Connector abilities: modify state changes (approvals)

## QuoteVersionResponseInfo OnQuoteVersionRequestApproval(QuoteVersionContextInfo context)

Called when a version needs approval before it can be sent.

* context: Quote Version that needs approval. `QuoteVersion.RequestAssociateId` and `QuoteVersion.RequestComment` are filled in with who should approve, and the reason why.

Returns: Updated quote version state.

## QuoteVersionResponseInfo OnQuoteVersionApproved(QuoteVersionContextInfo context)

Called when quote that needs approval is approved.

* context: Quote version state after approval.

Returns: Updated quote version.

## QuoteVersionResponseInfo OnQuoteVersionRejected(QuoteVersionContextInfo context)

Called when quote that needs approval is rejected.

* context: Version state after rejection

Returns: Updated version state.
