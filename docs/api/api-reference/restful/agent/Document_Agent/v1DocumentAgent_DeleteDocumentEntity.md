---
title: DeleteDocumentEntity
id: v1DocumentAgent_DeleteDocumentEntity
---

# DeleteDocumentEntity

```http
POST /api/v1/Agents/Document/DeleteDocumentEntity
```

Deletes the DocumentEntity







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| DocumentEntityId | int32 | **Required** The id of the DocumentEntity to be deleted. |

```http
POST /api/v1/Agents/Document/DeleteDocumentEntity?DocumentEntityId=24
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