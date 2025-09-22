---
title: POST Agents/Workflow/CreateDefaultWorkflowWaitForAction
uid: v1WorkflowAgent_CreateDefaultWorkflowWaitForAction
generated: true
content_type: reference
---

# POST Agents/Workflow/CreateDefaultWorkflowWaitForAction

```http
POST /api/v1/Agents/Workflow/CreateDefaultWorkflowWaitForAction
```

Loading default values into a new WorkflowWaitForAction.








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

### Response body: WorkflowWaitForAction

| Property Name | Type |  Description |
|----------------|------|--------------|
| WorkflowWaitForActionId | int32 | Primary key |
| WorkflowStepId | int32 | The workflow step this instance belongs to |
| WorkflowId | int32 | Workflow id |
| Rank | int32 | The rank of this action |
| ActionType | string | The type of action |
| RestrictionGroups | array | The restrictions (can be multiple groups) that make up the Workflow action criteria |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Workflow/CreateDefaultWorkflowWaitForAction
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "WorkflowWaitForActionId": 931,
  "WorkflowStepId": 660,
  "WorkflowId": 301,
  "Rank": 649,
  "ActionType": "FormSubmitted",
  "RestrictionGroups": [
    {
      "Name": "Hirthe, Hackett and Roberts",
      "Description": "Networked disintermediate orchestration",
      "Rank": 644,
      "Restrictions": [
        {},
        {}
      ]
    },
    {
      "Name": "Hirthe, Hackett and Roberts",
      "Description": "Networked disintermediate orchestration",
      "Rank": 644,
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
      "FieldLength": 357
    }
  }
}
```