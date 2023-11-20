---
title: POST Agents/Favourite/AddFavourites
uid: v1FavouriteAgent_AddFavourites
generated: true
---

# POST Agents/Favourite/AddFavourites

```http
POST /api/v1/Agents/Favourite/AddFavourites
```

Add a list of record ids as favourites for an associate







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Favourite/AddFavourites?$select=name,department,category/id
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

TableName, RecordIds, AssociateId, ExtraInfo 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TableName | String |  |
| RecordIds | Array |  |
| AssociateId | Integer |  |
| ExtraInfo | String |  |

## Response:

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

### Response body: TimeZoneData


## Sample request

```http!
POST /api/v1/Agents/Favourite/AddFavourites
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TableName": "Lindgren Inc and Sons",
  "RecordIds": [
    789,
    995
  ],
  "AssociateId": 607,
  "ExtraInfo": "deserunt"
}
```

## Sample response

```http_
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```