---
title: DeleteSelectionEntity
id: v1SelectionAgent_DeleteSelectionEntity
---

# DeleteSelectionEntity

```http
POST /api/v1/Agents/Selection/DeleteSelectionEntity
```

Deletes the SelectionEntity







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| SelectionEntityId | int32 | **Required** The id of the SelectionEntity to be deleted. |

```http
POST /api/v1/Agents/Selection/DeleteSelectionEntity?SelectionEntityId=251
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