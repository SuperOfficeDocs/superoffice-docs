---
title: DeleteForeignAppEntity
id: v1ForeignSystemAgent_DeleteForeignAppEntity
---

# DeleteForeignAppEntity

```http
POST /api/v1/Agents/ForeignSystem/DeleteForeignAppEntity
```

Deletes the ForeignAppEntity







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| ForeignAppEntityId | int32 | **Required** The id of the ForeignAppEntity to be deleted. |

```http
POST /api/v1/Agents/ForeignSystem/DeleteForeignAppEntity?ForeignAppEntityId=701
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