---
title: DEL User/{userName}
id: v1User_DeleteUserFromName
---

# DEL User/{userName}

```http
DELETE /api/v1/User/{userName}
```

Delete a user, with lookup based on the user name.



## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.




| Path Part | Type | Description |
|-----------|------|-------------|
| userName | string | User name of the user to delete. **Required** |



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