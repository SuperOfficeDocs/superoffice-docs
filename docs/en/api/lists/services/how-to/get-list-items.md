---
title: ws-list-how-to-get-all-list-items
description: How to get all list items via web service APIs
author: AnthonyYates
keywords: list,agent
content_type: howto
date: 03.03.2022
category: list
area: api-services
redirect_from: /en/api/netserver/lists/services/how-to/get-list-items
---

# How to get all list items

<!-- markdownlint-disable-file MD051 -->
## Built-In lists

The advantage of using the List endpoint, when it comes to build in lists, it that it is very straightforward and easy to choose the correct method. The Agent APIs, including the HTTP RPC Agent API and proxy clients, have methods that are named the same as the list.

The method will return the list items with no added work. For example, the HTTP RPC Agent API GetCountries endpoint gets all countries.

Use the list name to get all list items for built-in lists.

## [RESTful REST API](#tab/list-items-restful-rest)

```http
GET https://{{env}}.superoffice.com/{{tenant}}/api/v1/List/Category/Items
Authorization: Bearer {{token}}
Accept: application/json; charset=utf-8
```

## [HTTP RPC Agent API](#tab/list-items-agent-rest)

```http
POST https://{{env}}.superoffice.com/{{tenant}}/api/v1/Agents/List/GetCategories HTTP/1.1
Authorization: Bearer {{token}}
Accept: application/json; charset=utf-8
Content-Type: application/json; charset=utf-8
```

## [WebApi Proxy API](#tab/list-items-webapi-proxy)

How to get all list items using the [SuperOffice.WebApi][1] proxy client.

```csharp
var config = new WebApiOptions(tenant.WebApiUrl);
config.Authorization = new AuthorizationAccessToken("8A:Cust12345.Example-Token", OnlineEnvironment.SOD);
var agent = new ListAgent(config);

var listEntity = agent.GetCategoriesAsync().Result;
```

***

## User-defined lists

Use the prefix `udlist` and suffix `{listId}` to get all list items for user-defined lists. For example, given a user-defined list named "MyCustomList" has an Id value of 94, the list name to use is `udlist94`.

See the relevant examples below.

## [RESTful REST API](#tab/udlist-items-restful-rest)

Must use the MDOList endpoint for user-defined lists.

```http
GET https://{{env}}.superoffice.com/{{tenant}}/api/v1/MDOList/udlist94 HTTP/1.1
Authorization: Bearer {{token}}
Accept: application/json; charset=utf-8
```

## [HTTP RPC Agent API](#tab/udlist-items-agent-rest)

Must use the MDOList endpoint for user-defined lists. Both of the following options work.

```http
POST https://{{env}}.superoffice.com/{{tenant}}/api/v1/Agents/MDO/GetList HTTP/1.1
Authorization: Bearer {{token}}
Accept: application/json; charset=utf-8
Content-Type: application/json; charset=utf-8

{
  "Name": "udlist",
  "ForceFlatList": false,
  "AdditionalInfo": "94",
  "OnlyHistory": false
}
```

or

```http
POST https://{{env}}.superoffice.com/{{tenant}}/api/v1/Agents/MDO/GetList HTTP/1.1
Authorization: Bearer {{token}}
Accept: application/json; charset=utf-8
Content-Type: application/json; charset=utf-8

{
  "Name": "udlist94",
  "ForceFlatList": false,
  "AdditionalInfo": "",
  "OnlyHistory": false
}
```

## [WebApi Proxy API](#tab/udlist-items-webapi-proxy)

How to get all list items using the [SuperOffice.WebApi][1] proxy client.

```csharp
var config = new WebApiOptions(tenant.WebApiUrl);
config.Authorization = new AuthorizationAccessToken("8A:Cust12345.Example-Token", OnlineEnvironment.SOD);
var agent = new MDOAgent(config);

var listEntity = agent.GetListAsync("udlist94").Result;
```

***

[Back](index.md)

<!-- Link reference -->

[1]: ../../../web-services/proxies/index.md
