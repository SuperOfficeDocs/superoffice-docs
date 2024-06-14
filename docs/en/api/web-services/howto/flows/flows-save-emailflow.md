---
uid: api-flows-save-emailflow
title: Flows
description: Save email flow
author: Eivind Fasting
so.date: 06.12.2024
keywords: Flows
so.topic: concept
---

# Save email flow

The following example contains a [default email flow][1] with [triggers][2] and [steps][3], and demonstrates how you create a new flow with these attributes.

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

This creates an Flow inside of SuperOffice, and the returned object should contain the EmailFlowId, which is the unique identification of the Flow.
It is also possible to get an existing Flow through the [GetEmailFlow_Agent][4]

<!-- Reference links -->
[1]: ./flows-createdefault-emailflow.md
[2]: ./flows-create-trigger.md
[3]: ./flows-create-step.md
[4]: ../../reference/restful/agent/Workflow_Agent/v1WorkflowAgent_GetEmailFlow.md