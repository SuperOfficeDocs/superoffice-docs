---
title: POST Agents/Workflow/CreateDefaultEmailFlow
uid: v1WorkflowAgent_CreateDefaultEmailFlow
generated: true
content_type: reference
---

# POST Agents/Workflow/CreateDefaultEmailFlow

```http
POST /api/v1/Agents/Workflow/CreateDefaultEmailFlow
```

Loading default values into a new EmailFlow.








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
| TimeframeStart | string | Start of email/sms sending timeframe in [DT: ] format, interpreted in workflow time zone |
| TimeframeEnd | string | End of email/sms sending timeframe in [DT: ] format, interpreted in workflow time zone |
| UseWorkflowStart | bool | Start the flow running with enrolled participants at the given time |
| WorkflowStart | string | When to start running the workflow. Until start, any enrolled members are not running through the flow, just waiting. In [DT: ] format, interpreted in workflow time zone |
| UseEnrollmentEnd | bool | End enrollment into the workflow at the given time |
| EnrollmentEnd | string | Do not enroll more participant after given time. In [DT: ] format, interpreted in workflow time zone |
| RemoveFromFlows | array | Workflows to remove the participants from when they are enrolled in this workflow |
| TzLocation | TimeZoneData | The workflow timezone setting |
| Folder | HierarchyEntity | The folder/hierarchy the email flow is in.  Use MDO List name "hierarchy" to get list items. |
| Associate | Associate | The owner of the workflow.  Use MDO List name "associate" to get list items. |
| ShipmentType | MDOListItem | The Shipment type (mailing type) |
| Steps | array | The steps in the workflow, mainline steps - forking steps are indicated by its WorkflowStepType. |
| Triggers | array | The triggers for the workflow. |
| Goals | array | The goals for the workflow. |
| Filter | WorkflowFilter | The filter for the workflow. |
| BlockLists | array | Persons in the given selections are not allowed to enter this workflow |
| ContentInfo | array | Info about workflow content like messages, links and forms (read-only) |
| ExitFlowId | int32 | On exit with no success criteria met, we attempt to add the participant to the given flow |
| ExitSuccessFlowId | int32 | On exit with success criteria met, we attempt to add the participant to the given flow |
| CreatedBy | Associate | The associate that first created the flow. The property is read-only. |
| UpdatedBy | Associate | The person that last updated the flow. |
| CreatedDate | date-time | Registered date  in UTC. |
| UpdatedDate | date-time | Updated date  in UTC. |
| VisibleFor | array | The set of users or groups the record is visible for |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Workflow/CreateDefaultEmailFlow
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "EmailFlowId": 527,
  "Name": "Breitenberg-Runte",
  "Description": "Assimilated client-driven complexity",
  "Status": "None",
  "JumpToFinish": true,
  "StartOnlyOnce": false,
  "OverrideConsentSubscription": false,
  "FromType": "FromOnlySpecified",
  "FromName": "Dibbert, Turner and Koepp",
  "FromAddr": "sit",
  "ReplyToType": "ReplyToEmpty",
  "ReplyToAddr": "et",
  "ReplyToName": "Bernier, Grant and Kassulke",
  "SmsSender": "perferendis",
  "UseGoogleAnalytics": true,
  "GaSource": "eius",
  "GaCampaign": "illo",
  "UseTimeframe": false,
  "SelectedDays": "Friday",
  "TimeframeStart": "culpa",
  "TimeframeEnd": "optio",
  "UseWorkflowStart": true,
  "WorkflowStart": "quia",
  "UseEnrollmentEnd": false,
  "EnrollmentEnd": "reprehenderit",
  "RemoveFromFlows": [
    205,
    75
  ],
  "TzLocation": null,
  "Folder": null,
  "Associate": null,
  "ShipmentType": null,
  "Steps": [
    {
      "WorkflowStepId": 781,
      "WorkflowId": 943,
      "StepType": "AddToList",
      "Rank": 621
    },
    {
      "WorkflowStepId": 781,
      "WorkflowId": 943,
      "StepType": "AddToList",
      "Rank": 621
    }
  ],
  "Triggers": [
    {
      "WorkflowTriggerId": 666,
      "WorkflowId": 107,
      "TriggerType": "AddedMessage",
      "RestrictionGroups": [
        {},
        {}
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 663
        }
      }
    },
    {
      "WorkflowTriggerId": 666,
      "WorkflowId": 107,
      "TriggerType": "AddedMessage",
      "RestrictionGroups": [
        {},
        {}
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 663
        }
      }
    }
  ],
  "Goals": [
    {
      "WorkflowGoalId": 49,
      "WorkflowId": 696,
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
          "FieldLength": 604
        }
      }
    },
    {
      "WorkflowGoalId": 49,
      "WorkflowId": 696,
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
          "FieldLength": 604
        }
      }
    }
  ],
  "Filter": null,
  "BlockLists": [
    40,
    134
  ],
  "ContentInfo": [
    {
      "WorkflowContentType": "Form",
      "Id": 209,
      "Actions": true,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 179
        }
      }
    },
    {
      "WorkflowContentType": "Form",
      "Id": 209,
      "Actions": true,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 179
        }
      }
    }
  ],
  "ExitFlowId": 882,
  "ExitSuccessFlowId": 363,
  "CreatedBy": null,
  "UpdatedBy": null,
  "CreatedDate": "2009-07-06T11:24:48.9688719+02:00",
  "UpdatedDate": "2019-06-22T11:24:48.9688719+02:00",
  "VisibleFor": [
    {
      "VisibleId": 40,
      "Visibility": "All",
      "DisplayValue": "dolorem",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 546
        }
      }
    },
    {
      "VisibleId": 40,
      "Visibility": "All",
      "DisplayValue": "dolorem",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 546
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 663
    }
  }
}
```