---
title: POST Agents/Workflow/SaveWorkflowStepOption
uid: v1WorkflowAgent_SaveWorkflowStepOption
generated: true
---

# POST Agents/Workflow/SaveWorkflowStepOption

```http
POST /api/v1/Agents/Workflow/SaveWorkflowStepOption
```

Updates the existing WorkflowStepOption or creates a new WorkflowStepOption if the id parameter is empty








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

The WorkflowStepOption to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| WorkflowStepOptionId | Integer | Primary key |
| WorkflowStepId | Integer | The workflow step this instance belongs to |
| WorkflowId | Integer | The flow this instance belongs to |
| Key | String | A key used to refer to this option |
| Name | String | The name of this option |
| Rank | Integer | The rank of this option |
| Steps | Array | The steps to execute if this option/path is selected |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: WorkflowStepOption

| Property Name | Type |  Description |
|----------------|------|--------------|
| WorkflowStepOptionId | int32 | Primary key |
| WorkflowStepId | int32 | The workflow step this instance belongs to |
| WorkflowId | int32 | The flow this instance belongs to |
| Key | string | A key used to refer to this option |
| Name | string | The name of this option |
| Rank | int32 | The rank of this option |
| Steps | array | The steps to execute if this option/path is selected |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Workflow/SaveWorkflowStepOption
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "WorkflowStepOptionId": 890,
  "WorkflowStepId": 524,
  "WorkflowId": 368,
  "Key": "rerum",
  "Name": "Paucek Group",
  "Rank": 315,
  "Steps": [
    {
      "WorkflowStepId": 957,
      "WorkflowId": 561,
      "StepType": "AddToList",
      "Rank": 25
    },
    {
      "WorkflowStepId": 957,
      "WorkflowId": 561,
      "StepType": "AddToList",
      "Rank": 25
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "WorkflowStepOptionId": 648,
  "WorkflowStepId": 35,
  "WorkflowId": 482,
  "Key": "unde",
  "Name": "Gleichner, Beier and Hackett",
  "Rank": 442,
  "Steps": [
    {
      "WorkflowStepId": 717,
      "WorkflowId": 105,
      "StepType": "AddToList",
      "Rank": 120
    },
    {
      "WorkflowStepId": 717,
      "WorkflowId": 105,
      "StepType": "AddToList",
      "Rank": 120
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 332
    }
  }
}
```