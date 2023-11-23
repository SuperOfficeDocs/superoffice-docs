---
title: POST Agents/Workflow/CreateDefaultWorkflowGoal
uid: v1WorkflowAgent_CreateDefaultWorkflowGoal
generated: true
---

# POST Agents/Workflow/CreateDefaultWorkflowGoal

```http
POST /api/v1/Agents/Workflow/CreateDefaultWorkflowGoal
```

Set default values into a new WorkflowGoal.


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
POST /api/v1/Agents/Workflow/CreateDefaultWorkflowGoal
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "WorkflowGoalId": 186,
  "WorkflowId": 913,
  "GoalType": "AddedToProject",
  "RestrictionGroups": [
    {
      "Name": "Bailey LLC",
      "Description": "Fully-configurable asynchronous task-force",
      "Rank": 416,
      "Restrictions": [
        {},
        {}
      ]
    },
    {
      "Name": "Bailey LLC",
      "Description": "Fully-configurable asynchronous task-force",
      "Rank": 416,
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
      "FieldLength": 348
    }
  }
}
```