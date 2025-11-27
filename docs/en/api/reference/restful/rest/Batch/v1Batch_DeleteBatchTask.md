---
title: DEL BatchTask/{id}
uid: v1Batch_DeleteBatchTask
generated: true
content_type: reference
---

# DEL BatchTask/{id}

```http
DELETE /api/v1/BatchTask/{batchTaskId}
```

Delete a batch task from the database.






| Path Part | Type | Description |
|-----------|------|-------------|
| batchTaskId | int32 | The batchTask id to delete. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

### Response body: TimeZoneData


## Sample request

[!include[sample request](../../samples/rest/request/v1Batch_DeleteBatchTask.md)]

## Sample response

[!include[sample response](../../samples/rest/response/v1Batch_DeleteBatchTask.md)]