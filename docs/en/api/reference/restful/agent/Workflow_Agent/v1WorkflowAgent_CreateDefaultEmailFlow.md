---
title: POST Agents/Workflow/CreateDefaultEmailFlow
uid: v1WorkflowAgent_CreateDefaultEmailFlow
generated: true
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
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "EmailFlowId": 977,
  "Name": "Gottlieb Group",
  "Description": "Up-sized responsive support",
  "Status": "None",
  "JumpToFinish": false,
  "StartOnlyOnce": false,
  "OverrideConsentSubscription": true,
  "FromType": "FromOnlySpecified",
  "FromName": "Stehr Inc and Sons",
  "FromAddr": "eos",
  "ReplyToType": "ReplyToEmpty",
  "ReplyToAddr": "fugiat",
  "ReplyToName": "Hudson-Mosciski",
  "SmsSender": "sed",
  "UseGoogleAnalytics": false,
  "GaSource": "laboriosam",
  "GaCampaign": "eos",
  "UseTimeframe": false,
  "SelectedDays": "Friday",
  "TimeframeStart": "ut",
  "TimeframeEnd": "est",
  "UseWorkflowStart": true,
  "WorkflowStart": "recusandae",
  "UseEnrollmentEnd": false,
  "EnrollmentEnd": "ut",
  "RemoveFromFlows": [
    681,
    78
  ],
  "TzLocation": null,
  "Folder": null,
  "Associate": null,
  "ShipmentType": null,
  "Steps": [
    {
      "WorkflowStepId": 3,
      "WorkflowId": 845,
      "StepType": "AddToList",
      "Rank": 469
    },
    {
      "WorkflowStepId": 3,
      "WorkflowId": 845,
      "StepType": "AddToList",
      "Rank": 469
    }
  ],
  "Triggers": [
    {
      "WorkflowTriggerId": 70,
      "WorkflowId": 636,
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
          "FieldLength": 990
        }
      }
    },
    {
      "WorkflowTriggerId": 70,
      "WorkflowId": 636,
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
          "FieldLength": 990
        }
      }
    }
  ],
  "Goals": [
    {
      "WorkflowGoalId": 625,
      "WorkflowId": 689,
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
          "FieldLength": 463
        }
      }
    },
    {
      "WorkflowGoalId": 625,
      "WorkflowId": 689,
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
          "FieldLength": 463
        }
      }
    }
  ],
  "Filter": null,
  "BlockLists": [
    431,
    651
  ],
  "ContentInfo": [
    {
      "WorkflowContentType": "Form",
      "Id": 911,
      "Actions": false,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 722
        }
      }
    },
    {
      "WorkflowContentType": "Form",
      "Id": 911,
      "Actions": false,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 722
        }
      }
    }
  ],
  "ExitFlowId": 454,
  "ExitSuccessFlowId": 485,
  "CreatedBy": null,
  "UpdatedBy": null,
  "CreatedDate": "2019-01-17T03:45:24.2173078+01:00",
  "UpdatedDate": "2019-04-07T03:45:24.2173078+02:00",
  "VisibleFor": [
    {
      "VisibleId": 357,
      "Visibility": "All",
      "DisplayValue": "quis",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 221
        }
      }
    },
    {
      "VisibleId": 357,
      "Visibility": "All",
      "DisplayValue": "quis",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 221
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 24
    }
  }
}
```