---
uid: api-flows-create-step
title: Flows
description: Create a Step object
author: Eivind Fasting
so.date: 06.12.2024
keywords: Flows
so.topic: concept
---

# Create a Step object

Use the [CreateDefaultWorkflowStepFromType][1] endpoint in the REST API to create a new carrier with defaults set, based on the [type of step][2].
This returns a pre-populated Step object, pre-defined with values depending on what StepType was selected.

Example

```http
POST https://{{env}}.superoffice.com/{{tenant}}/v1/Agents/Workflow/CreateDefaultWorkflowStepFromType
Authorization: Bearer {{access_token}}
Accept: application/json
Content-Type: application/json; charset=utf-8

{
    "StepType": "WaitForTime",
}
```

Response

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

> [NOTE!]
> As with Triggers, the WorkflowStepId and WorkflowId are not mandatory, as they are set automatically by the system when created. The properties are removed in the examples

If no Rank is defined in the Step object, the system will automatically decide Rank depending of the order of the elements in the object.

<!-- REFERENCE LINKS -->

[1]: ../../reference/restful/agent/Workflow_Agent/v1WorkflowAgent_CreateDefaultWorkflowStepFromType.md
[2]: ../../../database/tables/enums/workflowsteptype.md
