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
  "EmailFlowId": 146,
  "Name": "Wuckert Inc and Sons",
  "Description": "Inverse assymetric utilisation",
  "Status": "None",
  "JumpToFinish": false,
  "StartOnlyOnce": false,
  "OverrideConsentSubscription": true,
  "FromType": "FromOnlySpecified",
  "FromName": "Oberbrunner, Stark and Bartoletti",
  "FromAddr": "laudantium",
  "ReplyToType": "ReplyToEmpty",
  "ReplyToAddr": "adipisci",
  "ReplyToName": "Raynor Group",
  "SmsSender": "non",
  "UseGoogleAnalytics": false,
  "GaSource": "fugiat",
  "GaCampaign": "ut",
  "UseTimeframe": true,
  "SelectedDays": "Friday",
  "TimeframeStart": "praesentium",
  "TimeframeEnd": "enim",
  "UseWorkflowStart": true,
  "WorkflowStart": "perspiciatis",
  "UseEnrollmentEnd": false,
  "EnrollmentEnd": "eum",
  "RemoveFromFlows": [
    55,
    826
  ],
  "TzLocation": null,
  "Folder": null,
  "Associate": null,
  "ShipmentType": null,
  "Steps": [
    {
      "WorkflowStepId": 467,
      "WorkflowId": 565,
      "StepType": "AddToList",
      "Rank": 414
    },
    {
      "WorkflowStepId": 467,
      "WorkflowId": 565,
      "StepType": "AddToList",
      "Rank": 414
    }
  ],
  "Triggers": [
    {
      "WorkflowTriggerId": 507,
      "WorkflowId": 50,
      "TriggerType": "AddedMessage",
      "RestrictionGroups": [
        {},
        {}
      ]
    },
    {
      "WorkflowTriggerId": 507,
      "WorkflowId": 50,
      "TriggerType": "AddedMessage",
      "RestrictionGroups": [
        {},
        {}
      ]
    }
  ],
  "Goals": [
    {
      "WorkflowGoalId": 908,
      "WorkflowId": 611,
      "GoalType": "AddedToProject",
      "RestrictionGroups": [
        {},
        {}
      ]
    },
    {
      "WorkflowGoalId": 908,
      "WorkflowId": 611,
      "GoalType": "AddedToProject",
      "RestrictionGroups": [
        {},
        {}
      ]
    }
  ],
  "Filter": null,
  "BlockLists": [
    724,
    901
  ],
  "ContentInfo": [
    {
      "WorkflowContentType": "Form",
      "Id": 934,
      "Actions": false
    },
    {
      "WorkflowContentType": "Form",
      "Id": 934,
      "Actions": false
    }
  ],
  "ExitFlowId": 466,
  "ExitSuccessFlowId": 702,
  "CreatedBy": null,
  "UpdatedBy": null,
  "CreatedDate": "2006-01-24T12:57:35.5555358+01:00",
  "UpdatedDate": "2004-02-12T12:57:35.5555358+01:00",
  "VisibleFor": [
    {
      "VisibleId": 889,
      "Visibility": "All",
      "DisplayValue": "et"
    },
    {
      "VisibleId": 889,
      "Visibility": "All",
      "DisplayValue": "et"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "EmailFlowId": 344,
  "Name": "Murphy, Wintheiser and Larkin",
  "Description": "Managed human-resource array",
  "Status": "None",
  "JumpToFinish": false,
  "StartOnlyOnce": true,
  "OverrideConsentSubscription": true,
  "FromType": "FromOnlySpecified",
  "FromName": "Dare-Rippin",
  "FromAddr": "cupiditate",
  "ReplyToType": "ReplyToEmpty",
  "ReplyToAddr": "nisi",
  "ReplyToName": "Feest-Tillman",
  "SmsSender": "distinctio",
  "UseGoogleAnalytics": true,
  "GaSource": "rerum",
  "GaCampaign": "et",
  "UseTimeframe": false,
  "SelectedDays": "Friday",
  "TimeframeStart": "nemo",
  "TimeframeEnd": "asperiores",
  "UseWorkflowStart": false,
  "WorkflowStart": "labore",
  "UseEnrollmentEnd": false,
  "EnrollmentEnd": "tenetur",
  "RemoveFromFlows": [
    21,
    794
  ],
  "TzLocation": null,
  "Folder": null,
  "Associate": null,
  "ShipmentType": null,
  "Steps": [
    {
      "WorkflowStepId": 879,
      "WorkflowId": 47,
      "StepType": "AddToList",
      "Rank": 437
    },
    {
      "WorkflowStepId": 879,
      "WorkflowId": 47,
      "StepType": "AddToList",
      "Rank": 437
    }
  ],
  "Triggers": [
    {
      "WorkflowTriggerId": 728,
      "WorkflowId": 711,
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
          "FieldLength": 557
        }
      }
    },
    {
      "WorkflowTriggerId": 728,
      "WorkflowId": 711,
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
          "FieldLength": 557
        }
      }
    }
  ],
  "Goals": [
    {
      "WorkflowGoalId": 679,
      "WorkflowId": 164,
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
          "FieldLength": 364
        }
      }
    },
    {
      "WorkflowGoalId": 679,
      "WorkflowId": 164,
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
          "FieldLength": 364
        }
      }
    }
  ],
  "Filter": null,
  "BlockLists": [
    433,
    621
  ],
  "ContentInfo": [
    {
      "WorkflowContentType": "Form",
      "Id": 831,
      "Actions": false,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 839
        }
      }
    },
    {
      "WorkflowContentType": "Form",
      "Id": 831,
      "Actions": false,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 839
        }
      }
    }
  ],
  "ExitFlowId": 637,
  "ExitSuccessFlowId": 578,
  "CreatedBy": null,
  "UpdatedBy": null,
  "CreatedDate": "2001-12-02T12:57:35.5555358+01:00",
  "UpdatedDate": "2017-03-05T12:57:35.5555358+01:00",
  "VisibleFor": [
    {
      "VisibleId": 80,
      "Visibility": "All",
      "DisplayValue": "officiis",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 43
        }
      }
    },
    {
      "VisibleId": 80,
      "Visibility": "All",
      "DisplayValue": "officiis",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 43
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 930
    }
  }
}
```