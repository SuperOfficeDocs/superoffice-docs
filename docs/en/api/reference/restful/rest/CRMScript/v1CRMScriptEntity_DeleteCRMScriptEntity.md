---
title: DEL CRMScript/{id}
uid: v1CRMScriptEntity_DeleteCRMScriptEntity
generated: true
---

# DEL CRMScript/{id}

```http
DELETE /api/v1/CRMScript/{id}
```

Deletes the CRMScriptEntity


## Online Restricted: ## The CRMScript agent is not available in Online by default. Access must be requested specifically when app is registered. Calls the CRMScript agent service DeleteCRMScriptEntity.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The CRMScriptEntity to be deleted. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

CRMScriptEntity deleted.

| Response | Description |
|----------------|-------------|
| 204 | CRMScriptEntity deleted. |

### Response body: TimeZoneData


## Sample request

```http!
DELETE /api/v1/CRMScript/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 204 CRMScriptEntity deleted.
Content-Type: application/json; charset=utf-8

null
```