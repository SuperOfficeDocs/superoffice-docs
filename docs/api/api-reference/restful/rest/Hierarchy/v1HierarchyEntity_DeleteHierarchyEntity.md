---
title: DEL Hierarchy/{id}
id: v1HierarchyEntity_DeleteHierarchyEntity
---

# DEL Hierarchy/{id}

```http
DELETE /api/v1/Hierarchy/{id}
```

Deletes the HierarchyEntity

Calls the List agent service DeleteHierarchyEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The HierarchyEntity to be deleted. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response


| Response | Description |
|----------------|-------------|
| 204 | HierarchyEntity deleted. |