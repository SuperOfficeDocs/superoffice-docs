```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "EmailFlowId": 2,
  "Name": "Customer Re-engagement Campaign",
  "Description": "Win back inactive customers with special offers and product updates",
  "Status": "Active",
  "JumpToFinish": false,
  "StartOnlyOnce": false,
  "OverrideConsentSubscription": false,
  "FromType": "FromOnlySpecified",
  "FromName": "Marketing Team",
  "FromAddr": "marketing@acmecorp.com",
  "ReplyToType": "ReplyToOnlySpecified",
  "ReplyToAddr": "marketing@acmecorp.com",
  "ReplyToName": "Acme Marketing",
  "SmsSender": "AcmeCorp",
  "UseGoogleAnalytics": true,
  "GaSource": "email_campaign",
  "GaCampaign": "reengagement_q4_2024",
  "UseTimeframe": true,
  "SelectedDays": "Tuesday,Wednesday,Thursday",
  "TimeframeStart": "10:00",
  "TimeframeEnd": "16:00",
  "UseWorkflowStart": true,
  "WorkflowStart": "2024-10-01T00:00:00",
  "UseEnrollmentEnd": true,
  "EnrollmentEnd": "2024-12-31T23:59:59",
  "RemoveFromFlows": [
    1,
    3
  ],
  "TzLocation": null,
  "Folder": null,
  "Associate": null,
  "ShipmentType": null,
  "Steps": [
    {
      "WorkflowStepId": 3,
      "WorkflowId": 2,
      "StepType": "SendEmail",
      "Rank": 1
    },
    {
      "WorkflowStepId": 4,
      "WorkflowId": 2,
      "StepType": "AddToList",
      "Rank": 2
    }
  ],
  "Triggers": [
    {
      "WorkflowTriggerId": 2,
      "WorkflowId": 2,
      "TriggerType": "AddedToSelection",
      "RestrictionGroups": [
        {},
        {}
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 413
        }
      }
    },
    {
      "WorkflowTriggerId": 243,
      "WorkflowId": 844,
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
          "FieldLength": 413
        }
      }
    }
  ],
  "Goals": [
    {
      "WorkflowGoalId": 2,
      "WorkflowId": 2,
      "GoalType": "SaleCreated",
      "RestrictionGroups": [
        {},
        {}
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 913
        }
      }
    },
    {
      "WorkflowGoalId": 189,
      "WorkflowId": 525,
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
          "FieldLength": 913
        }
      }
    }
  ],
  "Filter": null,
  "BlockLists": [
    846,
    881
  ],
  "ContentInfo": [
    {
      "WorkflowContentType": "Form",
      "Id": 830,
      "Actions": false,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 570
        }
      }
    },
    {
      "WorkflowContentType": "Form",
      "Id": 830,
      "Actions": false,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 570
        }
      }
    }
  ],
  "ExitFlowId": 399,
  "ExitSuccessFlowId": 663,
  "CreatedBy": null,
  "UpdatedBy": null,
  "CreatedDate": "2024-10-01T09:00:00+02:00",
  "UpdatedDate": "2024-11-28T15:00:00+01:00",
  "VisibleFor": [
    {
      "VisibleId": 888,
      "Visibility": "All",
      "DisplayValue": "aut",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 944
        }
      }
    },
    {
      "VisibleId": 888,
      "Visibility": "All",
      "DisplayValue": "aut",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 944
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 790
    }
  }
}
```
