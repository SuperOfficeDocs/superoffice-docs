---
title: POST Agents/Contact/DeleteContactEntity
id: v1ContactAgent_DeleteContactEntity
---

# POST Agents/Contact/DeleteContactEntity

```http
POST /api/v1/Agents/Contact/DeleteContactEntity
```

Deletes the ContactEntity







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| ContactEntityId | int32 | **Required** The id of the ContactEntity to be deleted. |

```http
POST /api/v1/Agents/Contact/DeleteContactEntity?ContactEntityId=49
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