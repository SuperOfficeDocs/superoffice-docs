---
title: ws-list-how-to-delete-list
description: How to delete a list using web service APIs
author: AnthonyYates
keywords: list,agent
content_type: howto
date: 03.03.2022
category: list
area: api-services
redirect_from: /en/api/netserver/lists/services/how-to/delete-list
---

<!-- markdownlint-disable-file MD051 -->
# How to delete a list item

To delete a list, use the `Lists` endpoint. These examples use the Category list for demonstration purposes.

> [!WARNING]
> Do not delete built-in lists.

## [RESTful REST API](#tab/lists-restful-rest)

```http
DELETE https://{{env}}.superoffice.com/{{tenant}}/api/v1/List/108 HTTP/1.1
Authorization: Bearer {{token}}
```

## [HTTP RPC Agent API](#tab/lists-restful-agent)

For user-defined lists, use the list Id in the `ListEntityId` query string parameter.

```http
POST https://{{env}}.superoffice.com/{{tenant}}/api/v1/Agents/List/DeleteListEntity?ListEntityId=108 HTTP/1.1
Authorization: Bearer {{token}}
```

**Response:**

HTTP Status 204

## [WebApi Proxy API](#tab/lists-webapi-proxy)

How to delete a list entity using the [SuperOffice.WebApi][1] proxy client.

### For user-defined lists, use the list Id

```csharp
var config = new WebApiOptions(tenant.WebApiUrl);
config.Authorization = new AuthorizationAccessToken("8A:Cust12345.Example-Token", OnlineEnvironment.SOD);

var listAgent = new ListAgent(config);
await listAgent.DeleteListEntityAsync(108);
```

***

[Back](index.md)

<!-- Link reference -->

[1]: ../../../web-services/proxies/index.md
