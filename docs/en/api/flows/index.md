---
uid: api-flows-index
title: Flows
description: Introduction to working with Flows through the API
author: Eivind Fasting
so.date: 05.24.2024
keywords: Flows
so.topic: concept
---

# Introduction to working with Flows through the API

A flow is an automated sequence of marketing-related steps, such as sending a message, updating participant information, or creating an activity. The conceptual overview of Flow can be found here [here][1], and this page will focus on how to create a Flow through the API.

## Creating an EmailFlow

Creating a new EmailFlow can be done by:

1. Sending a POST request to the [CreateDefaultEmailFlow Agent][3]
2. Create Triggers and inject them into the returned object
3. Create Steps and inject them into the returned object
4. Save the Email Flow through [SaveEmailFlow Agent][4].

### Create an Email Flow object

The [CreateDefaultEmailFlow Agent][3] endpoint in the REST API will return a pre-populated default Email Flow object. Using this makes it easier to both get default values from the system and get a full overview of what the object looks like.

Request

```curl
POST {{api_url}}/v1/Agents/Workflow/CreateDefaultEmailFlow
Authorization: Bearer {{access_token}}
Accept: application/json
```

Response

```json
{
  "EmailFlowId": 0,
  "Name": "",
  "Description": "",
  "Status": "Stopped",
  "JumpToFinish": false,
  "StartOnlyOnce": true,
  "OverrideConsentSubscription": false,
  "FromType": "FromOnlySpecified",
  "FromName": "",
  "FromAddr": "",
  "ReplyToType": "ReplyToOnlySpecified",
  "ReplyToAddr": "",
  "ReplyToName": "",
  "SmsSender": "",
  "UseGoogleAnalytics": false,
  "GaSource": "",
  "GaCampaign": "",
  "UseTimeframe": false,
  "SelectedDays": "Unknown",
  "TimeframeStart": "[DT:01/01/1970 00:00:00.0000000]",
  "TimeframeEnd": "[DT:01/01/1970 00:00:00.0000000]",
  "UseWorkflowStart": false,
  "WorkflowStart": "[DT:01/01/0001 00:00:00.0000000]",
  "UseEnrollmentEnd": false,
  "EnrollmentEnd": "[DT:01/01/0001 00:00:00.0000000]",
  "RemoveFromFlows": [],
  "TzLocation": {
    "TZLocationID": 0,
    "Name": "",
    "TZLocationCode": "",
    "TZLocationCities": "",
    "IsoNumber": 0,
    "TimeZoneSTDRules": {},
    "TimeZoneDSTRules": {}
  },
  "Folder": {
    "HierarchyId": 0,
    "Domain": "EmailFlows",
    "Name": null,
    "Fullname": null,
    "ParentId": 0,
    "Children": [],
    "Registered": "0001-01-01T00:00:00Z",
    "RegisteredAssociateId": 0,
    "Updated": "0001-01-01T00:00:00Z",
    "UpdatedAssociateId": 0,
    "TableRight": null,
    "FieldProperties": {}
  },
  "Steps": [],
  "Triggers": [],
  "Goals": [],
  "Filter": {
    "RestrictionGroups": [],
    "TableRight": null,
    "FieldProperties": {}
  },
  "BlockLists": [],
  "ContentInfo": [],
  "ExitFlowId": 0,
  "ExitSuccessFlowId": 0,
  "CreatedBy": null,
  "UpdatedBy": null,
  "CreatedDate": "0001-01-01T00:00:00Z",
  "UpdatedDate": "0001-01-01T00:00:00Z",
}
```

> [!NOTE]
> In this example the json has been edited/cut for clarity.

Some key properties are described more in detail, as they are relevant to understand for the rest of the content of this page:

1. EmailFlowId - This is the unique identification of the Flow. This is set by the system upon saving the Flow, and should not be set manually.
2. Name - Unique name for the Flow, as shown inside of SuperOffice. This should be set to a user-readable string, in the following example 'My first flow'.
3. Status - Defines if the Flow is active or stopped.
4. Triggers - An array of triggers that starts the Flow.
5. Steps - An array of steps which builds up the Flow.

### Create a Trigger object

Triggers are automated starting points for the flow. It is possible to add multiple triggers for more entry points, and apply additional filters to target contacts that will enter the flow. Contacts can also be manually added or transferred between flows. Filters apply to all contacts, regardless of how they were added.
The [CreateDefaultWorkflowTrigger][5] endpoint in the REST API will return a pre-populated default Workflow Trigger.

Request

```curl
POST {{api_url}}{{AgentEndpoint}}CreateDefaultWorkflowTrigger
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
2. WorkflowId - Unique Id for the EmailFlow. This will automatically be set to the id of the Flow, if the Trigger is a part of the object passed inn when saving the Flow.
3. TriggerType - Name of the [type of trigger][6] that is being created. Note that its the name of the TriggerType and not the enumValue that should be inserted!
4. RestrictionGroups - This are the actual restriction/selection for what the Trigger should execute on.
//TODO: Explain what this actually means. How can we fetch a list of available restrictionColumns based on TriggerType? Or else developers will have to test them one-by-one and that it not very efficient.

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
> It is possible to save a new Trigger when you create a new Flow, by including it in the object, or save a trigger to an existing Flow using the [SaveWorkflowTrigger_Agent][9]

## Create a Step object

Use the [CreateDefaultWorkflowStepFromType][8] endpoint in the REST API to create a new carrier with defaults set, based on the [type of step][7].
This returns a pre-populated Step object, pre-defined with values depending on what StepType was selected.

Example

```curl
POST {{api_url}}/v1/Agents/Workflow/CreateDefaultWorkflowStepFromType
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

In the case of a 'WaitForTime' [StepType][7] you have the following examples for each of them:

{
    "TimeWaitAlgorithm": "NumIntervals",
    "NumIntervals": 7,
    "IntervalType": "Days",
    "Until": "[DT:05/31/2024 14:24:23]",
    "StepType": "WaitForTime",
    "Rank": 1
}

and

{
    "TimeWaitAlgorithm": "UntilSpecified",
    "NumIntervals": 7,
    "IntervalType": "Days",
    "Until": "[DT:05/31/2024 14:24:23]",
    "StepType": "WaitForTime",
    "Rank": 1
}

> [NOTE!]
> As with Triggers, the WorkflowStepId and WorkflowId are not mandatory, as they are set automatically by the system when created. The properties are removed in the examples

If no Rank is defined in the Step object, the system will automatically decide Rank depending of the order of the elements in the object.

### Putting it together

With the edits explained above, the Email Flow object should look like the following:

```json
{
  "EmailFlowId": 0,
  "Name": "My first flow",
  "Description": "",
  "Status": "Stopped",
  "JumpToFinish": false,
  "StartOnlyOnce": true,
  "OverrideConsentSubscription": false,
  "FromType": "FromOnlySpecified",
  "FromName": "",
  "FromAddr": "",
  "ReplyToType": "ReplyToOnlySpecified",
  "ReplyToAddr": "",
  "ReplyToName": "",
  "SmsSender": "",
  "UseGoogleAnalytics": false,
  "GaSource": "",
  "GaCampaign": "",
  "UseTimeframe": false,
  "SelectedDays": "Unknown",
  "TimeframeStart": "[DT:01/01/1970 00:00:00.0000000]",
  "TimeframeEnd": "[DT:01/01/1970 00:00:00.0000000]",
  "UseWorkflowStart": false,
  "WorkflowStart": "[DT:01/01/0001 00:00:00.0000000]",
  "UseEnrollmentEnd": false,
  "EnrollmentEnd": "[DT:01/01/0001 00:00:00.0000000]",
  "RemoveFromFlows": [],
  "TzLocation": {
    "TZLocationID": 0,
    "Name": "",
    "TZLocationCode": "",
    "TZLocationCities": "",
    "IsoNumber": 0,
    "TimeZoneSTDRules": {},
    "TimeZoneDSTRules": {}
  },
  "Folder": {
    "HierarchyId": 0,
    "Domain": "EmailFlows",
    "Name": null,
    "Fullname": null,
    "ParentId": 0,
    "Children": [],
    "Registered": "0001-01-01T00:00:00Z",
    "RegisteredAssociateId": 0,
    "Updated": "0001-01-01T00:00:00Z",
    "UpdatedAssociateId": 0,
    "TableRight": null,
    "FieldProperties": {}
  },
  "Steps": [
    {
      "TimeWaitAlgorithm": "NumIntervals",
      "NumIntervals": 7,
      "IntervalType": "Days",
      "Until": "[DT:05/31/2024 14:24:23]",
      "StepType": "WaitForTime",
      "Rank": 1
    }
  ],
  "Triggers": [
    {
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
  ],
  "Goals": [],
  "Filter": {
    "RestrictionGroups": [],
    "TableRight": null,
    "FieldProperties": {}
  },
  "BlockLists": [],
  "ContentInfo": [],
  "ExitFlowId": 0,
  "ExitSuccessFlowId": 0,
  "CreatedBy": null,
  "UpdatedBy": null,
  "CreatedDate": "0001-01-01T00:00:00Z",
  "UpdatedDate": "0001-01-01T00:00:00Z",
}
```

This creates an Flow inside of SuperOffice, and the returned object should contain the EmailFlowId, which is the unique identification of the Flow.
It is also possible to get an existing Flow through the [GetEmailFlow_Agent][10]

> [!NOTE]
> Code-examples can also be found on [git][2] !

<!-- Referenced links -->
[1]: ../../marketing/flows/learn/index.md
[2]: https://github.com/SuperOffice/RESTful-HTTP-Queries/blob/eivinds/src/Flow.http
[3]: ../reference/restful/agent/Workflow_Agent/v1WorkflowAgent_CreateDefaultEmailFlow.md
[4]: ../reference/restful/agent/Workflow_Agent/v1WorkflowAgent_SaveEmailFlow.md
[5]: ../reference/restful/agent/Workflow_Agent/v1WorkflowAgent_CreateDefaultWorkflowTrigger.md
[6]: ../../database/tables/enums/workflowtriggertype.md
[7]: ../../database/tables/enums/workflowsteptype.md
[8]: ../reference/restful/agent/Workflow_Agent/v1WorkflowAgent_CreateDefaultWorkflowStepFromType.md
[9]: ../reference/restful/agent/Workflow_Agent/v1WorkflowAgent_SaveWorkflowTrigger.md
[10]: ../reference/restful/agent/Workflow_Agent/v1WorkflowAgent_GetEmailFlow.md
