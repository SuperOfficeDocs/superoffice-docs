---
uid: api-flows
title: Introduction to flow APIs
description: Introduction to working with Flows through the API
keywords: flow, EmailFlow
author: Eivind Fasting
date: 05.24.2024
version: 10.3.5
content_type: concept
audience: api
audience_tooltip: SuperOffice APIs and database
redirect_from: /en/api/netserver/web-services/howto/flows/index
---

# Introduction to working with flows through the APIs

A flow is an automated sequence of marketing-related steps, such as sending a message, updating participant information, or creating an activity. For a conceptual overview, see [the Learn - Marketing section][1]. This page details how to create flows using the API.

## Creating an EmailFlow

To create a new flow programmatically:

1. [Create a default `EmailFlow` object][4]: Start with the [CreateDefaultEmailFlow Agent][2] to initialize a new flow.

    ```http
    POST /api/v1/Agents/Workflow/CreateDefaultEmailFlow
    ```

1. [Add triggers][5]: Include triggers (in the `EmailFlow` object) to set conditions for when a person is suggested as participant in the flow.

    ```http
    POST /api/v1/Agents/Workflow/CreateDefaultWorkflowTrigger
    ```

1. [Add steps][6]: Define and incorporate steps (into the `EmailFlow` object) to sequence the flow of actions.

    ```http
    POST /api/v1/Agents/Workflow/CreateDefaultWorkflowStepFromType
    ```

1. [Save the flow][7]: Use the [SaveEmailFlow Agent][3] to finalize and save the configured email flow.

    ```http
    POST /api/v1/Agents/Workflow/SaveEmailFlow
    ```

> [!TIP]
> Explore code examples on [GitHub][8]!

<!-- Referenced links -->
[1]: ../../../../marketing/flows/learn/index.md
[2]: ../../../reference/restful/agent/Workflow_Agent/v1WorkflowAgent_CreateDefaultEmailFlow.md
[3]: ../../../reference/restful/agent/Workflow_Agent/v1WorkflowAgent_SaveEmailFlow.md
[4]: rest-create-default-email-flow.md
[5]: rest-create-flow-trigger.md
[6]: rest-create-flow-step.md
[7]: rest-save-flow.md
[8]: https://github.com/SuperOffice/RESTful-HTTP-Queries/blob/eivinds/src/Flow.http
