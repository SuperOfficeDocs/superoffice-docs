---
title: DEL DashTileDefinition/{id}
id: v1DashTileDefinition_DeleteDashTileDefinition
---

# DEL DashTileDefinition/{id}

```http
DELETE /api/v1/DashTileDefinition/{id}
```

Deletes the DashTileDefinition

Calls the Dash agent service DeleteDashTileDefinition.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The DashTileDefinition to be deleted. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response


| Response | Description |
|----------------|-------------|
| 204 | DashTileDefinition deleted. |