---
title: POST Agents/AI/DeleteCopilotEntity
uid: v1AIAgent_DeleteCopilotEntity
generated: true
content_type: reference
---

# POST Agents/AI/DeleteCopilotEntity

```http
POST /api/v1/Agents/AI/DeleteCopilotEntity
```

Deletes the CopilotEntity


NsApiSlow threshold: 1000 ms.


## Experimental: ## The AI agent is experimental, subject to change, and not intended for partners.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| copilotEntityId | int32 | **Required** The identity of the CopilotEntity |

```http
POST /api/v1/Agents/AI/DeleteCopilotEntity?copilotEntityId=958
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

[!include[sample request](../../samples/agent/request/v1AIAgent_DeleteCopilotEntity.md)]

## Sample response

[!include[sample response](../../samples/agent/response/v1AIAgent_DeleteCopilotEntity.md)]