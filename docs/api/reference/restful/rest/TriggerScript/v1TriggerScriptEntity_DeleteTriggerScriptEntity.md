---
title: DEL TriggerScript/{id}
uid: v1TriggerScriptEntity_DeleteTriggerScriptEntity
---

# DEL TriggerScript/{id}

```http
DELETE /api/v1/TriggerScript/{id}
```

Deletes the TriggerScriptEntity

## Online Restricted: ## The CRMScript agent is not available in Online by default. Access must be requested specifically when app is registered. Calls the CRMScript agent service DeleteTriggerScriptEntity

| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The TriggerScriptEntity to be deleted. **Required** |

## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Response

TriggerScriptEntity deleted.

| Response | Description |
|----------------|-------------|
| 204 | TriggerScriptEntity deleted. |

Response body:

## Sample request

```http!
DELETE /api/v1/TriggerScript/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 204 TriggerScriptEntity deleted.
Content-Type: application/json; charset=utf-8

null
```
