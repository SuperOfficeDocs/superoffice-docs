---
uid: api-rest-flow-save
title: Save email flow
description: Save email flow
keywords: flow, EmailFlow, SaveEmailFlow
author: Eivind Fasting
date: 05.24.2024
version: 10.3.5
content_type: concept
audience: api
audience_tooltip: SuperOffice APIs and database
redirect_from: /en/api/netserver/web-services/howto/flows/rest-save-flow
---

# Save email flow

The following example illustrates a [default email flow][1] featuring [triggers][2] and [steps][3], demonstrating the creation of a new flow with these components.

This action creates a flow within SuperOffice, and the returned object includes the `EmailFlowId`, which uniquely identifies the flow. Additionally, you can retrieve an existing flow using the [GetEmailFlow Agent][4].

## Request

```http
POST https://{{env}}.superoffice.com/{{tenant}}/v1/Agents/Workflow/SaveEmailFlow HTTP/1.1
Authorization: Bearer {{access_token}}
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "EmailFlowId": 0,
  "Name": "Rad",
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

<!-- Referenced links -->
[1]: rest-create-default-email-flow.md
[2]: rest-create-flow-trigger.md
[3]: rest-create-flow-step.md
[4]: ../../../reference/restful/agent/Workflow_Agent/v1WorkflowAgent_GetEmailFlow.md
