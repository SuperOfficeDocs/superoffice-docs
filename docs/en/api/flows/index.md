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

A flow is an automated sequence of marketing-related steps, such as sending a message, updating participant information, or creating an activity. The conceptual overview of Flow can be found here [here][1], and this page will focus on how to work with Flow through our API.

## Creating an EmailFlow

Creating a new EmailFlow can be done by sending a request to the [CreateDefaultEmailFlow Agent][3], adjust the response to fit your need and pass it back to the [SaveEmailFlow Agent][4].

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
> In this example the json has been edited for clarity.

The most important property is 'Name', to give your flow an unique name inside of SuperOffice, but you can adjust any property before you pass it back/save the workflow back into SuperOffice.

To save the entity we pass the edited json back to the [SaveEmailFlow-endpoint][4]:

```curl
POST {{api_url}}/v1/Agents/Workflow/SaveEmailFlow
Authorization: Bearer {{access_token}}
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

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

The response will contain the EmailFlowId in the body:

```json
{
  "EmailFlowId": 1,
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

## Adding a trigger

Triggers are automated starting points for the flow. You can add multiple triggers for more entry points, and apply additional filters to target contacts that will enter the flow. Contacts can also be manually added or transferred between flows. Filters apply to all contacts, regardless of how they were added.
Similar to how we created the EmailFlow, we can use the [CreateDefaultWorkflowTrigger][5] to see what the default object looks like.

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

It's important to adjust the WorkflowId to be equal to the EmailFlow, as this is the connection between a trigger and the flow.
TriggerType is a StringValue for the [type of trigger][6] that is being created.

> [!NOTE]
> Note that its the name of the TriggerType and not the enumValue that should be inserted.

The Restrictions attribute fine-tunes what it triggers on.
//TODO: Explain what this actually means. How can we fetch a list of available restrictionColumns based on TriggerType? Or else developers will have to test them one-by-one and that it not very efficient.

Example

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

## Adding a step

//TODO: Decide if we need to add examples for all the stepTypes, as they are not that easy to figure out without testing them one by one..
//TODO: There is no method for CreateWorkflowStep, so you have to add this to the carrier for EmailFlow.. This means this documentation should be reworked to save the EmailFlow WITH all these triggers/steps etc in one-go, to not have multiple saves of the same items.

Creating a step can be done by first checking what [type of step][7] you want to create.
With that you can use the [CreateDefaultWorkflowStepFromType][8] to create a new carrier with defaults set, based on the type.

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

Adjust WorkflowId to be the appropriate workflow created above.
In the case of a 'WaitForTime' StepType you have the following examples for each of them:

{
    "TimeWaitAlgorithm": "NumIntervals",
    "NumIntervals": 7,
    "IntervalType": "Days",
    "Until": "[DT:05/31/2024 14:24:23]",
    "WorkflowStepId": 2,
    "WorkflowId": 1,
    "StepType": "WaitForTime",
    "Rank": 1
}

and 

{
    "TimeWaitAlgorithm": "UntilSpecified",
    "NumIntervals": 7,
    "IntervalType": "Days",
    "Until": "[DT:05/31/2024 14:24:23]",
    "WorkflowStepId": 2,
    "WorkflowId": 1,
    "StepType": "WaitForTime",
    "Rank": 1
}



 -->


> [!NOTE]
> Code-examples can also be found on [git][2]

<!-- Referenced links -->
[1]: ../../marketing/flows/learn/index.md
[2]: https://github.com/SuperOffice/RESTful-HTTP-Queries/blob/environmentSettings/src/CustomObjects.http
[3]: ../reference/restful/agent/Workflow_Agent/v1WorkflowAgent_CreateDefaultEmailFlow.md
[4]: ../reference/restful/agent/Workflow_Agent/v1WorkflowAgent_SaveEmailFlow.md
[5]: ../reference/restful/agent/Workflow_Agent/v1WorkflowAgent_CreateDefaultWorkflowTrigger.md
[6]: ../../database/tables/enums/workflowtriggertype.md
[7]: ../../database/tables/enums/workflowsteptype.md
[8]: ../reference/restful/agent/Workflow_Agent/v1WorkflowAgent_CreateDefaultWorkflowStepFromType.md