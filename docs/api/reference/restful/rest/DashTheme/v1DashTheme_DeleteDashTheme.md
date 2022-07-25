---
title: DEL DashTheme/{id}
id: v1DashTheme_DeleteDashTheme
---

# DEL DashTheme/{id}

```http
DELETE /api/v1/DashTheme/{id}
```

Deletes the DashTheme

Calls the Dash agent service DeleteDashTheme.

| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The DashTheme to be deleted. **Required** |

## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Response

| Response | Description |
|----------------|-------------|
| 204 | DashTheme deleted. |
