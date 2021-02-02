---
# Mandatory fields.
title: how_to_query_with_archive_providers       # (Required) 
description: How to perform an archive provider query # (Required) Important for SEO.
author: Tony Yates
so.date: 11.17.2017
keywords:
so.topic: howto              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# How to perform an archive provider query

It is necessary to query data from a database when writing applications. Archive providers are designed for this. They handle the complex business logic of filtering and flattening the complex relationships in the database into a simple flat table.

While archive providers make complex queries possible through web services, they of course work in and with their lower-level data types executed in the belly NetServer.

## NetServer Core vs web services

This section shows how to query an archive provider both using the core NetServer API, as well as the NetServer Web Services API.

There are subtle differences between core and web services APIs, but for the most part, they are the same. One of the biggest differences is how value types are returned (integers, Double, and DateTime).

Both examples represent a query that selects all sales where the sale project ID is set to 47.

### [NetServer Core](#tab/query-ns-core)

[!code-csharp[NetServer Core](includes/query-ns-core.cs)]

### [NetServer Web Services](#tab/query-ns-ws)

[!code-csharp[NetServer Web Services](includes/query-ns-ws.cs)]

***

## Example

The following example demonstrates how a `PersonProvider` is used to query data from the database.

[!code-csharp[CS](includes/personprovider.cs)]

Here we have initially created an archive provider of type Person. PersonProvider is a specially designed archive provider:

* Retrieve the list of columns that can be handled by this archive provider through the `GetAvailableColumns` method.
* Retrieve the Entities that are supported by this archive provider via the `GetAvailableEntities` method.
* `GetAvailableColumns()` and `GetAvailableEntities` return data lists of type `ArchiveColumnInfo` and `ArchiveEntityInfo` respectively.

In the above example, we have retrieved the `ColumnInfo` and `EntityInfo` from the `PersonProvider` and displayed them in 2 list-boxes.

![ALT][img1]

Finally, we have retrieved the set of rows satisfying the above query and displayed them in another Listbox.

![ALT][img2]

## NetServer REST WebApi

Using the `Sale` endpoint and issue an `OData` query (see [documentation][1]):

```http
GET /Cust12345/api/v1/Sale?$select=saleId,heading,projectId&$filter=projectId eq 47 HTTP/1.1
Host: sod.superoffice.com:443
Authorization: Bearer 8A:Cust12345.AS5...sy9
Accept: application/json
```

## NetServer REST Agent Service

Using the RESTful Agent Find endpoint (see [documentation][2]):

[!code-csharp[NetServer Web Services](includes/query-rest-agent.js)]

<!-- Referenced links -->
[1]: https://community.superoffice.com/documentation/sdk/SO.NetServer.Web.Services/html/v1SaleEntity_GetAll.htm
[2]: https://community.superoffice.com/documentation/sdk/SO.NetServer.Web.Services/html/v1FindAgent_FindFromRestrictionsColumns.htm

<!-- Referenced images -->
[img1]: media/query-1.jpg
[img2]: media/query-2.jpg
