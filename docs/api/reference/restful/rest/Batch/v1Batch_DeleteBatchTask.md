---
title: DEL BatchTask/{id}
id: v1Batch_DeleteBatchTask
---

# DEL BatchTask/{id}

```http
DELETE /api/v1/BatchTask/{batchTaskId}
```

Delete a batch task from the database.

| Path Part | Type | Description |
|-----------|------|-------------|
| batchTaskId | int32 | The batchTask ids to delete. **Required** |

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
