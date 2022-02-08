---
title: IProductRegisterCache
uid: i_product_register_cache 
description: IProductRegisterCache
author: {github-id}
so.date:
keywords: quote
so.topic: howto
---

# IProductRegisterCache

This part is not in use yet.

SuperOffice has its own simple Product table. This table can be used by the ERP connectors as a cache for ERP data.

This interface will be implemented by SuperOffice. The implementation is passed to all connectors as an initialization parameter.

## int CreatePriceList( PriceListInfo pricelist )

Creates a pricelist in the SuperOffice database.

Returns the id to the pricelist.

## ProductInfo[] InsertProducts(int pricelistId, ProductInfo[] products )

Insert a set of products into the SuperOffice database.

Returns the products updated with their new ids.

## UpdateProduct ( ProductInfo newProd )

Update a product in the cache with new information

## IProductProvider GetSuperOfficeProductProvider( int quoteConnectionId )

Here you can get the data you have inserted into the SuperOffice tables.

## void RemovePriceList( int pricelistId, bool alsoRemoveRelatedProducts )

Remove a pricelist and any associated products.

## void RemoveProduct( int productId )

Will remove a product if it is in a pricelist related to the connection, and the pricelist is an ERP copy.

## int InsertImage(int productId, Image img, int rank )

## void RemoveImage( int imageId )
