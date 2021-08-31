---
title: DeleteResourceEntity
id: v1ListAgent_DeleteResourceEntity
---

# DeleteResourceEntity

```http
POST /api/v1/Agents/List/DeleteResourceEntity
```

Deletes the ResourceEntity







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| ResourceEntityId | int32 | **Required** The id of the ResourceEntity to be deleted. |

```http
POST /api/v1/Agents/List/DeleteResourceEntity?ResourceEntityId=597
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