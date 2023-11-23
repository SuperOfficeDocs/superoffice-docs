---
title: POST Agents/List/UpdateCategoryMemberships
uid: v1ListAgent_UpdateCategoryMemberships
generated: true
---

# POST Agents/List/UpdateCategoryMemberships

```http
POST /api/v1/Agents/List/UpdateCategoryMemberships
```

Updates category memberships







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/List/UpdateCategoryMemberships?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request 

TicketCategoryId, MembershipsToAdd, MembershipsToUpdate, MembershipsToDelete 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketCategoryId | Integer |  |
| MembershipsToAdd | Array |  |
| MembershipsToUpdate | Array |  |
| MembershipsToDelete | Array |  |

## Response:

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

### Response body: TimeZoneData


## Sample request

```http!
POST /api/v1/Agents/List/UpdateCategoryMemberships
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "TicketCategoryId": 256,
  "MembershipsToAdd": [
    {
      "User": null,
      "Weight": 672
    },
    {
      "User": null,
      "Weight": 672
    }
  ],
  "MembershipsToUpdate": [
    {
      "User": null,
      "Weight": 424
    },
    {
      "User": null,
      "Weight": 424
    }
  ],
  "MembershipsToDelete": [
    {
      "User": null,
      "Weight": 765
    },
    {
      "User": null,
      "Weight": 765
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```