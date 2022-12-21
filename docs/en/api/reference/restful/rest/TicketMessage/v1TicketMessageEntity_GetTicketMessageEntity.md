---
title: GET TicketMessage/{id}
uid: v1TicketMessageEntity_GetTicketMessageEntity
---

# GET TicketMessage/{id}

```http
GET /api/v1/TicketMessage/{id}
```

Gets a TicketMessageEntity object.

Calls the Ticket agent service GetTicketMessageEntity.

| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the TicketMessageEntity to return. **Required** |

## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |
| fk | bool |  Load foreign keys on this entity into the ExtraFields property as 'app.device.keyname'='123' pairs. |

```http
GET /api/v1/TicketMessage/{id}?$select=name,department,category/id
GET /api/v1/TicketMessage/{id}?fk=False
```

## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Response

TicketMessageEntity found.

| Response | Description |
|----------------|-------------|
| 200 | TicketMessageEntity found. |
| 404 | Not Found. |

Response body:

## Sample request

```http!
GET /api/v1/TicketMessage/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 TicketMessageEntity found.
Content-Type: application/json; charset=utf-8

"ipsa"
```
