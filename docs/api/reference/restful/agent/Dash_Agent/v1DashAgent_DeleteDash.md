---
title: POST Agents/Dash/DeleteDash
id: v1DashAgent_DeleteDash
---

# POST Agents/Dash/DeleteDash

```http
POST /api/v1/Agents/Dash/DeleteDash
```

Deletes the Dash







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| DashId | int32 | **Required** The id of the Dash to be deleted. |

```http
POST /api/v1/Agents/Dash/DeleteDash?DashId=378
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