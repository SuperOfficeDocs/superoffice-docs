---
title: POST Agents/Project/DeleteProjectEntity
id: v1ProjectAgent_DeleteProjectEntity
---

# POST Agents/Project/DeleteProjectEntity

```http
POST /api/v1/Agents/Project/DeleteProjectEntity
```

Deletes the ProjectEntity







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| ProjectEntityId | int32 | **Required** The id of the ProjectEntity to be deleted. |

```http
POST /api/v1/Agents/Project/DeleteProjectEntity?ProjectEntityId=253
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