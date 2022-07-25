---
title: ws-list-how-to-get-list-entity
description: How to get list entity via web service APIs
author: AnthonyYates
keywords: list,agent
so.topic: how-to-guide
so.date: 03.03.2022
so.category: list
so.area: api-services
---

# How to get list entity by name

<!-- markdownlint-disable-file MD051 -->

The List endpoint, as exposed by the Agent API and proxy clients, uses Named lists, or methods, to obtain a list entity and list items.

The follow examples demonstrate how to get the Category list entity.

## [RESTful REST API](#tab/list-entity-restful-rest)

```http
GET https://{{env}}.superoffice.com/{{tenant}}/api/v1/List/Category
Authorization: Bearer {{token}}
Accept: application/json; charset=utf-8
```

## [RESTful Agent API](#tab/list-entity-agent-rest)

```http
POST https://{{env}}.superoffice.com/{{tenant}}/api/v1/Agents/List/GetListEntityByName HTTP/1.1
Authorization: Bearer {{token}}
Accept: application/json; charset=utf-8
Content-Type: application/json; charset=utf-8

{
  "Name": "Category",
}
```

## [WebApi Proxy API](#tab/list-entity-webapi-proxy)

Get a list entity using the [SuperOffice.WebApi][1] proxy client.

```csharp
var config = new WebApiOptions(tenant.WebApiUrl);
config.Authorization = new AuthorizationAccessToken("8A:Cust12345.Example-Token", OnlineEnvironment.SOD);
var agent = new ListAgent(config);

var listEntity = agent.GetListEntityByNameAsync("Category").Result;
```

***

[Back](index.md)

<!-- Link references -->

[1]: ../../../web-services/proxies/index.md
