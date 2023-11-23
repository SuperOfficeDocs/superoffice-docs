---
title: POST Agents/Workflow/GetWorkflowStepOption
uid: v1WorkflowAgent_GetWorkflowStepOption
generated: true
---

# POST Agents/Workflow/GetWorkflowStepOption

```http
POST /api/v1/Agents/Workflow/GetWorkflowStepOption
```

Get WorkflowStepOption by ID







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Workflow/GetWorkflowStepOption?$select=name,department,category/id
```


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

## Request Body: request 

WorkflowStepOptionId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| WorkflowStepOptionId | Integer |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: WorkflowStepOptionBase

| Property Name | Type |  Description |
|----------------|------|--------------|
| OptionType | string | Type of option |
| WorkflowStepOptionId | int32 | Primary key |
| WorkflowStepId | int32 | The workflow step this instance belongs to |
| WorkflowId | int32 | The flow this instance belongs to |
| Name | string | The name of this option |
| Rank | int32 | The rank of this option |
| Steps | array | The steps to execute if this option/path is selected |

## Sample request

```http!
POST /api/v1/Agents/Workflow/GetWorkflowStepOption
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "WorkflowStepOptionId": 693
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "OptionType": "FormSubmission",
  "WorkflowStepOptionId": 467,
  "WorkflowStepId": 328,
  "WorkflowId": 830,
  "Name": "Rice-Smitham",
  "Rank": 55,
  "Steps": [
    {
      "WorkflowStepId": 843,
      "WorkflowId": 411,
      "StepType": "AddToList",
      "Rank": 563
    },
    {
      "WorkflowStepId": 843,
      "WorkflowId": 411,
      "StepType": "AddToList",
      "Rank": 563
    }
  ]
}
```