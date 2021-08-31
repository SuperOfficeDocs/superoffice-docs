---
title: DeletePersonEntity
id: v1PersonAgent_DeletePersonEntity
---

# DeletePersonEntity

```http
POST /api/v1/Agents/Person/DeletePersonEntity
```

Deletes the PersonEntity







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| PersonEntityId | int32 | **Required** The id of the PersonEntity to be deleted. |

```http
POST /api/v1/Agents/Person/DeletePersonEntity?PersonEntityId=566
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