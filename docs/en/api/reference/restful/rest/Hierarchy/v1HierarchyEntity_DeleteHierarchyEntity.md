---
title: DEL Hierarchy/{id}
uid: v1HierarchyEntity_DeleteHierarchyEntity
generated: true
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
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

HierarchyEntity deleted.

| Response | Description |
|----------------|-------------|
| 204 | HierarchyEntity deleted. |

### Response body: TimeZoneData


## Sample request

```http!
DELETE /api/v1/Hierarchy/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 204 HierarchyEntity deleted.
Content-Type: application/json; charset=utf-8

null
```