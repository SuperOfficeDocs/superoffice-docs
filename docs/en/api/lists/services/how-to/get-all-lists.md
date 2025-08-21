---
title: ws-list-how-to-get-all-lists
description: How to get all lists via web service APIs
author: AnthonyYates
keywords: list,agent
content_type: howto
date: 03.03.2022
category: list
area: api-services
redirect_from: /en/api/netserver/lists/services/how-to/get-all-lists
---


# How to get all lists

To get all available lists, use the `Lists` keyword.

<!-- markdownlint-disable-file MD051 -->
## [RESTful REST API](#tab/lists-restful-rest)

```http
GET https://{{env}}.superoffice.com/{{tenant}}/api/v1/List 
Authorization: Bearer {{token}}
Accept: application/json; charset=utf-8
```

## [HTTP RPC Agent API](#tab/lists-restful-agent)

Ironically, it's not possible to get all lists from the List endpoint. Use the MDO endpoint to get all built-in and user-defined lists.

This has some limitations in that the results do not specify if the list uses Groups and Headings. For that, use the RESTful REST List endpoint.

```http
POST https://{{env}}.superoffice.com/{{tenant}}/api/v1/Agents/MDO/GetList HTTP/1.1
Authorization: Bearer {{token}}
Accept: application/json; charset=utf-8
Content-Type: application/json; charset=utf-8

{
  "Name": "Lists",
  "ForceFlatList": false,
  "AdditionalInfo": "",
  "OnlyHistory": false
}
```

## [WebApi Proxy API](#tab/lists-webapi-proxy)

Ironically, it's not possible to get all lists from the ListAgent. Use the MDO endpoint to get all built-in and user-defined lists.

This has some limitations in that the results do not specify if the list uses Groups and Headings. For that, use the RESTful REST List endpoint.

```csharp
var config = new WebApiOptions(tenant.WebApiUrl);
config.Authorization = new AuthorizationAccessToken("8A:Cust12345.Example-Token", OnlineEnvironment.SOD);
var mdoAgent = new MDOAgent(config);

var allLists = mdoAgent.GetSimpleListAsync("lists").Result;
```

***

[Back](index.md)

<!-- Link references -->
