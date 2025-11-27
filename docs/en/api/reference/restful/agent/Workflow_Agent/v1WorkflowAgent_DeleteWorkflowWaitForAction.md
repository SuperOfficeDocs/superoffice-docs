---
title: POST Agents/Workflow/DeleteWorkflowWaitForAction
uid: v1WorkflowAgent_DeleteWorkflowWaitForAction
generated: true
content_type: reference
---

# POST Agents/Workflow/DeleteWorkflowWaitForAction

```http
POST /api/v1/Agents/Workflow/DeleteWorkflowWaitForAction
```

Deletes the WorkflowWaitForAction


NsApiSlow threshold: 1000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| workflowWaitForActionId | int32 | **Required** The identity of the WorkflowWaitForAction |

```http
POST /api/v1/Agents/Workflow/DeleteWorkflowWaitForAction?workflowWaitForActionId=290
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

[!include[sample request](../../samples/agent/request/v1WorkflowAgent_DeleteWorkflowWaitForAction.md)]

## Sample response

[!include[sample response](../../samples/agent/response/v1WorkflowAgent_DeleteWorkflowWaitForAction.md)]