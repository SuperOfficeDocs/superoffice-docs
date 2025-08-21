---
uid: api-rest-flow-create-trigger
title: Create a Trigger object
description: Create a Trigger object
keywords: flow, EmailFlow, trigger, CreateDefaultWorkflowTrigger, WorkflowTrigger
author: Eivind Fasting
date: 05.24.2024
version: 10.3.5
content_type: howto
audience: api
audience_tooltip: SuperOffice APIs and database
redirect_from: /en/api/netserver/web-services/howto/flows/rest-create-flow-trigger
---

# Create a Trigger object

[Triggers][1] serve as automated starting points for flows, allowing for multiple entry points and additional filters to target specific contacts. Utilize the REST [CreateDefaultWorkflowTrigger][3] endpoint to retrieve a pre-populated default `WorkflowTrigger`, ideal for initiating new triggers.

> [!NOTE]
> A new trigger can be saved alongside a [new flow][6] by including it in the flow object. Alternatively, a trigger can be saved to an existing flow using the [SaveWorkflowTrigger Agent][4].

## Request

```http
POST https://{{env}}.superoffice.com/{{tenant}}/v1/Agents/Workflow/CreateDefaultWorkflowTrigger HTTP/1.1
Authorization: Bearer {{access_token}}
Accept: application/json
```

## Response

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

### Key properties

| Property | Description |
|---|---|
| WorkflowTriggerId | Unique identifier assigned by the system upon saving the trigger. Should not be set manually. |
| WorkflowId | Unique identifier for the flow. Automatically set to the flow's ID if the trigger is part of the flow. |
| TriggerType | Name (not the enumValue) of the trigger type being created. Refer to the [type of trigger][2] documentation for details. |
| RestrictionGroups | Specifies the conditions under which the trigger should execute. Similar to `ArchiveRestrictionGroup` for [Find][5]. |

## Example of edited Trigger object

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

**Response:**

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

<!-- Referenced links -->
[1]: ../../../../marketing/flows/learn/create.md#trigger
[2]: ../../../../database/tables/enums/workflowtriggertype.md
[3]: ../../../reference/restful/agent/Workflow_Agent/v1WorkflowAgent_CreateDefaultWorkflowTrigger.md
[4]: ../../../reference/restful/agent/Workflow_Agent/v1WorkflowAgent_SaveWorkflowTrigger.md
[5]: ../../../search/find-selection/index.md
[6]: rest-save-flow.md
