---
title: ws-list-how-to-create-a-list
description: How to create a list using web service APIs
author: AnthonyYates
keywords: list,agent
content_type: howto
date: 03.03.2022
category: list
area: api-services
redirect_from: /en/api/netserver/lists/services/how-to/create-list
---

<!-- markdownlint-disable-file MD051 -->
# How to create a list

To create a list, use the `Lists` endpoint.

## [RESTful REST API](#tab/lists-restful-rest)

```http
POST https://{{env}}.superoffice.com/{{tenant}}/api/v1/List HTTP/1.1
Authorization: Bearer {{token}}
Accept: application/json; charset=utf-8
Content-Type: application/json; charset=utf-8

{
  "Name": "My New List",
  "Tooltip": "My New list",
  "UseGroupsAndHeadings": false
}
```

**Response:**

```json
{
  "Id": 110,
  "Name": "My New List",
  "Tooltip": "My New list",
  "Deleted": false,
  "Rank": 0,
  "IsCustomList": false,
  "IsMDOList": false,
  "UseGroupsAndHeadings": false,
  "ListType": null,
  "InUseByUserDefinedFields": false,
  "TableRight": null,
  "FieldProperties": {},
  "_Links": {
    "Self": "https://sod.superoffice.com:443/Cust26759/api/v1/List/110/"
  }
}
```

## [HTTP RPC Agent API](#tab/lists-restful-agent)

Use the `CreateDefaultListEntity` to get the default list JSON structure, then use the SaveListEntity endpoint to persist the new list.

```http
POST https://{{env}}.superoffice.com/{{tenant}}/api/v1/Agents/List/CreateDefaultListEntity HTTP/1.1
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
  "Rank": 0,
  "IsCustomList": false,
  "IsMDOList": false,
  "UseGroupsAndHeadings": false,
  "ListType": null,
  "InUseByUserDefinedFields": false,
  "TableRight": null,
  "FieldProperties": {}
}
```

Save the list.

```http
POST https://{{env}}.superoffice.com/{{tenant}}/api/v1/Agents/List/SaveListEntity HTTP/1.1
Authorization: Bearer {{token}}
Accept: application/json; charset=utf-8
Content-Type: application/json

{
  "Name": "MyCustomList",
  "Tooltip": "A list to contain my custom items",
}
```

**Response:**

```json
Response
{
  "Id": 106,
  "Name": "MyCustomList",
  "Tooltip": "A list to contain my custom items",
  "Deleted": false,
  "Rank": 0,
  "IsCustomList": false,
  "IsMDOList": false,
  "UseGroupsAndHeadings": false,
  "ListType": null,
  "InUseByUserDefinedFields": false,
  "TableRight": null,
  "FieldProperties": {}
}
```

## [WebApi Proxy API](#tab/lists-webapi-proxy)

Create a list entity using the [SuperOffice.WebApi][1] proxy client.

```csharp
var config = new WebApiOptions(tenant.WebApiUrl);
config.Authorization = new AuthorizationAccessToken("8A:Cust12345.Example-Token", OnlineEnvironment.SOD);
var listAgent = new ListAgent(config);

var listEntity = await listAgent.CreateDefaultListEntityAsync();
listEntity.Name = "MyCustomList";
listEntity.Tooltip = "A list to contain my custom items";
listEntity = await listAgent.SaveListEntityAsync(listEntity);

```

***

[Back](index.md)

<!-- Link references -->

[1]: ../../../web-services/proxies/index.md
