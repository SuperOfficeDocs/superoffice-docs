---
title: DEL ForeignApp/{id}
id: v1ForeignAppEntity_DeleteForeignAppEntity
---

# DEL ForeignApp/{id}

```http
DELETE /api/v1/ForeignApp/{id}
```

Deletes the ForeignAppEntity

Calls the ForeignSystem agent service DeleteForeignAppEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ForeignAppEntity to be deleted. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response


| Response | Description |
|----------------|-------------|
| 204 | ForeignAppEntity deleted. |
| 412 | Delete aborted because ForeignAppEntity has changed since the requested If-Unmodified-Since timestamp. |