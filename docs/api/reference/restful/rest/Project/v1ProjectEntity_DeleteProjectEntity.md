---
title: DEL Project/{id}
id: v1ProjectEntity_DeleteProjectEntity
---

# DEL Project/{id}

```http
DELETE /api/v1/Project/{id}
```

Deletes the ProjectEntity

Calls the Project agent service DeleteProjectEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ProjectEntity to be deleted. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response


| Response | Description |
|----------------|-------------|
| 204 | ProjectEntity deleted. |
| 412 | Delete aborted because ProjectEntity has changed since the requested If-Unmodified-Since timestamp. |