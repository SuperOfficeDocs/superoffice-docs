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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "EmailFlowId": 306,
  "Name": "Towne Group",
  "Description": "Multi-tiered client-driven encryption",
  "Status": "None",
  "JumpToFinish": true,
  "StartOnlyOnce": false,
  "OverrideConsentSubscription": false,
  "FromType": "FromOnlySpecified",
  "FromName": "Greenfelder, Considine and Windler",
  "FromAddr": "et",
  "ReplyToType": "ReplyToEmpty",
  "ReplyToAddr": "reiciendis",
  "ReplyToName": "Lueilwitz-Fritsch",
  "SmsSender": "ipsam",
  "UseGoogleAnalytics": true,
  "GaSource": "et",
  "GaCampaign": "ut",
  "UseTimeframe": false,
  "SelectedDays": "Friday",
  "TimeframeStart": "eius",
  "TimeframeEnd": "magni",
  "UseWorkflowStart": false,
  "WorkflowStart": "est",
  "UseEnrollmentEnd": false,
  "EnrollmentEnd": "assumenda",
  "RemoveFromFlows": [
    378,
    163
  ],
  "TzLocation": null,
  "Folder": null,
  "Associate": null,
  "ShipmentType": null,
  "Steps": [
    {
      "WorkflowStepId": 81,
      "WorkflowId": 269,
      "StepType": "AddToList",
      "Rank": 283
    },
    {
      "WorkflowStepId": 81,
      "WorkflowId": 269,
      "StepType": "AddToList",
      "Rank": 283
    }
  ],
  "Triggers": [
    {
      "WorkflowTriggerId": 863,
      "WorkflowId": 928,
      "TriggerType": "AddedMessage",
      "RestrictionGroups": [
        {},
        {}
      ]
    },
    {
      "WorkflowTriggerId": 863,
      "WorkflowId": 928,
      "TriggerType": "AddedMessage",
      "RestrictionGroups": [
        {},
        {}
      ]
    }
  ],
  "Goals": [
    {
      "WorkflowGoalId": 543,
      "WorkflowId": 283,
      "GoalType": "AddedToProject",
      "RestrictionGroups": [
        {},
        {}
      ]
    },
    {
      "WorkflowGoalId": 543,
      "WorkflowId": 283,
      "GoalType": "AddedToProject",
      "RestrictionGroups": [
        {},
        {}
      ]
    }
  ],
  "Filter": null,
  "BlockLists": [
    18,
    665
  ],
  "ContentInfo": [
    {
      "WorkflowContentType": "Form",
      "Id": 336,
      "Actions": true
    },
    {
      "WorkflowContentType": "Form",
      "Id": 336,
      "Actions": true
    }
  ],
  "ExitFlowId": 405,
  "ExitSuccessFlowId": 420,
  "CreatedBy": null,
  "UpdatedBy": null,
  "CreatedDate": "2013-12-22T10:17:56.3790788+01:00",
  "UpdatedDate": "2017-08-04T10:17:56.3790788+02:00",
  "VisibleFor": [
    {
      "VisibleId": 428,
      "Visibility": "All",
      "DisplayValue": "est"
    },
    {
      "VisibleId": 428,
      "Visibility": "All",
      "DisplayValue": "est"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "EmailFlowId": 912,
  "Name": "Simonis Group",
  "Description": "Innovative static frame",
  "Status": "None",
  "JumpToFinish": false,
  "StartOnlyOnce": true,
  "OverrideConsentSubscription": true,
  "FromType": "FromOnlySpecified",
  "FromName": "Goodwin, Boehm and Schmitt",
  "FromAddr": "qui",
  "ReplyToType": "ReplyToEmpty",
  "ReplyToAddr": "occaecati",
  "ReplyToName": "Lemke Group",
  "SmsSender": "quod",
  "UseGoogleAnalytics": false,
  "GaSource": "perferendis",
  "GaCampaign": "commodi",
  "UseTimeframe": false,
  "SelectedDays": "Friday",
  "TimeframeStart": "consequatur",
  "TimeframeEnd": "voluptates",
  "UseWorkflowStart": true,
  "WorkflowStart": "sit",
  "UseEnrollmentEnd": false,
  "EnrollmentEnd": "pariatur",
  "RemoveFromFlows": [
    777,
    704
  ],
  "TzLocation": null,
  "Folder": null,
  "Associate": null,
  "ShipmentType": null,
  "Steps": [
    {
      "WorkflowStepId": 953,
      "WorkflowId": 431,
      "StepType": "AddToList",
      "Rank": 734
    },
    {
      "WorkflowStepId": 953,
      "WorkflowId": 431,
      "StepType": "AddToList",
      "Rank": 734
    }
  ],
  "Triggers": [
    {
      "WorkflowTriggerId": 293,
      "WorkflowId": 876,
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
          "FieldLength": 182
        }
      }
    },
    {
      "WorkflowTriggerId": 293,
      "WorkflowId": 876,
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
          "FieldLength": 182
        }
      }
    }
  ],
  "Goals": [
    {
      "WorkflowGoalId": 890,
      "WorkflowId": 650,
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
          "FieldLength": 106
        }
      }
    },
    {
      "WorkflowGoalId": 890,
      "WorkflowId": 650,
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
          "FieldLength": 106
        }
      }
    }
  ],
  "Filter": null,
  "BlockLists": [
    106,
    9
  ],
  "ContentInfo": [
    {
      "WorkflowContentType": "Form",
      "Id": 41,
      "Actions": true,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 632
        }
      }
    },
    {
      "WorkflowContentType": "Form",
      "Id": 41,
      "Actions": true,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 632
        }
      }
    }
  ],
  "ExitFlowId": 739,
  "ExitSuccessFlowId": 376,
  "CreatedBy": null,
  "UpdatedBy": null,
  "CreatedDate": "2004-11-20T10:17:56.3790788+01:00",
  "UpdatedDate": "2016-07-04T10:17:56.3790788+02:00",
  "VisibleFor": [
    {
      "VisibleId": 158,
      "Visibility": "All",
      "DisplayValue": "non",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 851
        }
      }
    },
    {
      "VisibleId": 158,
      "Visibility": "All",
      "DisplayValue": "non",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 851
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 63
    }
  }
}
```