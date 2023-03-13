---
title: POST Agents/Workflow/GetWorkflowStep
uid: v1WorkflowAgent_GetWorkflowStep
---

# POST Agents/Workflow/GetWorkflowStep

```http
POST /api/v1/Agents/Workflow/GetWorkflowStep
```

Gets a WorkflowStep object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| workflowStepId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Workflow/GetWorkflowStep?workflowStepId=132
POST /api/v1/Agents/Workflow/GetWorkflowStep?$select=name,department,category/id
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

### Response body: WorkflowStep

| Property Name | Type |  Description |
|----------------|------|--------------|
| WorkflowStepId | int32 | Primary key |
| StepType | string | Step type |
| SubSteps | array | Sub/Child steps in the workflow. When the step line forks into more than one is given by the StepType. |
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Workflow/GetWorkflowStep
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "WorkflowStepId": 141,
  "StepType": "AddToList",
  "SubSteps": [
    {
      "WorkflowStepId": 287,
      "StepType": "AddToList",
      "SubSteps": [
        {},
        {}
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 314
        }
      }
    },
    {
      "WorkflowStepId": 287,
      "StepType": "AddToList",
      "SubSteps": [
        {},
        {}
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 314
        }
      }
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