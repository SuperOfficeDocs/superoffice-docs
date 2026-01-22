---
title: POST Agents/Workflow/DeleteEmailFlow
uid: v1WorkflowAgent_DeleteEmailFlow
generated: true
content_type: reference
---

# POST Agents/Workflow/DeleteEmailFlow

```http
POST /api/v1/Agents/Workflow/DeleteEmailFlow
```

Deletes the EmailFlow


NsApiSlow threshold: 2000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| emailFlowId | int32 | **Required** The identity of the EmailFlow |

```http
POST /api/v1/Agents/Workflow/DeleteEmailFlow?emailFlowId=537
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

[!include[sample request](../../samples/agent/request/v1WorkflowAgent_DeleteEmailFlow.md)]

## Sample response

[!include[sample response](../../samples/agent/response/v1WorkflowAgent_DeleteEmailFlow.md)]