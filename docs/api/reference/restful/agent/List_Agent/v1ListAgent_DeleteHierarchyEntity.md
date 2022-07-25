---
title: POST Agents/List/DeleteHierarchyEntity
id: v1ListAgent_DeleteHierarchyEntity
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
POST /api/v1/Agents/List/DeleteHierarchyEntity?HierarchyEntityId=332
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
