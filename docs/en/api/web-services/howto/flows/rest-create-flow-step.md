---
uid: api-rest-flow-create-step
title: Create a Step object
description: Create a Step object
keywords: flow, EmailFlow, step, CreateDefaultWorkflowStepFromType, WorkflowStepId, StepType
author: Eivind Fasting
date: 05.24.2024
version: 10.3.5
content_type: howto
audience: api
audience_tooltip: SuperOffice APIs and database
redirect_from: /en/api/netserver/web-services/howto/flows/rest-create-flow-step
---

# Create a Step object

Use the [CreateDefaultWorkflowStepFromType][1] REST endpoint to generate a new carrier with default settings, based on the [type of step][2]. This endpoint returns a pre-populated `Step` object configured with values corresponding to the selected `StepType`.

Similar to triggers, `WorkflowStepId` and `WorkflowId` are automatically assigned by the system upon creation and are not mandatory. These properties are excluded in the examples.

> [!NOTE]
> If no Rank is specified in the Step object, the system will determine the Rank automatically based on the order of elements in the object.

## Request

```http
POST https://{{env}}.superoffice.com/{{tenant}}/v1/Agents/Workflow/CreateDefaultWorkflowStepFromType HTTP/1.1
Authorization: Bearer {{access_token}}
Accept: application/json
Content-Type: application/json; charset=utf-8

{
    "StepType": "WaitForTime",
}
```

## Response

```json
{
  "TimeWaitAlgorithm": "None",
  "NumIntervals": 0,
  "IntervalType": "None",
  "Until": null,
  "WorkflowStepId": 0,
  "WorkflowId": 0,
  "StepType": "WaitForTime",
  "Rank": 0
}
```

In the case of a 'WaitForTime' [StepType][2] you have the following examples for each of them:

```json
{
    "TimeWaitAlgorithm": "NumIntervals",
    "NumIntervals": 7,
    "IntervalType": "Days",
    "Until": "[DT:05/31/2024 14:24:23]",
    "StepType": "WaitForTime",
    "Rank": 1
}
```

and

```json
{
    "TimeWaitAlgorithm": "UntilSpecified",
    "NumIntervals": 7,
    "IntervalType": "Days",
    "Until": "[DT:05/31/2024 14:24:23]",
    "StepType": "WaitForTime",
    "Rank": 1
}
```

<!-- Referenced links -->
[1]: ../../../reference/restful/agent/Workflow_Agent/v1WorkflowAgent_CreateDefaultWorkflowStepFromType.md
[2]: ../../../../database/tables/enums/workflowsteptype.md
