---
title: POST Agents/Workflow/SaveWorkflowGoal
uid: v1WorkflowAgent_SaveWorkflowGoal
generated: true
---

# POST Agents/Workflow/SaveWorkflowGoal

```http
POST /api/v1/Agents/Workflow/SaveWorkflowGoal
```

Updates the existing WorkflowGoal or creates a new WorkflowGoal if the id parameter is empty








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

The WorkflowGoal to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| WorkflowGoalId | Integer | Primary key |
| WorkflowId | Integer | The flow this goal belongs to |
| GoalType | String | The workflow goal type |
| RestrictionGroups | Array | The restrictions (can be multiple groups) that make up the Workflow goal criteria |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: WorkflowGoal

| Property Name | Type |  Description |
|----------------|------|--------------|
| WorkflowGoalId | int32 | Primary key |
| WorkflowId | int32 | The flow this goal belongs to |
| GoalType | string | The workflow goal type |
| RestrictionGroups | array | The restrictions (can be multiple groups) that make up the Workflow goal criteria |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Workflow/SaveWorkflowGoal
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "WorkflowGoalId": 943,
  "WorkflowId": 832,
  "GoalType": "AddedToProject",
  "RestrictionGroups": [
    {
      "Name": "Olson LLC",
      "Description": "Fundamental multi-state website",
      "Rank": 669,
      "Restrictions": [
        {},
        {}
      ]
    },
    {
      "Name": "Olson LLC",
      "Description": "Fundamental multi-state website",
      "Rank": 669,
      "Restrictions": [
        {},
        {}
      ]
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "WorkflowGoalId": 907,
  "WorkflowId": 135,
  "GoalType": "AddedToProject",
  "RestrictionGroups": [
    {
      "Name": "Okuneva-Keebler",
      "Description": "Reactive optimal application",
      "Rank": 815,
      "Restrictions": [
        {},
        {}
      ]
    },
    {
      "Name": "Okuneva-Keebler",
      "Description": "Reactive optimal application",
      "Rank": 815,
      "Restrictions": [
        {},
        {}
      ]
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 768
    }
  }
}
```