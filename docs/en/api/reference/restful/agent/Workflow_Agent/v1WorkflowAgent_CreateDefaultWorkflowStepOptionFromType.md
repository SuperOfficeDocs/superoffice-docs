---
title: POST Agents/Workflow/CreateDefaultWorkflowStepOptionFromType
uid: v1WorkflowAgent_CreateDefaultWorkflowStepOptionFromType
generated: true
---

# POST Agents/Workflow/CreateDefaultWorkflowStepOptionFromType

```http
POST /api/v1/Agents/Workflow/CreateDefaultWorkflowStepOptionFromType
```

Creates a new carrier from the option type given, with the right kind of properties, defaults set.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Workflow/CreateDefaultWorkflowStepOptionFromType?$select=name,department,category/id
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

OptionType 

| Property Name | Type |  Description |
|----------------|------|--------------|
| OptionType | String |  |

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
POST /api/v1/Agents/Workflow/CreateDefaultWorkflowStepOptionFromType
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "OptionType": "FormSubmission"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "OptionType": "FormSubmission",
  "WorkflowStepOptionId": 193,
  "WorkflowStepId": 898,
  "WorkflowId": 845,
  "Name": "Simonis-Hilpert",
  "Rank": 241,
  "Steps": [
    {
      "WorkflowStepId": 402,
      "WorkflowId": 627,
      "StepType": "AddToList",
      "Rank": 599
    },
    {
      "WorkflowStepId": 402,
      "WorkflowId": 627,
      "StepType": "AddToList",
      "Rank": 599
    }
  ]
}
```