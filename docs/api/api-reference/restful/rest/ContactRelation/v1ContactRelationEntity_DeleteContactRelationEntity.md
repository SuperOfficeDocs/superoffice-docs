---
title: DEL Relation/{id}
id: v1ContactRelationEntity_DeleteContactRelationEntity
---

# DEL Relation/{id}

```http
DELETE /api/v1/Relation/{id}
```

Deletes the ContactRelationEntity

Calls the Relation agent service DeleteContactRelation.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ContactRelationEntity to be deleted. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response


| Response | Description |
|----------------|-------------|
| 204 | ContactRelationEntity deleted. |
| 412 | Delete aborted because ContactRelationEntity has changed since the requested If-Unmodified-Since timestamp. |