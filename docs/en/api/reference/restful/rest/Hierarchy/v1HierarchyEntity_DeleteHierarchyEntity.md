---
title: DEL Hierarchy/{id}
uid: v1HierarchyEntity_DeleteHierarchyEntity
generated: true
content_type: reference
---

# DEL Hierarchy/{id}

```http
DELETE /api/v1/Hierarchy/{id}
```

Deletes the HierarchyEntity


Calls the List agent service DeleteHierarchyEntity.
NsApiSlow threshold: 5000 ms.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The HierarchyEntity to be deleted. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

HierarchyEntity deleted.

| Response | Description |
|----------------|-------------|
| 204 | HierarchyEntity deleted. |

### Response body: TimeZoneData


## Sample request

[!include[sample request](../../samples/rest/request/v1HierarchyEntity_DeleteHierarchyEntity.md)]

## Sample response

[!include[sample response](../../samples/rest/response/v1HierarchyEntity_DeleteHierarchyEntity.md)]