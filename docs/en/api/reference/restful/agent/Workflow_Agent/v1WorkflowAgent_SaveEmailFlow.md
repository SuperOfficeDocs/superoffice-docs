---
title: POST Agents/Workflow/SaveEmailFlow
uid: v1WorkflowAgent_SaveEmailFlow
generated: true
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
| TimeframeStart | String | Start of email/sms sending timeframe, interpreted in stored timezone or as UTC, only time part is used  in UTC. |
| TimeframeEnd | String | End of email/sms sending timeframe, interpreted in stored timezone or as UTC, only time part is used  in UTC. |
| UseWorkflowStart | Boolean | Start the flow running with enrolled participants at the given time |
| WorkflowStart | String | When to start running the workflow. Until start, any enrolled members are not running through the flow, just waiting. Datetime is interpreted in stored timezone or as UTC  in UTC. |
| UseEnrollmentEnd | Boolean | End enrollment into the workflow at the given time |
| EnrollmentEnd | String | Do not enroll more participant after given time, interpreted in stored timezone or as UTC  in UTC. |
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
| VisibleFor | Array | The set of users or groups the record is visible for |

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
| TimeframeStart | date-time | Start of email/sms sending timeframe, interpreted in stored timezone or as UTC, only time part is used  in UTC. |
| TimeframeEnd | date-time | End of email/sms sending timeframe, interpreted in stored timezone or as UTC, only time part is used  in UTC. |
| UseWorkflowStart | bool | Start the flow running with enrolled participants at the given time |
| WorkflowStart | date-time | When to start running the workflow. Until start, any enrolled members are not running through the flow, just waiting. Datetime is interpreted in stored timezone or as UTC  in UTC. |
| UseEnrollmentEnd | bool | End enrollment into the workflow at the given time |
| EnrollmentEnd | date-time | Do not enroll more participant after given time, interpreted in stored timezone or as UTC  in UTC. |
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
| VisibleFor | array | The set of users or groups the record is visible for |
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
  "EmailFlowId": 454,
  "Name": "Davis-Abshire",
  "Description": "Exclusive directional Graphical User Interface",
  "Status": "None",
  "JumpToFinish": true,
  "StartOnlyOnce": true,
  "OverrideConsentSubscription": false,
  "FromType": "FromOnlySpecified",
  "FromName": "Frami Inc and Sons",
  "FromAddr": "tempore",
  "ReplyToType": "ReplyToEmpty",
  "ReplyToAddr": "dolor",
  "ReplyToName": "Ankunding, Beatty and Little",
  "SmsSender": "nihil",
  "UseGoogleAnalytics": false,
  "GaSource": "ipsam",
  "GaCampaign": "et",
  "UseTimeframe": false,
  "SelectedDays": "Friday",
  "TimeframeStart": "2011-07-31T16:00:42.4143588+02:00",
  "TimeframeEnd": "2001-02-28T16:00:42.4143588+01:00",
  "UseWorkflowStart": true,
  "WorkflowStart": "2007-01-08T16:00:42.4143588+01:00",
  "UseEnrollmentEnd": false,
  "EnrollmentEnd": "1998-05-06T16:00:42.4143588+02:00",
  "RemoveFromFlows": [
    439,
    930
  ],
  "TzLocation": null,
  "Folder": null,
  "Associate": null,
  "ShipmentType": null,
  "Steps": [
    {
      "WorkflowStepId": 65,
      "WorkflowId": 456,
      "StepType": "AddToList",
      "Rank": 848
    },
    {
      "WorkflowStepId": 65,
      "WorkflowId": 456,
      "StepType": "AddToList",
      "Rank": 848
    }
  ],
  "Triggers": [
    {
      "WorkflowTriggerId": 690,
      "WorkflowId": 813,
      "TriggerType": "AddToList",
      "RestrictionGroups": [
        {},
        {}
      ]
    },
    {
      "WorkflowTriggerId": 690,
      "WorkflowId": 813,
      "TriggerType": "AddToList",
      "RestrictionGroups": [
        {},
        {}
      ]
    }
  ],
  "Goals": [
    {
      "WorkflowGoalId": 146,
      "WorkflowId": 311,
      "GoalType": "AddedToProject",
      "RestrictionGroups": [
        {},
        {}
      ]
    },
    {
      "WorkflowGoalId": 146,
      "WorkflowId": 311,
      "GoalType": "AddedToProject",
      "RestrictionGroups": [
        {},
        {}
      ]
    }
  ],
  "Filter": null,
  "BlockLists": [
    267,
    709
  ],
  "VisibleFor": [
    {
      "VisibleId": 392,
      "Visibility": "All",
      "DisplayValue": "atque"
    },
    {
      "VisibleId": 392,
      "Visibility": "All",
      "DisplayValue": "atque"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "EmailFlowId": 369,
  "Name": "West, Gutkowski and Emard",
  "Description": "Optimized transitional toolset",
  "Status": "None",
  "JumpToFinish": false,
  "StartOnlyOnce": true,
  "OverrideConsentSubscription": true,
  "FromType": "FromOnlySpecified",
  "FromName": "Flatley LLC",
  "FromAddr": "assumenda",
  "ReplyToType": "ReplyToEmpty",
  "ReplyToAddr": "ipsam",
  "ReplyToName": "Hettinger-Thiel",
  "SmsSender": "quia",
  "UseGoogleAnalytics": false,
  "GaSource": "et",
  "GaCampaign": "et",
  "UseTimeframe": true,
  "SelectedDays": "Friday",
  "TimeframeStart": "1998-02-28T16:00:42.4299845+01:00",
  "TimeframeEnd": "2001-04-13T16:00:42.4299845+02:00",
  "UseWorkflowStart": false,
  "WorkflowStart": "2021-03-28T16:00:42.4299845+02:00",
  "UseEnrollmentEnd": false,
  "EnrollmentEnd": "2006-12-12T16:00:42.4299845+01:00",
  "RemoveFromFlows": [
    752,
    528
  ],
  "TzLocation": null,
  "Folder": null,
  "Associate": null,
  "ShipmentType": null,
  "Steps": [
    {
      "WorkflowStepId": 741,
      "WorkflowId": 246,
      "StepType": "AddToList",
      "Rank": 106
    },
    {
      "WorkflowStepId": 741,
      "WorkflowId": 246,
      "StepType": "AddToList",
      "Rank": 106
    }
  ],
  "Triggers": [
    {
      "WorkflowTriggerId": 693,
      "WorkflowId": 366,
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
          "FieldLength": 254
        }
      }
    },
    {
      "WorkflowTriggerId": 693,
      "WorkflowId": 366,
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
          "FieldLength": 254
        }
      }
    }
  ],
  "Goals": [
    {
      "WorkflowGoalId": 820,
      "WorkflowId": 653,
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
          "FieldLength": 172
        }
      }
    },
    {
      "WorkflowGoalId": 820,
      "WorkflowId": 653,
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
          "FieldLength": 172
        }
      }
    }
  ],
  "Filter": null,
  "BlockLists": [
    463,
    521
  ],
  "VisibleFor": [
    {
      "VisibleId": 870,
      "Visibility": "All",
      "DisplayValue": "rerum",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 57
        }
      }
    },
    {
      "VisibleId": 870,
      "Visibility": "All",
      "DisplayValue": "rerum",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 57
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 327
    }
  }
}
```