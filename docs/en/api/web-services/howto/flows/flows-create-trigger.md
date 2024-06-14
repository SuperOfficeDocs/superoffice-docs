---
uid: api-flows-create-trigger
title: Flows
description: Create a Trigger object
author: Eivind Fasting
so.date: 06.12.2024
keywords: Flows
so.topic: concept
---

# Create a Trigger object

[Triggers are automated starting points for the flow][1]. It is possible to add multiple triggers for more entry points, and apply additional filters to target contacts that will enter the flow.
The [CreateDefaultWorkflowTrigger][2] endpoint in the REST API will return a pre-populated default Workflow Trigger, which can be used as a starting-point for a new trigger.

Request

```http
POST https://{{env}}.superoffice.com/{{tenant}}/v1/Agents/Workflow/CreateDefaultWorkflowTrigger HTTP/1.1
Authorization: Bearer {{access_token}}
Accept: application/json
```

Response

```json
{
  "WorkflowTriggerId": 0,
  "WorkflowId": 0,
  "TriggerType": "None",
  "RestrictionGroups": [],
  "TableRight": null,
  "FieldProperties": {}
}
```

Some key properties are described more in detail, as they are relevant to understand through the rest of the content of this page:

1. WorkflowTriggerId - This is the unique identification of the Trigger. This is set by the system upon saving the Flow, and should not be set manually.
2. WorkflowId - Unique Id for the EmailFlow. This will automatically be set to the id of the Flow, if the Trigger is a part of the object passed inn when saving a Flow.
3. TriggerType - Name of the [type of trigger][3] that is being created. Note that its the name of the TriggerType and not the enumValue that should be inserted!
4. RestrictionGroups - This is the actual restriction/selection for what the Trigger should execute on. RestrictionGroups look similar to how ArchiveRestrictionGroup work for [Find][5].

Example of edited Trigger object

```json
{
    "WorkflowTriggerId": 0,
    "WorkflowId": 1,
    "TriggerType": "CreatedRequest",
    "RestrictionGroups": [
        {
            "Name": "Trigger from API",
            "Description": "This trigger is created through the API",
            "Rank": 0,
            "Restrictions": [
            {
                "Name": "request/slevel",
                "Operator": "oneOf",
                "Values": [
                "[I:1]"
                ]
            }
            ]
        }
    ]
}
```

Response

```json
{
  "WorkflowTriggerId": 5,
  "WorkflowId": 1,
  "TriggerType": "CreatedRequest",
  "RestrictionGroups": [
    {
      "Name": "Trigger from API",
      "Description": "This trigger is created through the API",
      "Rank": 0,
      "Restrictions": [
        {
          "Name": "request/slevel",
          "Operator": "oneOf",
          "Values": [
            "[I:1]"
          ],
          "DisplayValues": [
            "[SR_SLEVEL_INTERNAL]"
          ],
          "ColumnInfo": {
            "DisplayName": "[SR_TICKETARCHIVE_SLEVEL]",
            "DisplayTooltip": "[SR_TICKETARCHIVE_SLEVEL]",
            "DisplayType": "string",
            "CanOrderBy": true,
            "Name": "request/slevel",
            "CanRestrictBy": true,
            "RestrictionType": "listAny",
            "RestrictionListName": "TicketSLevel",
            "IsVisible": true,
            "ExtraInfo": "",
            "Width": "10%",
            "IconHint": "Ticket",
            "HeadingIconHint": ""
          },
          "IsActive": true,
          "SubRestrictions": null,
          "InterParenthesis": 0,
          "InterOperator": "And",
          "UniqueHash": 422435087
        }
      ]
    }
  ],
  "TableRight": null,
  "FieldProperties": {}
}
```

> [!NOTE]
> It is possible to save a new Trigger when you [save a new Flow][6], by including it in the flow object, or save a trigger to an existing Flow using the [SaveWorkflowTrigger_Agent][4]

<!-- Referenced links -->
[1]: ../../../../marketing/flows/learn/create.md#define-flow-start-trigger-and-filters
[2]: ../../../reference/restful/agent/Workflow_Agent/v1WorkflowAgent_CreateDefaultWorkflowTrigger.md
[3]: ../../../../database/tables/enums/workflowtriggertype.md
[4]: ../../../reference/restful/agent/Workflow_Agent/v1WorkflowAgent_SaveWorkflowTrigger.md
[5]: ../../../../api/search/find-selection/index.md
[6]: ./flows-save-emailflow.md
