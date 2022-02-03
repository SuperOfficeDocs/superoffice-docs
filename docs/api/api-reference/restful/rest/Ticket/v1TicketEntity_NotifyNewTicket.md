---
title: POST Ticket/{id}/NotifyNewTicket
id: v1TicketEntity_NotifyNewTicket
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
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response


| Response | Description |
|----------------|-------------|
| 204 | No Content |