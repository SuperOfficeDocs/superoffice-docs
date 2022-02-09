---
title: DEL Selection/{id}
id: v1SelectionEntity_DeleteSelectionEntity
---

# DEL Selection/{id}

```http
DELETE /api/v1/Selection/{id}
```

Deletes the SelectionEntity

Calls the Selection agent service DeleteSelectionEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The SelectionEntity to be deleted. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response


| Response | Description |
|----------------|-------------|
| 204 | SelectionEntity deleted. |
| 412 | Delete aborted because SelectionEntity has changed since the requested If-Unmodified-Since timestamp. |