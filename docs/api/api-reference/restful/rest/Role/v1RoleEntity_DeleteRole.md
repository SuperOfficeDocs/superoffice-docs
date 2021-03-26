---
title: DEL Role/{roleIdToDelete}
id: v1RoleEntity_DeleteRole
---

# DEL Role/{roleIdToDelete}

```http
DELETE /api/v1/Role/{roleIdToDelete}
```

Delete the specified role and move all users associated with the role to the replacingRoleId



## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.




| Path Part | Type | Description |
|-----------|------|-------------|
| roleIdToDelete | int32 | The roleId to delete **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| replacingRoleId | int32 |  The roleId which all associated users will be moved to. |

```http
DELETE /api/v1/Role/{roleIdToDelete}?replacingRoleId=231
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