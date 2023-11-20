---
title: POST Agents/Workflow/CreateDefaultWorkflowTrigger
uid: v1WorkflowAgent_CreateDefaultWorkflowTrigger
generated: true
---

# POST Agents/Workflow/CreateDefaultWorkflowTrigger

```http
POST /api/v1/Agents/Workflow/CreateDefaultWorkflowTrigger
```

Set default values into a new WorkflowTrigger.


NetServer calculates default values on the entity, which is required when creating/storing a new instance







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
POST /api/v1/Agents/Workflow/CreateDefaultWorkflowTrigger
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "WorkflowTriggerId": 143,
  "WorkflowId": 868,
  "TriggerType": "AddedMessage",
  "RestrictionGroups": [
    {
      "Name": "Davis LLC",
      "Description": "Open-source 24 hour orchestration",
      "Rank": 885,
      "Restrictions": [
        {},
        {}
      ]
    },
    {
      "Name": "Davis LLC",
      "Description": "Open-source 24 hour orchestration",
      "Rank": 885,
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
      "FieldLength": 879
    }
  }
}
```