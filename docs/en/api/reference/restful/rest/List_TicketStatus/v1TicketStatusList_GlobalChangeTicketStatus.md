---
title: GET List/TicketStatus/{id}/ChangeTo/{id}
uid: v1TicketStatusList_GlobalChangeTicketStatus
generated: true
---

# GET List/TicketStatus/{id}/ChangeTo/{id}

```http
GET /api/v1/List/TicketStatus/{fromTicketStatusId}/ChangeTo/{toTicketStatusId}
```

This method will change all references from one ticket status to another.


Typically used in conjuction with delete





| Path Part | Type | Description |
|-----------|------|-------------|
| fromTicketStatusId | int32 | The id of the ticket status to change from **Required** |
| toTicketStatusId | int32 | The id of the ticket status to change to **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

### Response body: TimeZoneData


## Sample request

```http!
GET /api/v1/List/TicketStatus/{fromTicketStatusId}/ChangeTo/{toTicketStatusId}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```