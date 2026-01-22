---
title: POST Agents/CRMScript/DeleteTriggerScriptEntity
uid: v1CRMScriptAgent_DeleteTriggerScriptEntity
generated: true
content_type: reference
---

# POST Agents/CRMScript/DeleteTriggerScriptEntity

```http
POST /api/v1/Agents/CRMScript/DeleteTriggerScriptEntity
```

Deletes the TriggerScriptEntity


NsApiSlow threshold: 5000 ms.


## Online Restricted: ## The CRMScript agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| triggerScriptEntityId | int32 | **Required** The identity of the TriggerScriptEntity |

```http
POST /api/v1/Agents/CRMScript/DeleteTriggerScriptEntity?triggerScriptEntityId=574
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

[!include[sample request](../../samples/agent/request/v1CRMScriptAgent_DeleteTriggerScriptEntity.md)]

## Sample response

[!include[sample response](../../samples/agent/response/v1CRMScriptAgent_DeleteTriggerScriptEntity.md)]