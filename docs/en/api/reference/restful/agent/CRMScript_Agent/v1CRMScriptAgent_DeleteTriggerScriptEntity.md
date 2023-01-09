---
title: POST Agents/CRMScript/DeleteTriggerScriptEntity
uid: v1CRMScriptAgent_DeleteTriggerScriptEntity
---

# POST Agents/CRMScript/DeleteTriggerScriptEntity

```http
POST /api/v1/Agents/CRMScript/DeleteTriggerScriptEntity
```

Deletes the TriggerScriptEntity


## Online Restricted: ## The CRMScript agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| TriggerScriptEntityId | int32 | **Required** The id of the TriggerScriptEntity to be deleted. |

```http
POST /api/v1/Agents/CRMScript/DeleteTriggerScriptEntity?TriggerScriptEntityId=560
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

### Response body: TableRight


## Sample request

```http!
POST /api/v1/Agents/CRMScript/DeleteTriggerScriptEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```