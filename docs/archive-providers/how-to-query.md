---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: how_to_query       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: How to perform an archive provider query # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: Tony Yates
so.date: 11.17.2017
keywords:
so.topic: howto              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# How to perform an archive provider query

While archive providers make complex queries possible through web services, they of course work in and with their lower-level data types executed in the belly NetServer.

This section shows how to query an archive provider both using the core NetServer API, as well as the NetServer Web Services API.

Both examples represent a query that selects all sales where the sale project ID is set to 47.

## NetServer Core

[!code-csharp[NetServer Core](includes/query-ns-core.cs)]

## NetServer Web Services

[!code-csharp[NetServer Web Services](includes/query-ns-ws.cs)]

## NetServer REST WebApi 

Using the `Sale` endpoint and issue an `OData` query (see [documentation][1]):

```javascript
GET /Cust12345/api/v1/Sale?$select=saleId,heading,projectId&$filter=projectId eq 47 HTTP/1.1
Host: sod.superoffice.com:443
Authorization: Bearer 8A:Cust12345.AS5...sy9
Accept: application/json
```

## NetServer REST Agent Service

Using the RESTful Agent Find endpoint (see [documentation][2]):

[!code-csharp[NetServer Web Services](includes/query-rest-agent.js)]

There are subtle differences between core and web services APIs, but for the most part, they are the same. One of the biggest differences is how value types are returned, i.e. integers, Double, and DateTime.

<!-- Referenced links -->
[1]: https://community.superoffice.com/documentation/sdk/SO.NetServer.Web.Services/html/v1SaleEntity_GetAll.htm
[2]: https://community.superoffice.com/documentation/sdk/SO.NetServer.Web.Services/html/v1FindAgent_FindFromRestrictionsColumns.htm