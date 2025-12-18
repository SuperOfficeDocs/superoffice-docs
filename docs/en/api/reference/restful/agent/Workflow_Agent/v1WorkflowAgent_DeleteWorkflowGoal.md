---
title: POST Agents/Workflow/DeleteWorkflowGoal
uid: v1WorkflowAgent_DeleteWorkflowGoal
generated: true
content_type: reference
---

# POST Agents/Workflow/DeleteWorkflowGoal

```http
POST /api/v1/Agents/Workflow/DeleteWorkflowGoal
```

Deletes the WorkflowGoal


NsApiSlow threshold: 1500 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| workflowGoalId | int32 | **Required** The identity of the WorkflowGoal |

```http
POST /api/v1/Agents/Workflow/DeleteWorkflowGoal?workflowGoalId=695
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

[!include[sample request](../../samples/agent/request/v1WorkflowAgent_DeleteWorkflowGoal.md)]

## Sample response

[!include[sample response](../../samples/agent/response/v1WorkflowAgent_DeleteWorkflowGoal.md)]