---
title: POST Agents/Workflow/SaveEmailFlow
uid: v1WorkflowAgent_SaveEmailFlow
---

# POST Agents/Workflow/SaveEmailFlow

```http
POST /api/v1/Agents/Workflow/SaveEmailFlow
```

Updates the existing EmailFlow or creates a new EmailFlow if the id parameter is empty








## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: entity 

The EmailFlow to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| EmailFlowId | Integer | Primary key |
| Name | String | Name of the workflow |
| Description | String | Description of the workflow |
| Status | String | Status of the workflow definition |
| VisibleForAll | Boolean | True if visible for all |
| VisibleForAssociates | Array | Array of references to the visible for associates |
| VisibleForGroups | Array | Array of references to the visible for groups |
| JumpToFinish | Boolean | When a goal is reached, contact jumps directly to finished |
| StartOnlyOnce | Boolean | A contact can start this flow only once |
| OverrideConsentSubscription | Boolean | Override consent and subscription |
| FromType | String | Email/Mailing From field address algorithm |
| FromName | String | Email From name |
| FromAddr | String | Email From address: name@domain.com |
| ReplyToType | String | Email/Mailing Reply-To field address algorithm |
| ReplyToAddr | String | Reply to address, if different from From-address |
| ReplyToName | String | Email Reply-To name |
| SmsSender | String | SMS sender (number or name) |
| UseGoogleAnalytics | Boolean | Use Google Analytics |
| GaSource | String | GA Source |
| GaCampaign | String | GA Campaign |
| UseTimeframe | Boolean | Use sender timeframe settings, only send email/sms within the timeframe |
| SelectedDays | String | Selected days (flags, so several days can be selected) for time frame |
| TimeframeStart | String | Start of email/sms sending timeframe, interpreted in stored timezone or as UTC, only time part is used |
| TimeframeEnd | String | End of email/sms sending timeframe, interpreted in stored timezone or as UTC, only time part is used |
| UseWorkflowStart | Boolean | Start the flow running with enrolled participants at the given time |
| WorkflowStart | String | When to start running the workflow. Until start, any enrolled members are not running through the flow, just waiting. Datetime is interpreted in stored timezone or as UTC |
| UseEnrollmentEnd | Boolean | End enrollment into the workflow at the given time |
| EnrollmentEnd | String | Do not enroll more participant after given time, interpreted in stored timezone or as UTC |
| RemoveFromFlows | Array | Workflows to remove the participants from when they are enrolled in this workflow |
| TzLocation | TimeZoneData | The workflow timezone setting |
| Folder | HierarchyEntity | The folder/hierarchy the email flow is in.  <para>Use MDO List name "hierarchy" to get list items.</para> |
| Associate | Associate | The owner of the workflow.  <para>Use MDO List name "associate" to get list items.</para> |
| ShipmentType | MDOListItem | The Shipment type (mailing type) |
| Steps | Array | The steps in the workflow, mainline steps - forking steps are indicated by its WorkflowStepType. |
| Triggers | Array | The triggers for the workflow. |
| Goals | Array | The goals for the workflow. |
| Filter | WorkflowFilter | The filter for the workflow. |
| BlockLists | Array | Persons in the given selections are not allowed to enter this workflow |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: EmailFlow

| Property Name | Type |  Description |
|----------------|------|--------------|
| EmailFlowId | int32 | Primary key |
| Name | string | Name of the workflow |
| Description | string | Description of the workflow |
| Status | string | Status of the workflow definition |
| VisibleForAll | bool | True if visible for all |
| VisibleForAssociates | array | Array of references to the visible for associates |
| VisibleForGroups | array | Array of references to the visible for groups |
| JumpToFinish | bool | When a goal is reached, contact jumps directly to finished |
| StartOnlyOnce | bool | A contact can start this flow only once |
| OverrideConsentSubscription | bool | Override consent and subscription |
| FromType | string | Email/Mailing From field address algorithm |
| FromName | string | Email From name |
| FromAddr | string | Email From address: name@domain.com |
| ReplyToType | string | Email/Mailing Reply-To field address algorithm |
| ReplyToAddr | string | Reply to address, if different from From-address |
| ReplyToName | string | Email Reply-To name |
| SmsSender | string | SMS sender (number or name) |
| UseGoogleAnalytics | bool | Use Google Analytics |
| GaSource | string | GA Source |
| GaCampaign | string | GA Campaign |
| UseTimeframe | bool | Use sender timeframe settings, only send email/sms within the timeframe |
| SelectedDays | string | Selected days (flags, so several days can be selected) for time frame |
| TimeframeStart | date-time | Start of email/sms sending timeframe, interpreted in stored timezone or as UTC, only time part is used |
| TimeframeEnd | date-time | End of email/sms sending timeframe, interpreted in stored timezone or as UTC, only time part is used |
| UseWorkflowStart | bool | Start the flow running with enrolled participants at the given time |
| WorkflowStart | date-time | When to start running the workflow. Until start, any enrolled members are not running through the flow, just waiting. Datetime is interpreted in stored timezone or as UTC |
| UseEnrollmentEnd | bool | End enrollment into the workflow at the given time |
| EnrollmentEnd | date-time | Do not enroll more participant after given time, interpreted in stored timezone or as UTC |
| RemoveFromFlows | array | Workflows to remove the participants from when they are enrolled in this workflow |
| TzLocation | TimeZoneData | The workflow timezone setting |
| Folder | HierarchyEntity | The folder/hierarchy the email flow is in.  <para>Use MDO List name "hierarchy" to get list items.</para> |
| Associate | Associate | The owner of the workflow.  <para>Use MDO List name "associate" to get list items.</para> |
| ShipmentType | MDOListItem | The Shipment type (mailing type) |
| Steps | array | The steps in the workflow, mainline steps - forking steps are indicated by its WorkflowStepType. |
| Triggers | array | The triggers for the workflow. |
| Goals | array | The goals for the workflow. |
| Filter | WorkflowFilter | The filter for the workflow. |
| BlockLists | array | Persons in the given selections are not allowed to enter this workflow |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Workflow/SaveEmailFlow
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "EmailFlowId": 348,
  "Name": "Collier-Beer",
  "Description": "Digitized value-added implementation",
  "Status": "None",
  "VisibleForAll": false,
  "VisibleForAssociates": [
    855,
    243
  ],
  "VisibleForGroups": [
    194,
    505
  ],
  "JumpToFinish": true,
  "StartOnlyOnce": false,
  "OverrideConsentSubscription": true,
  "FromType": "FromOnlySpecified",
  "FromName": "Sawayn, Stanton and Altenwerth",
  "FromAddr": "commodi",
  "ReplyToType": "ReplyToEmpty",
  "ReplyToAddr": "consequatur",
  "ReplyToName": "Beer LLC",
  "SmsSender": "quis",
  "UseGoogleAnalytics": false,
  "GaSource": "et",
  "GaCampaign": "omnis",
  "UseTimeframe": false,
  "SelectedDays": "Friday",
  "TimeframeStart": "2000-12-15T15:29:23.4532899+01:00",
  "TimeframeEnd": "2007-07-25T15:29:23.4532899+02:00",
  "UseWorkflowStart": true,
  "WorkflowStart": "2012-05-02T15:29:23.4532899+02:00",
  "UseEnrollmentEnd": false,
  "EnrollmentEnd": "2006-11-15T15:29:23.4532899+01:00",
  "RemoveFromFlows": [
    406,
    163
  ],
  "TzLocation": null,
  "Folder": null,
  "Associate": null,
  "ShipmentType": null,
  "Steps": [
    {
      "WorkflowStepId": 993,
      "WorkflowId": 886,
      "StepType": "AddToList",
      "Rank": 175
    },
    {
      "WorkflowStepId": 993,
      "WorkflowId": 886,
      "StepType": "AddToList",
      "Rank": 175
    }
  ],
  "Triggers": [
    {
      "WorkflowTriggerId": 745,
      "WorkflowId": 29,
      "TriggerType": "AddToList",
      "RestrictionGroups": [
        {},
        {}
      ]
    },
    {
      "WorkflowTriggerId": 745,
      "WorkflowId": 29,
      "TriggerType": "AddToList",
      "RestrictionGroups": [
        {},
        {}
      ]
    }
  ],
  "Goals": [
    {
      "WorkflowGoalId": 479,
      "WorkflowId": 86,
      "GoalType": "AddedToProject",
      "RestrictionGroups": [
        {},
        {}
      ]
    },
    {
      "WorkflowGoalId": 479,
      "WorkflowId": 86,
      "GoalType": "AddedToProject",
      "RestrictionGroups": [
        {},
        {}
      ]
    }
  ],
  "Filter": null,
  "BlockLists": [
    343,
    124
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "EmailFlowId": 35,
  "Name": "Wisozk LLC",
  "Description": "Intuitive zero tolerance leverage",
  "Status": "None",
  "VisibleForAll": true,
  "VisibleForAssociates": [
    5,
    80
  ],
  "VisibleForGroups": [
    889,
    167
  ],
  "JumpToFinish": false,
  "StartOnlyOnce": false,
  "OverrideConsentSubscription": false,
  "FromType": "FromOnlySpecified",
  "FromName": "Donnelly-Cronin",
  "FromAddr": "dolores",
  "ReplyToType": "ReplyToEmpty",
  "ReplyToAddr": "a",
  "ReplyToName": "Cummerata, Cummings and Mitchell",
  "SmsSender": "quasi",
  "UseGoogleAnalytics": true,
  "GaSource": "nisi",
  "GaCampaign": "magni",
  "UseTimeframe": false,
  "SelectedDays": "Friday",
  "TimeframeStart": "2004-04-24T15:29:23.4562904+02:00",
  "TimeframeEnd": "2007-03-09T15:29:23.4562904+01:00",
  "UseWorkflowStart": true,
  "WorkflowStart": "1997-11-19T15:29:23.4562904+01:00",
  "UseEnrollmentEnd": false,
  "EnrollmentEnd": "2016-05-16T15:29:23.4562904+02:00",
  "RemoveFromFlows": [
    901,
    999
  ],
  "TzLocation": null,
  "Folder": null,
  "Associate": null,
  "ShipmentType": null,
  "Steps": [
    {
      "WorkflowStepId": 152,
      "WorkflowId": 789,
      "StepType": "AddToList",
      "Rank": 256
    },
    {
      "WorkflowStepId": 152,
      "WorkflowId": 789,
      "StepType": "AddToList",
      "Rank": 256
    }
  ],
  "Triggers": [
    {
      "WorkflowTriggerId": 438,
      "WorkflowId": 289,
      "TriggerType": "AddToList",
      "RestrictionGroups": [
        {},
        {}
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 639
        }
      }
    },
    {
      "WorkflowTriggerId": 438,
      "WorkflowId": 289,
      "TriggerType": "AddToList",
      "RestrictionGroups": [
        {},
        {}
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 639
        }
      }
    }
  ],
  "Goals": [
    {
      "WorkflowGoalId": 635,
      "WorkflowId": 895,
      "GoalType": "AddedToProject",
      "RestrictionGroups": [
        {},
        {}
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 278
        }
      }
    },
    {
      "WorkflowGoalId": 635,
      "WorkflowId": 895,
      "GoalType": "AddedToProject",
      "RestrictionGroups": [
        {},
        {}
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 278
        }
      }
    }
  ],
  "Filter": null,
  "BlockLists": [
    811,
    677
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 925
    }
  }
}
```