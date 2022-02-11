---
title: DEL Dashboard/{id}
id: v1Dashboard_DeleteDashboard
---

# DEL Dashboard/{id}

```http
DELETE /api/v1/Dashboard/{id}
```

Deletes the Dashboard

Calls the Dashboard agent service DeleteDashboard.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The Dashboard to be deleted. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response


| Response | Description |
|----------------|-------------|
| 204 | Dashboard deleted. |