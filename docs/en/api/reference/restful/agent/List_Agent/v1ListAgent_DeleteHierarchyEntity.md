---
title: POST Agents/List/DeleteHierarchyEntity
uid: v1ListAgent_DeleteHierarchyEntity
generated: true
---

# POST Agents/List/DeleteHierarchyEntity

```http
POST /api/v1/Agents/List/DeleteHierarchyEntity
```

Deletes the HierarchyEntity







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| HierarchyEntityId | int32 | **Required** The id of the HierarchyEntity to be deleted. |

```http
POST /api/v1/Agents/List/DeleteHierarchyEntity?HierarchyEntityId=543
```


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

```http!
POST /api/v1/Agents/List/DeleteHierarchyEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```