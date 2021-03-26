---
title: DEL List/TicketStatus/Items/{id}
id: v1TicketStatusList_DeleteTicketStatusEntity
---

# DEL List/TicketStatus/Items/{id}

```http
DELETE /api/v1/List/TicketStatus/Items/{id}
```

Marks the existing TicketStatusEntity as deleted.

Calls the List agent service SaveTicketStatusEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of TicketStatusEntity to be marked as deleted. **Required** |



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