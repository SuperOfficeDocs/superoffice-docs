---
title: POST Agents/Workflow/AddAfterWorkflowStep
uid: v1WorkflowAgent_AddAfterWorkflowStep
generated: true
---

# POST Agents/Workflow/AddAfterWorkflowStep

```http
POST /api/v1/Agents/Workflow/AddAfterWorkflowStep
```

Add another step (and any of its substeps) after the given step id (which must exist), and move any following steps in the workflow further down the line.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Workflow/AddAfterWorkflowStep?$select=name,department,category/id
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

WorkflowStepId, SubStep 

| Property Name | Type |  Description |
|----------------|------|--------------|
| WorkflowStepId | Integer |  |
| SubStep | WorkflowStepBase | Workflow step carrier. <para /> Carrier object for WorkflowStepBase. Services for the WorkflowStepBase Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IWorkflowAgent">Workflow Agent</see>. |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: WorkflowStepBase

| Property Name | Type |  Description |
|----------------|------|--------------|
| WorkflowStepId | int32 | Primary key |
| WorkflowId | int32 | The flow this step belongs to |
| StepType | string | Step type |
| Rank | int32 | Step order |

## Sample request

```http!
POST /api/v1/Agents/Workflow/AddAfterWorkflowStep
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "WorkflowStepId": 571,
  "SubStep": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "WorkflowStepId": 117,
  "WorkflowId": 762,
  "StepType": "AddToList",
  "Rank": 823
}
```