---
title: POST Agents/Workflow/SaveWorkflowTrigger
uid: v1WorkflowAgent_SaveWorkflowTrigger
---

# POST Agents/Workflow/SaveWorkflowTrigger

```http
POST /api/v1/Agents/Workflow/SaveWorkflowTrigger
```

Updates the existing WorkflowTrigger or creates a new WorkflowTrigger if the id parameter is empty








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

The WorkflowTrigger to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| WorkflowTriggerId | Integer | Primary key |
| WorkflowId | Integer | The flow this trigger belongs to |
| TriggerType | String | The workflow trigger type |
| RestrictionGroups | Array | The restrictions (can be multiple groups) that make up the Workflow trigger criteria |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: WorkflowTrigger

| Property Name | Type |  Description |
|----------------|------|--------------|
| WorkflowTriggerId | int32 | Primary key |
| WorkflowId | int32 | The flow this trigger belongs to |
| TriggerType | string | The workflow trigger type |
| RestrictionGroups | array | The restrictions (can be multiple groups) that make up the Workflow trigger criteria |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Workflow/SaveWorkflowTrigger
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "WorkflowTriggerId": 419,
  "WorkflowId": 39,
  "TriggerType": "AddToList",
  "RestrictionGroups": [
    {
      "Name": "Kohler, Wiza and Bernhard",
      "Description": "Future-proofed discrete artificial intelligence",
      "Rank": 599,
      "Restrictions": [
        {},
        {}
      ]
    },
    {
      "Name": "Kohler, Wiza and Bernhard",
      "Description": "Future-proofed discrete artificial intelligence",
      "Rank": 599,
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
  "WorkflowTriggerId": 398,
  "WorkflowId": 405,
  "TriggerType": "AddToList",
  "RestrictionGroups": [
    {
      "Name": "D'Amore Inc and Sons",
      "Description": "Open-source system-worthy protocol",
      "Rank": 183,
      "Restrictions": [
        {},
        {}
      ]
    },
    {
      "Name": "D'Amore Inc and Sons",
      "Description": "Open-source system-worthy protocol",
      "Rank": 183,
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
      "FieldLength": 318
    }
  }
}
```