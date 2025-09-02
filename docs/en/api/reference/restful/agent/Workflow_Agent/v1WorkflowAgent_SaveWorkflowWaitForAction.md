---
title: POST Agents/Workflow/SaveWorkflowWaitForAction
uid: v1WorkflowAgent_SaveWorkflowWaitForAction
generated: true
content_type: reference
---

# POST Agents/Workflow/SaveWorkflowWaitForAction

```http
POST /api/v1/Agents/Workflow/SaveWorkflowWaitForAction
```

Updates the existing WorkflowWaitForAction or creates a new WorkflowWaitForAction if the id parameter is 0.








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

## Request Body: workflowWaitForAction 

The WorkflowWaitForAction that is saved 

| Property Name | Type |  Description |
|----------------|------|--------------|
| WorkflowWaitForActionId | Integer | Primary key |
| WorkflowStepId | Integer | The workflow step this instance belongs to |
| WorkflowId | Integer | Workflow id |
| Rank | Integer | The rank of this action |
| ActionType | String | The type of action |
| RestrictionGroups | Array | The restrictions (can be multiple groups) that make up the Workflow action criteria |

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
POST /api/v1/Agents/Workflow/SaveWorkflowWaitForAction
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "WorkflowWaitForActionId": 498,
  "WorkflowStepId": 453,
  "WorkflowId": 501,
  "Rank": 416,
  "ActionType": "FormSubmitted",
  "RestrictionGroups": [
    {
      "Name": "Hodkiewicz LLC",
      "Description": "Object-based radical website",
      "Rank": 210,
      "Restrictions": [
        {},
        {}
      ]
    },
    {
      "Name": "Hodkiewicz LLC",
      "Description": "Object-based radical website",
      "Rank": 210,
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
  "WorkflowWaitForActionId": 801,
  "WorkflowStepId": 991,
  "WorkflowId": 151,
  "Rank": 782,
  "ActionType": "FormSubmitted",
  "RestrictionGroups": [
    {
      "Name": "Harber Inc and Sons",
      "Description": "Compatible systemic website",
      "Rank": 543,
      "Restrictions": [
        {},
        {}
      ]
    },
    {
      "Name": "Harber Inc and Sons",
      "Description": "Compatible systemic website",
      "Rank": 543,
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
      "FieldLength": 3
    }
  }
}
```