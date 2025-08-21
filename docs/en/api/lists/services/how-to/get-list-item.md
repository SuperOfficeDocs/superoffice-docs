---
title: ws-list-how-to-get-list-item
description: How to get list item via web service APIs
author: AnthonyYates
keywords: list,agent
content_type: howto
date: 03.03.2022
category: list
area: api-services
redirect_from: /en/api/netserver/lists/services/how-to/get-list-item
---

<!-- markdownlint-disable-file MD051 -->
# How to get a specific list item

The List endpoint provides methods that we can use to retrieve a single entry of a given list by providing the unique identifier of the list as a parameter. For example, we can get a specific country by using the method `GetCountry` and providing the country ID as the parameter.

The following list contains **a few** of the many methods available.

* GetCountry
* GetBusiness
* GetCategory
* GetCredited
* GetCurrency

## [RESTful REST API](#tab/list-item-restful-rest)

```http
GET https://{{env}}.superoffice.com/{{tenant}}/api/v1/List/Category/Items/3 HTTP/1.1
Authorization: Bearer {{token}}
Accept: application/json; charset=utf-8
```

## [HTTP RPC Agent API](#tab/list-item-agent-rest)

Specify which category Id by using the `categoryId` query string parameter.

```http
POST https://{{env}}.superoffice.com/{{tenant}}/api/v1/Agents/List/GetCategory?categoryId=3 HTTP/1.1
Authorization: Bearer {{token}}
Accept: application/json; charset=utf-8
```

## [WebApi Proxy API](#tab/list-item-webapi-proxy)

Get a list item using the [SuperOffice.WebApi][1] proxy client.

```csharp
var config = new WebApiOptions(tenant.WebApiUrl);
config.Authorization = new AuthorizationAccessToken("8A:Cust12345.Example-Token", OnlineEnvironment.SOD);
var agent = new MDOAgent(config);

var listEntity = agent.GetCategoryAsync(3).Result;
```

***

[Back](index.md)

<!-- Link references -->

[1]: ../../../web-services/proxies/index.md
