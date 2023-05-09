---
title: POST Agents/Workflow/CreateDefaultEmailFlow
uid: v1WorkflowAgent_CreateDefaultEmailFlow
---

# POST Agents/Workflow/CreateDefaultEmailFlow

```http
POST /api/v1/Agents/Workflow/CreateDefaultEmailFlow
```

Set default values into a new EmailFlow.


NetServer calculates default values on the entity, which is required when creating/storing a new instance







## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


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
POST /api/v1/Agents/Workflow/CreateDefaultEmailFlow
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "EmailFlowId": 82,
  "Name": "Gislason Group",
  "Description": "Right-sized leading edge success",
  "Status": "None",
  "VisibleForAll": true,
  "VisibleForAssociates": [
    941,
    102
  ],
  "VisibleForGroups": [
    645,
    222
  ],
  "JumpToFinish": false,
  "StartOnlyOnce": false,
  "OverrideConsentSubscription": false,
  "FromType": "FromOnlySpecified",
  "FromName": "Raynor LLC",
  "FromAddr": "et",
  "ReplyToType": "ReplyToEmpty",
  "ReplyToAddr": "ratione",
  "ReplyToName": "Langosh Group",
  "SmsSender": "praesentium",
  "UseGoogleAnalytics": false,
  "GaSource": "optio",
  "GaCampaign": "pariatur",
  "UseTimeframe": true,
  "SelectedDays": "Friday",
  "TimeframeStart": "2010-03-10T03:51:28.5682842+01:00",
  "TimeframeEnd": "2001-11-05T03:51:28.5682842+01:00",
  "UseWorkflowStart": false,
  "WorkflowStart": "2001-04-22T03:51:28.5682842+02:00",
  "UseEnrollmentEnd": true,
  "EnrollmentEnd": "2005-01-04T03:51:28.5682842+01:00",
  "RemoveFromFlows": [
    727,
    728
  ],
  "TzLocation": null,
  "Folder": null,
  "Associate": null,
  "ShipmentType": null,
  "Steps": [
    {
      "WorkflowStepId": 973,
      "WorkflowId": 833,
      "StepType": "AddToList",
      "Rank": 167
    },
    {
      "WorkflowStepId": 973,
      "WorkflowId": 833,
      "StepType": "AddToList",
      "Rank": 167
    }
  ],
  "Triggers": [
    {
      "WorkflowTriggerId": 506,
      "WorkflowId": 804,
      "TriggerType": "AddToList",
      "RestrictionGroups": [
        {},
        {}
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 35
        }
      }
    },
    {
      "WorkflowTriggerId": 506,
      "WorkflowId": 804,
      "TriggerType": "AddToList",
      "RestrictionGroups": [
        {},
        {}
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 35
        }
      }
    }
  ],
  "Goals": [
    {
      "WorkflowGoalId": 915,
      "WorkflowId": 679,
      "GoalType": "AddedToProject",
      "RestrictionGroups": [
        {},
        {}
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 804
        }
      }
    },
    {
      "WorkflowGoalId": 915,
      "WorkflowId": 679,
      "GoalType": "AddedToProject",
      "RestrictionGroups": [
        {},
        {}
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 804
        }
      }
    }
  ],
  "Filter": null,
  "BlockLists": [
    511,
    831
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 440
    }
  }
}
```