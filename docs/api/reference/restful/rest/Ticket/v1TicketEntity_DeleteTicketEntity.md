---
title: DEL Ticket/{id}
id: v1TicketEntity_DeleteTicketEntity
---

# DEL Ticket/{id}

```http
DELETE /api/v1/Ticket/{id}
```

Deletes the TicketEntity

Calls the Ticket agent service DeleteTicketEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The TicketEntity to be deleted. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response


| Response | Description |
|----------------|-------------|
| 204 | TicketEntity deleted. |