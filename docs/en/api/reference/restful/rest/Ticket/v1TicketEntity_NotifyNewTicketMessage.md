---
title: POST Ticket/{id}/NotifyNewMessage
uid: v1TicketEntity_NotifyNewTicketMessage
generated: true
---

# POST Ticket/{id}/NotifyNewMessage

```http
POST /api/v1/Ticket/{ticketEntityId}/NotifyNewMessage
```

Notify user agents about the creation of a new message on a ticket






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
POST /api/v1/Ticket/{ticketEntityId}/NotifyNewMessage
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