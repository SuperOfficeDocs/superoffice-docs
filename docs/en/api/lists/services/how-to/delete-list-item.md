---
title: ws-list-how-to-delete-list-item
description: How to delete a list item using web service APIs
author: AnthonyYates
keywords: list,agent
content_type: howto
date: 03.03.2022
category: list
area: api-services
redirect_from: /en/api/netserver/lists/services/how-to/delete-list-item
---

# How to delete a list item

To delete a list item, use the `Lists` endpoint. These examples use the Category list for demonstration purposes.

<!-- markdownlint-disable-file MD051 -->
## [RESTful REST API](#tab/lists-restful-rest)

```http
DELETE https://{{env}}.superoffice.com/{{tenant}}/api/v1/List/Category/Items/5 HTTP/1.1
Authorization: Bearer {{token}}
Accept: application/json; charset=utf-8
```

**Response:**

HTTP Status 204

## [HTTP RPC Agent API](#tab/lists-restful-agent)

### For build-in lists use the list name. See example below to use list Id

```http
POST https://{{env}}.superoffice.com/{{tenant}}/api/v1/Agents/List/DeleteFromListName HTTP/1.1
Authorization: Bearer {{token}}
Accept: application/json; charset=utf-8
Content-Type: application/json; charset=utf-8

{
    "UdListDefinitionName": "Category",
    "id": "34"
}
```

### For user-defined lists, use the list ID and list item ID

```http
POST https://{{env}}.superoffice.com/{{tenant}}/api/v1/Agents/List/DeleteFromListDefinition HTTP/1.1
Authorization: Bearer {{token}}
Accept: application/json; charset=utf-8
Content-Type: application/json; charset=utf-8

{
    "UdListDefinitionId": "108",
    "Id": "65"
}
```

**Response:**

HTTP Status 204

## [WebApi Proxy API](#tab/lists-webapi-proxy)

How to delete a list item using the [SuperOffice.WebApi][1] proxy client.

### For build-in lists use the list name. See example below to use list Id

```csharp
var config = new WebApiOptions(tenant.WebApiUrl);
config.Authorization = new AuthorizationAccessToken("8A:Cust12345.Example-Token", OnlineEnvironment.SOD);

var listAgent = new ListAgent(config);
await listAgent.DeleteFromListNameAsync(34, "Category");
```

### For user-defined lists, use the list Id and list item Id

```csharp
var config = new WebApiOptions(tenant.WebApiUrl);
config.Authorization = new AuthorizationAccessToken("8A:Cust12345.Example-Token", OnlineEnvironment.SOD);

var listAgent = new ListAgent(config);
await listAgent.DeleteFromListDefinitionAsync(65, 108);
```

***

[Back](index.md)

<!-- Link references -->

[1]: ../../../web-services/proxies/index.md
