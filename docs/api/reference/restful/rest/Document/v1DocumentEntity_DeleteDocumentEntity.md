---
title: DEL Document/{id}
id: v1DocumentEntity_DeleteDocumentEntity
---

# DEL Document/{id}

```http
DELETE /api/v1/Document/{id}
```

Deletes the DocumentEntity

Calls the Document agent service DeleteDocumentEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The DocumentEntity to be deleted. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response


| Response | Description |
|----------------|-------------|
| 204 | DocumentEntity deleted. |
| 412 | Delete aborted because DocumentEntity has changed since the requested If-Unmodified-Since timestamp. |