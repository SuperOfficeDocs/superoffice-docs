---
title: POST Ticket/{id}/NotifyNewTicket
uid: v1TicketEntity_NotifyNewTicket
generated: true
content_type: reference
---

# POST Ticket/{id}/NotifyNewTicket

```http
POST /api/v1/Ticket/{ticketEntityId}/NotifyNewTicket
```

Notify user agents about the creation of a new ticket






| Path Part | Type | Description |
|-----------|------|-------------|
| ticketEntityId | int32 | The id of the ticket to notify about **Required** |



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
POST /api/v1/Ticket/{ticketEntityId}/NotifyNewTicket
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```