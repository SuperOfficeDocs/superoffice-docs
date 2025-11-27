---
title: POST Agents/Workflow/CreateDefaultWorkflowStepFromType
uid: v1WorkflowAgent_CreateDefaultWorkflowStepFromType
generated: true
content_type: reference
---

# POST Agents/Workflow/CreateDefaultWorkflowStepFromType

```http
POST /api/v1/Agents/Workflow/CreateDefaultWorkflowStepFromType
```

Creates a new carrier from the step type given, with the right kind of properties, defaults set.


NsApiSlow threshold: 3000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Workflow/CreateDefaultWorkflowStepFromType?$select=name,department,category/id
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

StepType 

| Property Name | Type |  Description |
|----------------|------|--------------|
| StepType | String |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: WorkflowStepBase

| Property Name | Type |  Description |
|----------------|------|--------------|
| WorkflowStepId | int32 | Primary key |
| WorkflowId | int32 | The workflow to connect to |
| StepType | string | Step type |
| Rank | int32 | Step order |

## Sample request

[!include[sample request](../../samples/agent/request/v1WorkflowAgent_CreateDefaultWorkflowStepFromType.md)]

## Sample response

[!include[sample response](../../samples/agent/response/v1WorkflowAgent_CreateDefaultWorkflowStepFromType.md)]