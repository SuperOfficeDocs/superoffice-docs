---
title: DEL Role/{roleIdToDelete}
uid: v1RoleEntity_DeleteRole
generated: true
content_type: reference
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
DELETE /api/v1/Role/{roleIdToDelete}?replacingRoleId=630
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

### Response body: TimeZoneData


## Sample request

[!include[sample request](../../samples/rest/request/v1RoleEntity_DeleteRole.md)]

## Sample response

[!include[sample response](../../samples/rest/response/v1RoleEntity_DeleteRole.md)]