---
title: POST Agents/Dash/DeleteDashTileDefinition
id: v1DashAgent_DeleteDashTileDefinition
---

# POST Agents/Dash/DeleteDashTileDefinition

```http
POST /api/v1/Agents/Dash/DeleteDashTileDefinition
```

Deletes the DashTileDefinition







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| DashTileDefinitionId | int32 | **Required** The id of the DashTileDefinition to be deleted. |

```http
POST /api/v1/Agents/Dash/DeleteDashTileDefinition?DashTileDefinitionId=631
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