---
uid: api-rest-flow-create
title: Create an EmailFlow object
description: Create an EmailFlow object
keywords: flow, EmailFlow, CreateDefaultEmailFlow
author: Eivind Fasting
date: 06.12.2024
version: 10.3.5
content_type: howto
audience: api
audience_tooltip: SuperOffice APIs and database
redirect_from: /en/api/netserver/web-services/howto/flows/rest-create-default-email-flow
---

# Create an EmailFlow object

The **CreateDefaultEmailFlow Agent** REST endpoint returns a pre-populated default EmailFlow object, providing both default system values and a comprehensive overview of the object structure.

## Request

```http
POST https://{{env}}.superoffice.com/{{tenant}}/v1/Agents/Workflow/CreateDefaultEmailFlow HTTP/1.1
Authorization: Bearer {{access_token}}
Accept: application/json
```

## Response

```json
{
  "EmailFlowId": 0,
  "Name": "",
  "Description": "",
  "Status": "Stopped",
  "JumpToFinish": false,
  "StartOnlyOnce": true,
  "UseTimeframe": false,
  "SelectedDays": "Unknown",
  "Steps": [],
  "Triggers": [],
  "Goals": [],
  "Filter": {
    "RestrictionGroups": [],
    "TableRight": null,
    "FieldProperties": {}
  },
  "BlockLists": [],
  "ContentInfo": [],
  "ExitFlowId": 0,
  "ExitSuccessFlowId": 0,
  "CreatedBy": null,
  "UpdatedBy": null,
  "CreatedDate": "0001-01-01T00:00:00Z",
  "UpdatedDate": "0001-01-01T00:00:00Z",
}
```

The above JSON has been edited/cut for clarity.

### Key flow properties

| Property | Description |
|---|---|
| EmailFlowId | Unique identifier assigned by the system upon saving the flow. Should not be set manually. |
| Name | Unique name of the flow as displayed in SuperOffice (for example, 'My first flow'). |
| Status | Indicates whether the flow is running, paused, or stopped. |
| Triggers | Array of events that kick off the flow. |
| Steps| Array of steps that define the sequence of actions within the flow. |

More properties are detailed in the [CreateDefaultEmailFlow Agent reference][1].

<!-- Referenced links -->
[1]: ../../../reference/restful/agent/Workflow_Agent/v1WorkflowAgent_CreateDefaultEmailFlow.md
