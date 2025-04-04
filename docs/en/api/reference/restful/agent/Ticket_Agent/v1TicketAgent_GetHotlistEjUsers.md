---
title: POST Agents/Ticket/GetHotlistEjUsers
uid: v1TicketAgent_GetHotlistEjUsers
generated: true
---

# POST Agents/Ticket/GetHotlistEjUsers

```http
POST /api/v1/Agents/Ticket/GetHotlistEjUsers
```

Get a list of ej_user ids who should receive hotlist notification based on request and notification type







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/GetHotlistEjUsers?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request 

TicketId, SkipAssociateIds, NotifyType, Channel 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketId | Integer |  |
| SkipAssociateIds | Array |  |
| NotifyType | String |  |
| Channel | String |  |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array


## Sample request

```http!
POST /api/v1/Agents/Ticket/GetHotlistEjUsers
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "TicketId": 818,
  "SkipAssociateIds": [
    717,
    617
  ],
  "NotifyType": "ActiveTickets",
  "Channel": "Email"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  503,
  246
]
```