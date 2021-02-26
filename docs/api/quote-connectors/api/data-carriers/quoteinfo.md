---
title: quote_connector_carrier_quoteinfo
description:  ERP Quote Connector Interface data carrier -  QuoteInfo
so.date:
keywords: quote
so.topic: reference
---

# QuoteInfo

A Sale can have a quote and has then a 1-1 relationship with the QuoteInfo.

Read-write Quote information.

## int QuoteId

Primary key in CRM database.

## int SaleId

The foreign key to the corresponding sale.

## int QuoteConnectionId

The connection in the CRM system to where this quote came from.

Identifies the ERP connection used for this quote. Each quote is bound to one and only one connection.

## string ERPQuoteKey

Foreign key of quote (if available).

The key in the ERP system that identifies this sale's Quote (as opposed to the later Order information)

## string ERPOrderKey

The key in the ERP system that identifies this sale's Order, as transferred and possibly later edited in the ERP system.

Only filled out if there exists a corresponding order representation of the quote in the ERP system.

## int ActiveQuoteVersionId

The primary key of the Quote Version that is currently active. (The active version will always be the latest version.)

## int AcceptedQuoteAlternativeId

The primary key of the Quote Alternative that was finally accepted by the customer.

Set when the user is marking a quote as accepted.

## int DocumentId

The ID of the main Quote Document.  This is not the document containing the products, but the other one.
