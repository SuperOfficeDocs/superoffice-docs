---
title: GET List/TicketStatus/{id}/ChangeTo/{id}
id: v1TicketStatusList_GlobalChangeTicketStatus
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
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response


| Response | Description |
|----------------|-------------|
| 204 | No Content |