---
title: DEL Ticket/{id}
uid: v1TicketEntity_DeleteTicketEntity
generated: true
content_type: reference
---

# DEL Ticket/{id}

```http
DELETE /api/v1/Ticket/{id}
```

Deletes the TicketEntity


Calls the Ticket agent service DeleteTicketEntity.
NsApiSlow threshold: 2000 ms.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The TicketEntity to be deleted. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

TicketEntity deleted.

| Response | Description |
|----------------|-------------|
| 204 | TicketEntity deleted. |

### Response body: TimeZoneData


## Sample request

[!include[sample request](../../samples/rest/request/v1TicketEntity_DeleteTicketEntity.md)]

## Sample response

[!include[sample response](../../samples/rest/response/v1TicketEntity_DeleteTicketEntity.md)]