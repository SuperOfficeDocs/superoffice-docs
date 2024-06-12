---
uid: api-flows-createdefault-emailflow
title: Flows
description: Create an Email Flow object
author: Eivind Fasting
so.date: 06.12.2024
keywords: Flows
so.topic: concept
---

# Create an Email Flow object

The [CreateDefaultEmailFlow Agent][1] endpoint in the REST API will return a pre-populated default Email Flow object. Using this makes it easier to both get default values from the system and get a full overview of what the object looks like.

Request

```http
POST https://{{env}}.superoffice.com/{{tenant}}/v1/Agents/Workflow/CreateDefaultEmailFlow
Authorization: Bearer {{access_token}}
Accept: application/json
```

Response

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

> [!NOTE]
> In this example the json has been edited/cut for clarity.

Some key properties are described more in detail, as they are relevant to understand for the rest of the content of this page:

1. EmailFlowId - This is the unique identification of the Flow. This is set by the system upon saving the Flow, and should not be set manually.
2. Name - Unique name for the Flow, as shown inside of SuperOffice. This should be set to a user-readable string, in the following example 'My first flow'.
3. Status - Defines if the Flow is active or stopped.
4. Triggers - An array of triggers that starts the Flow.
5. Steps - An array of steps which builds up the Flow.

Additional properties can be found in the documentation for [CreateDefaultEmailFlow Agent][1].

<!-- Reference links -->
[1]: ../../reference/restful/agent/Workflow_Agent/v1WorkflowAgent_CreateDefaultEmailFlow.md
