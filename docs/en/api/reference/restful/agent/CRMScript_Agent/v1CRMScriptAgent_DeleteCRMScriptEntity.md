---
title: POST Agents/CRMScript/DeleteCRMScriptEntity
uid: v1CRMScriptAgent_DeleteCRMScriptEntity
generated: true
content_type: reference
---

# POST Agents/CRMScript/DeleteCRMScriptEntity

```http
POST /api/v1/Agents/CRMScript/DeleteCRMScriptEntity
```

Deletes the CRMScriptEntity


NsApiSlow threshold: 5000 ms.


## Online Restricted: ## The CRMScript agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| cRMScriptEntityId | int32 | **Required** The identity of the CRMScriptEntity |

```http
POST /api/v1/Agents/CRMScript/DeleteCRMScriptEntity?cRMScriptEntityId=611
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

[!include[sample request](../../samples/agent/request/v1CRMScriptAgent_DeleteCRMScriptEntity.md)]

## Sample response

[!include[sample response](../../samples/agent/response/v1CRMScriptAgent_DeleteCRMScriptEntity.md)]