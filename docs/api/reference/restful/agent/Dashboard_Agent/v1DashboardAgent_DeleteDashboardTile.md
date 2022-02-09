---
title: POST Agents/Dashboard/DeleteDashboardTile
id: v1DashboardAgent_DeleteDashboardTile
---

# POST Agents/Dashboard/DeleteDashboardTile

```http
POST /api/v1/Agents/Dashboard/DeleteDashboardTile
```

Deletes the DashboardTile







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| DashboardTileId | int32 | **Required** The id of the DashboardTile to be deleted. |

```http
POST /api/v1/Agents/Dashboard/DeleteDashboardTile?DashboardTileId=503
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