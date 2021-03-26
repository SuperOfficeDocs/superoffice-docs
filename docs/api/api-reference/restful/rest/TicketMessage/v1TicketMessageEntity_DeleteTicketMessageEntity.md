---
title: DEL TicketMessage/{id}
id: v1TicketMessageEntity_DeleteTicketMessageEntity
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
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response


| Response | Description |
|----------------|-------------|
| 204 | TicketMessageEntity deleted. |