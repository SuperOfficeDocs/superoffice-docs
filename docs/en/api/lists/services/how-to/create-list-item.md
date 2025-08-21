---
title: ws-list-how-to-create-a-list-item
description: How to create a list item using web service APIs
author: AnthonyYates
keywords: list,agent
content_type: howto
date: 03.03.2022
category: list
area: api-services
redirect_from: /en/api/netserver/lists/services/how-to/create-list-item
---

<!-- markdownlint-disable-file MD051 -->
# How to create a list item

Create a list item and add it to an existing list, use the `Lists` endpoint.

## [RESTful REST API](#tab/lists-restful-rest)

```http
POST https://{{env}}.superoffice.com/{{tenant}}/api/v1/List/109/Items HTTP/1.1
Authorization: Bearer {{token}}
Accept: application/json; charset=utf-8
Content-Type: application/json; charset=utf-8

{
  "Name": "Custom list item one",
  "Tooltip": "Custom list item one",
}
```

**Response:**

```json
{
  "Id": 20,
  "Name": "Custom list item one",
  "Tooltip": "Custom list item one",
  "Deleted": false,
  "UdListDefinitionId": 108,
  "Rank": 0,
  "TableRight": null,
  "FieldProperties": {}
}
```

## [HTTP RPC Agent API](#tab/lists-restful-agent)

Use the `CreateDefaultListItemEntity` to get the default list item JSON structure, then use the SaveListItemEntity endpoint to persist the new list.

```http
POST https://{{env}}.superoffice.com/{{tenant}}/api/v1/Agents/List/CreateDefaultListItemEntity HTTP/1.1
Authorization: Bearer {{token}}
Accept: application/json; charset=utf-8
```

**Response:**

```json
{
  "Id": 0,
  "Name": null,
  "Tooltip": null,
  "Deleted": false,
  "UdListDefinitionId": 0,
  "Rank": 0,
  "TableRight": null,
  "FieldProperties": {}
}
```

Save the list.

> [!CAUTION]
> Make sure to append/assign the default list item JSON to the named parameter **ListItemEntity** when saving.

```http
POST https://{{env}}.superoffice.com/{{tenant}}/api/v1/Agents/List/SaveListItemEntity HTTP/1.1
Authorization: Bearer {{token}}
Accept: application/json; charset=utf-8
Content-Type: application/json

{
  "ListItemEntity": {
    "Id": 0,
    "Name": "Custom List Item one",
    "Tooltip": "Represents custom list item one",
    "Deleted": false,
    "UdListDefinitionId": 106,
    "Rank": 0
  }
}
```

**Response:**

```JSON
{
  "Id": 25,
  "Name": "Custom List Item six",
  "Tooltip": "Represents custom list item six",
  "Deleted": false,
  "UdListDefinitionId": 106,
  "Rank": 0,
  "TableRight": null,
  "FieldProperties": {}
}
```

## [WebApi Proxy API](#tab/lists-webapi-proxy)

Create a list item using the [SuperOffice.WebApi][1] proxy client.

```csharp
var config = new WebApiOptions(tenant.WebApiUrl);
config.Authorization = new AuthorizationAccessToken("8A:Cust12345.Example-Token", OnlineEnvironment.SOD);
var listAgent = new ListAgent(config);

var listItem = await listAgent.CreateDefaultListItemEntityAsync();
listItem.Name = "Custom list item one";
listItem.Tooltip = "Custom list item one tooltip";
listItem = await listAgent.SaveListItemEntityAsync(listItem);
```

***

[Back](index.md)

<!-- Link references -->

[1]: ../../../web-services/proxies/index.md
