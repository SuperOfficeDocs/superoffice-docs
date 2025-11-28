```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "EmailFlowId": 1,
  "Name": "New Customer Welcome Campaign",
  "Description": "Automated welcome email series for new customers with onboarding information and product tips",
  "Status": "Active",
  "JumpToFinish": false,
  "StartOnlyOnce": true,
  "OverrideConsentSubscription": false,
  "FromType": "FromOnlySpecified",
  "FromName": "Customer Success Team",
  "FromAddr": "success@acmecorp.com",
  "ReplyToType": "ReplyToOnlySpecified",
  "ReplyToAddr": "support@acmecorp.com",
  "ReplyToName": "Acme Support",
  "SmsSender": "AcmeCorp",
  "UseGoogleAnalytics": true,
  "GaSource": "email_campaign",
  "GaCampaign": "welcome_series_2024",
  "UseTimeframe": true,
  "SelectedDays": "Monday,Tuesday,Wednesday,Thursday,Friday",
  "TimeframeStart": "09:00",
  "TimeframeEnd": "17:00",
  "UseWorkflowStart": true,
  "WorkflowStart": "2024-01-01T00:00:00",
  "UseEnrollmentEnd": false,
  "EnrollmentEnd": "",
  "RemoveFromFlows": [
    5,
    12
  ],
  "TzLocation": null,
  "Folder": null,
  "Associate": null,
  "ShipmentType": null,
  "Steps": [
    {
      "WorkflowStepId": 1,
      "WorkflowId": 1,
      "StepType": "SendEmail",
      "Rank": 1
    },
    {
      "WorkflowStepId": 2,
      "WorkflowId": 1,
      "StepType": "Wait",
      "Rank": 2
    }
  ],
  "Triggers": [
    {
      "WorkflowTriggerId": 1,
      "WorkflowId": 1,
      "TriggerType": "ContactCreated",
      "RestrictionGroups": [
        {},
        {}
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 188
        }
      }
    },
    {
      "WorkflowTriggerId": 453,
      "WorkflowId": 651,
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
          "FieldLength": 188
        }
      }
    }
  ],
  "Goals": [
    {
      "WorkflowGoalId": 1,
      "WorkflowId": 1,
      "GoalType": "LinkClicked",
      "RestrictionGroups": [
        {},
        {}
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 291
        }
      }
    },
    {
      "WorkflowGoalId": 766,
      "WorkflowId": 655,
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
          "FieldLength": 291
        }
      }
    }
  ],
  "Filter": null,
  "BlockLists": [
    76,
    910
  ],
  "ContentInfo": [
    {
      "WorkflowContentType": "Email",
      "Id": 101,
      "Actions": true,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 826
        }
      }
    },
    {
      "WorkflowContentType": "Form",
      "Id": 25,
      "Actions": true,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 826
        }
      }
    }
  ],
  "ExitFlowId": 0,
  "ExitSuccessFlowId": 0,
  "CreatedBy": null,
  "UpdatedBy": null,
  "CreatedDate": "2024-01-15T10:00:00+01:00",
  "UpdatedDate": "2024-11-28T14:30:00+01:00",
  "VisibleFor": [
    {
      "VisibleId": 780,
      "Visibility": "All",
      "DisplayValue": "doloremque",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 218
        }
      }
    },
    {
      "VisibleId": 780,
      "Visibility": "All",
      "DisplayValue": "doloremque",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 218
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 123
    }
  }
}
```
