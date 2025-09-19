---
title: POST Agents/Workflow/SaveEmailFlow
uid: v1WorkflowAgent_SaveEmailFlow
generated: true
content_type: reference
---

# POST Agents/Workflow/SaveEmailFlow

```http
POST /api/v1/Agents/Workflow/SaveEmailFlow
```

Updates the existing EmailFlow or creates a new EmailFlow if the id parameter is 0.








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

## Request Body: emailFlow 

The EmailFlow that is saved 

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
| TimeframeStart | String | Start of email/sms sending timeframe in [DT: ] format, interpreted in workflow time zone |
| TimeframeEnd | String | End of email/sms sending timeframe in [DT: ] format, interpreted in workflow time zone |
| UseWorkflowStart | Boolean | Start the flow running with enrolled participants at the given time |
| WorkflowStart | String | When to start running the workflow. Until start, any enrolled members are not running through the flow, just waiting. In [DT: ] format, interpreted in workflow time zone |
| UseEnrollmentEnd | Boolean | End enrollment into the workflow at the given time |
| EnrollmentEnd | String | Do not enroll more participant after given time. In [DT: ] format, interpreted in workflow time zone |
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
| ContentInfo | Array | Info about workflow content like messages, links and forms (read-only) |
| ExitFlowId | Integer | On exit with no success criteria met, we attempt to add the participant to the given flow |
| ExitSuccessFlowId | Integer | On exit with success criteria met, we attempt to add the participant to the given flow |
| CreatedBy | Associate | The associate that first created the flow. The property is read-only. |
| UpdatedBy | Associate | The person that last updated the flow. |
| CreatedDate | String | Registered date  in UTC. |
| UpdatedDate | String | Updated date  in UTC. |
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
POST /api/v1/Agents/Workflow/SaveEmailFlow
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "EmailFlowId": 512,
  "Name": "Gleichner, Rau and Murphy",
  "Description": "Synergistic empowering orchestration",
  "Status": "None",
  "JumpToFinish": false,
  "StartOnlyOnce": true,
  "OverrideConsentSubscription": true,
  "FromType": "FromOnlySpecified",
  "FromName": "Trantow-Mohr",
  "FromAddr": "autem",
  "ReplyToType": "ReplyToEmpty",
  "ReplyToAddr": "et",
  "ReplyToName": "Kautzer, Lind and Hane",
  "SmsSender": "consequatur",
  "UseGoogleAnalytics": false,
  "GaSource": "sed",
  "GaCampaign": "debitis",
  "UseTimeframe": true,
  "SelectedDays": "Friday",
  "TimeframeStart": "unde",
  "TimeframeEnd": "ipsa",
  "UseWorkflowStart": false,
  "WorkflowStart": "saepe",
  "UseEnrollmentEnd": false,
  "EnrollmentEnd": "sequi",
  "RemoveFromFlows": [
    238,
    25
  ],
  "TzLocation": null,
  "Folder": null,
  "Associate": null,
  "ShipmentType": null,
  "Steps": [
    {
      "WorkflowStepId": 90,
      "WorkflowId": 753,
      "StepType": "AddToList",
      "Rank": 934
    },
    {
      "WorkflowStepId": 90,
      "WorkflowId": 753,
      "StepType": "AddToList",
      "Rank": 934
    }
  ],
  "Triggers": [
    {
      "WorkflowTriggerId": 705,
      "WorkflowId": 389,
      "TriggerType": "AddedMessage",
      "RestrictionGroups": [
        {},
        {}
      ]
    },
    {
      "WorkflowTriggerId": 705,
      "WorkflowId": 389,
      "TriggerType": "AddedMessage",
      "RestrictionGroups": [
        {},
        {}
      ]
    }
  ],
  "Goals": [
    {
      "WorkflowGoalId": 964,
      "WorkflowId": 884,
      "GoalType": "AddedToProject",
      "RestrictionGroups": [
        {},
        {}
      ]
    },
    {
      "WorkflowGoalId": 964,
      "WorkflowId": 884,
      "GoalType": "AddedToProject",
      "RestrictionGroups": [
        {},
        {}
      ]
    }
  ],
  "Filter": null,
  "BlockLists": [
    986,
    800
  ],
  "ContentInfo": [
    {
      "WorkflowContentType": "Form",
      "Id": 897,
      "Actions": false
    },
    {
      "WorkflowContentType": "Form",
      "Id": 897,
      "Actions": false
    }
  ],
  "ExitFlowId": 626,
  "ExitSuccessFlowId": 876,
  "CreatedBy": null,
  "UpdatedBy": null,
  "CreatedDate": "2008-11-16T03:41:54.4025704+01:00",
  "UpdatedDate": "2011-11-11T03:41:54.4025704+01:00",
  "VisibleFor": [
    {
      "VisibleId": 396,
      "Visibility": "All",
      "DisplayValue": "eveniet"
    },
    {
      "VisibleId": 396,
      "Visibility": "All",
      "DisplayValue": "eveniet"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "EmailFlowId": 495,
  "Name": "White Group",
  "Description": "Exclusive zero defect groupware",
  "Status": "None",
  "JumpToFinish": true,
  "StartOnlyOnce": true,
  "OverrideConsentSubscription": false,
  "FromType": "FromOnlySpecified",
  "FromName": "Buckridge-Metz",
  "FromAddr": "non",
  "ReplyToType": "ReplyToEmpty",
  "ReplyToAddr": "aut",
  "ReplyToName": "Runolfsson LLC",
  "SmsSender": "nisi",
  "UseGoogleAnalytics": true,
  "GaSource": "quibusdam",
  "GaCampaign": "laudantium",
  "UseTimeframe": false,
  "SelectedDays": "Friday",
  "TimeframeStart": "voluptatem",
  "TimeframeEnd": "sed",
  "UseWorkflowStart": true,
  "WorkflowStart": "voluptas",
  "UseEnrollmentEnd": false,
  "EnrollmentEnd": "ipsum",
  "RemoveFromFlows": [
    19,
    307
  ],
  "TzLocation": null,
  "Folder": null,
  "Associate": null,
  "ShipmentType": null,
  "Steps": [
    {
      "WorkflowStepId": 903,
      "WorkflowId": 941,
      "StepType": "AddToList",
      "Rank": 163
    },
    {
      "WorkflowStepId": 903,
      "WorkflowId": 941,
      "StepType": "AddToList",
      "Rank": 163
    }
  ],
  "Triggers": [
    {
      "WorkflowTriggerId": 135,
      "WorkflowId": 903,
      "TriggerType": "AddedMessage",
      "RestrictionGroups": [
        {},
        {}
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 222
        }
      }
    },
    {
      "WorkflowTriggerId": 135,
      "WorkflowId": 903,
      "TriggerType": "AddedMessage",
      "RestrictionGroups": [
        {},
        {}
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 222
        }
      }
    }
  ],
  "Goals": [
    {
      "WorkflowGoalId": 55,
      "WorkflowId": 912,
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
          "FieldLength": 504
        }
      }
    },
    {
      "WorkflowGoalId": 55,
      "WorkflowId": 912,
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
          "FieldLength": 504
        }
      }
    }
  ],
  "Filter": null,
  "BlockLists": [
    492,
    481
  ],
  "ContentInfo": [
    {
      "WorkflowContentType": "Form",
      "Id": 480,
      "Actions": false,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 698
        }
      }
    },
    {
      "WorkflowContentType": "Form",
      "Id": 480,
      "Actions": false,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 698
        }
      }
    }
  ],
  "ExitFlowId": 567,
  "ExitSuccessFlowId": 270,
  "CreatedBy": null,
  "UpdatedBy": null,
  "CreatedDate": "2021-07-30T03:41:54.4025704+02:00",
  "UpdatedDate": "1999-10-06T03:41:54.4025704+02:00",
  "VisibleFor": [
    {
      "VisibleId": 454,
      "Visibility": "All",
      "DisplayValue": "deleniti",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 896
        }
      }
    },
    {
      "VisibleId": 454,
      "Visibility": "All",
      "DisplayValue": "deleniti",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 896
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 632
    }
  }
}
```