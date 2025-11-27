---
title: DEL CRMScript/{id}
uid: v1CRMScriptEntity_DeleteCRMScriptEntity
generated: true
content_type: reference
---

# DEL CRMScript/{id}

```http
DELETE /api/v1/CRMScript/{id}
```

Deletes the CRMScriptEntity


## Online Restricted: ## The CRMScript agent is not available in Online by default. Access must be requested specifically when app is registered. Calls the CRMScript agent service DeleteCRMScriptEntity.
NsApiSlow threshold: 5000 ms.





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

[!include[sample request](../../samples/rest/request/v1CRMScriptEntity_DeleteCRMScriptEntity.md)]

## Sample response

[!include[sample response](../../samples/rest/response/v1CRMScriptEntity_DeleteCRMScriptEntity.md)]