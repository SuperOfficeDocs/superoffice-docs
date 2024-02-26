---
title: DEL TicketMessage/{id}
uid: v1TicketMessageEntity_DeleteTicketMessageEntity
generated: true
---

# DEL TicketMessage/{id}

```http
DELETE /api/v1/TicketMessage/{id}
```

Deletes the TicketMessageEntity


Calls the Ticket agent service DeleteTicketMessageEntity.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The TicketMessageEntity to be deleted. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

TicketMessageEntity deleted.

| Response | Description |
|----------------|-------------|
| 204 | TicketMessageEntity deleted. |

### Response body: TimeZoneData


## Sample request

```http!
DELETE /api/v1/TicketMessage/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 204 TicketMessageEntity deleted.
Content-Type: application/json; charset=utf-8

null
```