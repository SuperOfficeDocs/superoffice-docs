---
title: Creating a quote
uid: quote_connectors_create_quote
description: How to creating a quote
author: {github-id}
so.date:
keywords: quote
so.topic: howto
---

# Creating a quote

![07][img1]

1. When the user creates a quote by clicking the CREATE A NEW QUOTE link, the following happens.

    ![08][img2]

2. If there is more than one connection with price lists in the right currency, then the user must select the connection to use:

    ![09][img3]

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

Gets all `PriceLists` in the given currency, including those inactive. Will return all price lists if `isoCurrencyCode` is empty. Will return empty array if there is no `PriceList` available.

Currently not used.

## ProductInfo[] FindProduct( QuoteContextInfo context, string isoCurrencyCode, string userinput, string priceListKey )

The connector should treat this as a free text search. The user might want to search for the name, description, product code, extra fields, and so on.

Since the return list is a potentially large return value, the connector or the ERP system should limit the number of matches returned to a few hundred.

If the `priceListKey` is empty, the function will search in all active price lists. An empty search (`""`) should return null, but a search on `"%"` should return all products.

The dropdown fast searcher calls this function.

## ProductInfo GetProduct( string erpProductKey )

Gets a product based on `erpProductKey`. Returns the product with the specified key.

* If the product is not found, the function will throw an `ArgumentException`.
* If the argument is null or empty, the function will throw an `ArgumentException`.

## ProductInfo[] GetProducts( string[] erpKeys )

Return products based on an array of unique ERP keys. Handy when you’ve found products through archive providers or other mechanisms that leave you holding multiple  `ERPKey` values.

## QuoteLineInfo GetQuoteLineFromProduct( QuoteContextInfo context, string erpProductKey )

Given a product ERP Key, return a quote line with some default values filled in. The `quoteLineId` will be provided by SuperOffice later.

Returns the `QuoteLine` with the product info filled in. If the product isn’t found, the function will throw an exception.

## int GetNumberOfProductImages( string erpProductKey )

Gets the number of images available for this product.

Currently not used.

## GetProductImage ( string erpProductKey, int rank )

Gets the full-size picture of the given product. Returns the full-size picture of the given product or NULL if no picture available.

Rank: Which of the images to return, will in the first version only ask for the first.

<!-- Referenced links -->
[1]: http://www.currency-iso.org/dl_iso_table_a1.xls

<!-- Referenced images -->
[img1]: media/image007.jpg
[img2]: media/image008.jpg
[img3]: media/image009.png
[img4]: media/image010.png
[img5]: media/image011.jpg
