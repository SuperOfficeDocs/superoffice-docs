---
title: POST Agents/List/DeleteListEntity
id: v1ListAgent_DeleteListEntity
---

# POST Agents/List/DeleteListEntity

```http
POST /api/v1/Agents/List/DeleteListEntity
```

Deletes the ListEntity







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| ListEntityId | int32 | **Required** The id of the ListEntity to be deleted. |

```http
POST /api/v1/Agents/List/DeleteListEntity?ListEntityId=917
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