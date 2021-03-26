---
title: POST Agents/Dashboard/DeleteDashboard
id: v1DashboardAgent_DeleteDashboard
---

# POST Agents/Dashboard/DeleteDashboard

```http
POST /api/v1/Agents/Dashboard/DeleteDashboard
```

Deletes the Dashboard







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| DashboardId | int32 | **Required** The id of the Dashboard to be deleted. |

```http
POST /api/v1/Agents/Dashboard/DeleteDashboard?DashboardId=246
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