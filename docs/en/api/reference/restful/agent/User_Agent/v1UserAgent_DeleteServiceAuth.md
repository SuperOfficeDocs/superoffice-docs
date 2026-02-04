---
title: POST Agents/User/DeleteServiceAuth
uid: v1UserAgent_DeleteServiceAuth
generated: true
content_type: reference
---

# POST Agents/User/DeleteServiceAuth

```http
POST /api/v1/Agents/User/DeleteServiceAuth
```

Deletes the ServiceAuth


NsApiSlow threshold: 1000 ms.


## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| serviceAuthId | int32 | **Required** The identity of the ServiceAuth |

```http
POST /api/v1/Agents/User/DeleteServiceAuth?serviceAuthId=213
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

[!include[sample request](../../samples/agent/request/v1UserAgent_DeleteServiceAuth.md)]

## Sample response

[!include[sample response](../../samples/agent/response/v1UserAgent_DeleteServiceAuth.md)]