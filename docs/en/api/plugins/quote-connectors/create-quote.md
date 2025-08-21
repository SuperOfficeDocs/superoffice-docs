---
title: Creating a quote
uid: quote_connectors_create_quote
description: How to create a quote
author: SuperOffice Product and Engineering
date: 11.08.2021
keywords: quote, sale, product, price list, QuoteConnectorExtender
content_type: howto
redirect_from: /en/api/netserver/plugins/quote-connectors/create-quote
---

# Creating a quote

![Create quote -screenshot][img1]

1. When the user creates a quote by clicking the CREATE A NEW QUOTE link, the following happens.

    ![08][img2]

2. If there is more than one connection with price lists in the right currency, then the user must select the connection to use:

    ![09 -screenshot][img3]

## Product and price list information

This part of the connector interface searches the ERP system’s product and price list information.

If an ERP system does not provide products, the product searches can be delegated to the built-in SuperOffice product registry by using the `QuoteConnectorExtender` class as a base.

Currencies are specified in ISO 3-letter codes: USD, NOK, SEK, EUR, GBP, etc. See [www.currency-iso.org][1] for details. All `isoCurrencyCode` parameters below are case-insensitive ISO currency like USD or NOK.

The price lists are accessed from the SuperOffice CRM client.

![10][img4]

The client uses `FindProduct` to do simple searches. You can set filters on the available price lists.

![11][img5]

## int GetNumberOfActivePriceLists(string isoCurrencyCode )

Is used to warn the user if there are no active price lists in a given currency. Will return no of all active price lists if `isoCurrencyCode` is empty.

## PriceListInfo[] GetActivePriceLists( string isoCurrencyCode )

Used by SuperOffice to provide filters. Gets the available active `PriceLists` in a specific currency.

Will return all price lists if `isoCurrencyCode` is empty. Returns an empty array if there is no `PriceList` with the stated currency available.

## PriceListInfo[] GetAllPriceLists( string isoCurrencyCode )

Gets all `PriceLists` in the given currency, including those inactive. Will return all price lists if `isoCurrencyCode` is empty. Will return an empty array if there is no `PriceList` available.

Currently not used.

<!-- Referenced links -->
[1]: http://www.currency-iso.org/dl_iso_table_a1.xls

<!-- Referenced images -->
[img1]: media/create-quote.png
[img2]: media/image008.jpg
[img3]: media/image009.png
[img4]: media/image010.png
[img5]: media/image011.jpg
