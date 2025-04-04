---
title: POST Agents/Workflow/GetWorkflowWaitForAction
uid: v1WorkflowAgent_GetWorkflowWaitForAction
generated: true
---

# POST Agents/Workflow/GetWorkflowWaitForAction

```http
POST /api/v1/Agents/Workflow/GetWorkflowWaitForAction
```

Gets a WorkflowWaitForAction object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| workflowWaitForActionId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Workflow/GetWorkflowWaitForAction?workflowWaitForActionId=919
POST /api/v1/Agents/Workflow/GetWorkflowWaitForAction?$select=name,department,category/id
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
POST /api/v1/Agents/Workflow/GetWorkflowWaitForAction
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "WorkflowWaitForActionId": 703,
  "WorkflowStepId": 708,
  "WorkflowId": 369,
  "Rank": 537,
  "ActionType": "FormSubmitted",
  "RestrictionGroups": [
    {
      "Name": "Ratke-Beer",
      "Description": "Fully-configurable impactful time-frame",
      "Rank": 295,
      "Restrictions": [
        {},
        {}
      ]
    },
    {
      "Name": "Ratke-Beer",
      "Description": "Fully-configurable impactful time-frame",
      "Rank": 295,
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
      "FieldLength": 469
    }
  }
}
```