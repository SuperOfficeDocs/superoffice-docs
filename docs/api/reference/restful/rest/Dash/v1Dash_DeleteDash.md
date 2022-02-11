---
title: DEL Dash/{id}
id: v1Dash_DeleteDash
---

# DEL Dash/{id}

```http
DELETE /api/v1/Dash/{id}
```

Deletes the Dash

Calls the Dash agent service DeleteDash.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The Dash to be deleted. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response


| Response | Description |
|----------------|-------------|
| 204 | Dash deleted. |