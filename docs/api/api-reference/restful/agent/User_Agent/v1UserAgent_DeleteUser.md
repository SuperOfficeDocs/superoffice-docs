---
title: POST Agents/User/DeleteUser
id: v1UserAgent_DeleteUser
---

# POST Agents/User/DeleteUser

```http
POST /api/v1/Agents/User/DeleteUser
```

Deletes the User



## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| UserId | int32 | **Required** The id of the User to be deleted. |

```http
POST /api/v1/Agents/User/DeleteUser?UserId=253
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