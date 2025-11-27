---
title: POST Agents/User/DeleteUser
uid: v1UserAgent_DeleteUser
generated: true
content_type: reference
---

# POST Agents/User/DeleteUser

```http
POST /api/v1/Agents/User/DeleteUser
```

Deletes the User


NsApiSlow threshold: 2000 ms.


## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| userId | int32 | **Required** The identity of the User |

```http
POST /api/v1/Agents/User/DeleteUser?userId=247
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

[!include[sample request](../../samples/agent/request/v1UserAgent_DeleteUser.md)]

## Sample response

[!include[sample response](../../samples/agent/response/v1UserAgent_DeleteUser.md)]