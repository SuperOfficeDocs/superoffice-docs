---
uid: quote-connector-add-products
title: Adding products to a quote
description: How to add products to a quote
keywords: add product, ProductInfo, priceListKey, erpProductKey, QuoteConnectorExtender
author: SuperOffice Product and Engineering
date: 09.09.2022
content_type: howto
redirect_from: /en/api/netserver/plugins/quote-connectors/adding-products
---

# Adding products to a quote

The user searches for products in the Add Product dialog.

<!-- markdownlint-disable-next-line MD013 -->
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

<!-- Referenced images -->
