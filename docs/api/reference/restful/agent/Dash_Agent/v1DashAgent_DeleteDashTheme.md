---
title: POST Agents/Dash/DeleteDashTheme
id: v1DashAgent_DeleteDashTheme
---

# POST Agents/Dash/DeleteDashTheme

```http
POST /api/v1/Agents/Dash/DeleteDashTheme
```

Deletes the DashTheme







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| DashThemeId | int32 | **Required** The id of the DashTheme to be deleted. |

```http
POST /api/v1/Agents/Dash/DeleteDashTheme?DashThemeId=756
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