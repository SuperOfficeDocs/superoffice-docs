---
title: quote_connectors_find_product
description: Product search provider
author: {github-id}             # Your GitHub alias.
so.date:
keywords: quote,search
so.topic: howto
---

# Product search provider

There are two ways a product can be searched for:

* The simple, keyword-driven search, where the user simply types one or more words
* A more structured search, where a **Find** dialog is shown. This dialog follows the usual convention where users can add one or more criteria, perform repeated searches, and finally choose one or more lines from the results to take back into the Quote system as Quote lines.

The simple search is part of the **Product Provider** part, specifically the `FindProduct` method. Implementation of this part and method are mandatory, though the connector is free to interpret the search keywords in whatever manner it sees fit.

The structured search is optional and can be implemented in one of 2 ways:

* Through the optional **Product Search Provider** functions
* By implementing an `IArchiveProvider` with a name according to a naming convention

The first option is simpler and more structured, while the second option gives the ultimate flexibility.

A connector signals that it supports this kind of search by supporting the capability `iconnector_perform_complexsearch` . If it contains an appropriately named archive provider, then this will be instantiated. Otherwise, it must implement the Product Search Provider functions.

The user clicks on the **ADVANCED FIND** button to trigger the search dialog.

![12][img1]

## Using product search provider functions

The Product Search Provider part contains 2 methods that need to be implemented:

### FieldMetadataInfo [] GetSearchableFields ()

Called before the search dialog is opened, to determine the set of searchable fields (possible criteria).

The connector can offer any fields it desires. If a "current price list" is implied by the GUI, then it will be included in the criteria, so connectors must always be prepared to handle `erpPricelistKey=xxx`.

### ProductInfo [] GetSearchResults ( SearchRestrictionInfo [] restrictions )

The actual search: An array of criteria is passed in, and an array of `ProductInfo` results is returned. The `ErpProductKey` field of each returned `ProductInfo` must be populated. As many as reasonable of the other fields should be populated. The user can choose which return fields to display.

The `SearchRestrictionInfo` structure consists of a criterion name, an operator, and an array of values. The criteria names will be those that the connector specified as available in a preceding `GetSearchableFields` call (the `FieldKey`).

Operators for all data types are:

* =
* !=
* <
* >
* <=
* >=
* **between**
* **in**

Strings can also use the **begins** and **contains** operators, where % is the 0-or-more wildcard character in the string value.

Values are encoded using the `CultureDataFormatter` mechanism. The **between** operator uses two values, the **in** operator uses 1..N values, and all other operators just use one value. There are no "magic values". If the user has chosen "this week" in the GUI for a date field, then the connector will see the **between** operator and the two correct datetime values denoting the start and end of the week.

If there is more than one restriction, then there is an implicit **AND** between them. There is no way to specify **OR** or precedence (parentheses).

## Using an archive provider

If a connector wants to **return more fields** than exist in the `ProductInfo` structure, or have custom grouping/icons or richer data types in the criteria, then it can implement an archive provider instead of implementing Product Search Provider functions.

Such a provider must have the name **FindErpProduct;\<name of connector>**, where name in both cases refers to the name in the attribute, not the name of the actual implementing class. Whenever such a provider is detected, then it will be called, following the usual protocol.

This means that it is instantiated twice:

* once so that `GetAvailableColumns` and `GetAvailableEntities` can be called
* once so that `SetRestrictions`, `SetDesiredColumns`, `SetDesiredEntities`, `SetPagingInfo`, and `GetRows` can be called to perform the actual search

The provider **must** declare the `erpProductKey` column and return a valid value. It must also set a `LinkHint` on the row, of the form `nav=erpProduct&erpProduct_id=<actual key>` on each row.

Apart from this, it **should** support a reasonable set of columns, which can be a superset of the `ProductInfo` items.

## Quote dropdown list provider

![13][img2]

There are a few lists in the ERP system that we would like to show to the users: payment terms and types, delivery terms and types, and product classifications (product category, product family, and product type).

These lists can be supplied by the ERP connector using this function. SuperOffice will take these values and convert the simple flat list of values into a SuperOffice list that appears in the GUI.

![14][img3]

If the ERP connector wants to supply a more complex nested list, then the ERP connector can implement a full MDO Provider.

### QuoteListItem[] GetQuoteList( string quoteListType )

Gets a named list from the connector. The `quoteListType` parameter is case insensitive.

Return array of QuoteListItems, or NULL if the given list is not supported.

## Quote list names

There are some lists in the system we would like the ERP system to provide data for if it can:

* ProductCategory
* ProductFamily
* ProductType
* PaymentTerms
* PaymentType
* DeliveryTerms
* DeliveryType

If a quote list is NULL, then the GUI will fall back to a text input field, where the user can enter text. This text is passed to the ERP plugin unchanged.

The Quote configuration API may also refer to custom list names which will be filled in by asking here. You will be asked for more lists than just the ones mentioned here if you have added custom lists to the configuration dialog.

<!-- Referenced images -->
[img1]: media/image012.jpg
[img2]: media/image013.jpg
[img3]: media/image014.jpg
