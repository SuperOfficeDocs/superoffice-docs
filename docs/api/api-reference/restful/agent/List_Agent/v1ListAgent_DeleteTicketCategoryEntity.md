---
title: POST Agents/List/DeleteTicketCategoryEntity
id: v1ListAgent_DeleteTicketCategoryEntity
---

# POST Agents/List/DeleteTicketCategoryEntity

```http
POST /api/v1/Agents/List/DeleteTicketCategoryEntity
```

Deletes the TicketCategoryEntity







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| TicketCategoryEntityId | int32 | **Required** The id of the TicketCategoryEntity to be deleted. |

```http
POST /api/v1/Agents/List/DeleteTicketCategoryEntity?TicketCategoryEntityId=906
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