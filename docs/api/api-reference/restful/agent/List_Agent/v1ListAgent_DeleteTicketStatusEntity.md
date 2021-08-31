---
title: DeleteTicketStatusEntity
id: v1ListAgent_DeleteTicketStatusEntity
---

# DeleteTicketStatusEntity

```http
POST /api/v1/Agents/List/DeleteTicketStatusEntity
```

Deletes the TicketStatusEntity







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| TicketStatusEntityId | int32 | **Required** The id of the TicketStatusEntity to be deleted. |

```http
POST /api/v1/Agents/List/DeleteTicketStatusEntity?TicketStatusEntityId=481
```


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