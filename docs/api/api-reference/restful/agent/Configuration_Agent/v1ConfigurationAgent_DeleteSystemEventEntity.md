---
title: POST Agents/Configuration/DeleteSystemEventEntity
id: v1ConfigurationAgent_DeleteSystemEventEntity
---

# POST Agents/Configuration/DeleteSystemEventEntity

```http
POST /api/v1/Agents/Configuration/DeleteSystemEventEntity
```

Deletes the SystemEventEntity







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| SystemEventEntityId | int32 | **Required** The id of the SystemEventEntity to be deleted. |

```http
POST /api/v1/Agents/Configuration/DeleteSystemEventEntity?SystemEventEntityId=273
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