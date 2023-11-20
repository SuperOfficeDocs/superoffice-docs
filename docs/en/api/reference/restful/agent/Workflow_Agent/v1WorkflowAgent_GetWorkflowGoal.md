---
title: POST Agents/Workflow/GetWorkflowGoal
uid: v1WorkflowAgent_GetWorkflowGoal
generated: true
---

# POST Agents/Workflow/GetWorkflowGoal

```http
POST /api/v1/Agents/Workflow/GetWorkflowGoal
```

Gets a WorkflowGoal object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| workflowGoalId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Workflow/GetWorkflowGoal?workflowGoalId=566
POST /api/v1/Agents/Workflow/GetWorkflowGoal?$select=name,department,category/id
```


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
POST /api/v1/Agents/Workflow/GetWorkflowGoal
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "WorkflowGoalId": 407,
  "WorkflowId": 863,
  "GoalType": "AddedToProject",
  "RestrictionGroups": [
    {
      "Name": "Kessler-Watsica",
      "Description": "Focused content-based parallelism",
      "Rank": 81,
      "Restrictions": [
        {},
        {}
      ]
    },
    {
      "Name": "Kessler-Watsica",
      "Description": "Focused content-based parallelism",
      "Rank": 81,
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
      "FieldType": "System.Int32",
      "FieldLength": 315
    }
  }
}
```