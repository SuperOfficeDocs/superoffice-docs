---
title: POST Agents/Project/DeleteProjectEventEntity
id: v1ProjectAgent_DeleteProjectEventEntity
---

# POST Agents/Project/DeleteProjectEventEntity

```http
POST /api/v1/Agents/Project/DeleteProjectEventEntity
```

Deletes the ProjectEventEntity







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| ProjectEventEntityId | int32 | **Required** The id of the ProjectEventEntity to be deleted. |

```http
POST /api/v1/Agents/Project/DeleteProjectEventEntity?ProjectEventEntityId=826
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