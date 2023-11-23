---
title: POST Agents/Ticket/GetTicketSummaries
uid: v1TicketAgent_GetTicketSummaries
generated: true
---

# POST Agents/Ticket/GetTicketSummaries

```http
POST /api/v1/Agents/Ticket/GetTicketSummaries
```

Get an array of summaryitem for the given tickets







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/GetTicketSummaries?$select=name,department,category/id
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

TicketIds 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketIds | Array |  |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketId | int32 | The primary key (auto-incremented) |
| TicketStatus | int32 | User defined ticket status |
| Title | string | The title of the ticket. |
| Registered | date-time | When the ticket was created. |
| IconHint | string | Icon representing ticket's state |

## Sample request

```http!
POST /api/v1/Agents/Ticket/GetTicketSummaries
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketIds": [
    938,
    197
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "TicketId": 816,
    "TicketStatus": 163,
    "Title": "quia",
    "Registered": "1997-08-07T13:38:14.3115522+02:00",
    "IconHint": "soluta"
  },
  {
    "TicketId": 816,
    "TicketStatus": 163,
    "Title": "quia",
    "Registered": "1997-08-07T13:38:14.3115522+02:00",
    "IconHint": "soluta"
  }
]
```