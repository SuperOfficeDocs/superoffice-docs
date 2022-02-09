---
title: PUT Role/{id}/FunctionRight
id: v1RoleEntity_SetFunctionalRights
---

# PUT Role/{id}/FunctionRight

```http
PUT /api/v1/Role/{roleId}/FunctionRight
```

Set all functional rights for the given role.

Functional rights not specified here will be removed from the role. 


## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.




| Path Part | Type | Description |
|-----------|------|-------------|
| roleId | int32 | The role id to set the functional rights for **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: functionalRightIds  

An array of functional rights ids to set for this role. Rights not included here are removed from the role. 



## Response


| Response | Description |
|----------------|-------------|
| 204 | No Content |