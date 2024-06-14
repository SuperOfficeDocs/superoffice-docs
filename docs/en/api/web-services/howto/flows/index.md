---
uid: api-flows-index
title: Flows
description: Introduction to working with Flows through the API
author: Eivind Fasting
so.date: 05.24.2024
keywords: Flows
so.topic: concept
---

# Introduction to working with Flows through the API

A flow is an automated sequence of marketing-related steps, such as sending a message, updating participant information, or creating an activity. The conceptual overview of Flow can be found in the [Marketing automation - flows][1], and this page will focus on how to create a Flow through the API.

## Creating an EmailFlow

Creating a new EmailFlow can be done by:

1. [Create default email flow][4] with the [CreateDefaultEmailFlow Agent][2].
2. [Create Triggers][5] and inject them into the email flow object created in step 1.
3. [Create Steps][6] and inject them into the email flow object created in step 1.
4. [Save the Email Flow][7] through [SaveEmailFlow Agent][3].

> [!NOTE]
> Code-examples can also be found on [git][8]!

<!-- Referenced links -->
[1]: ../../marketing/flows/learn/index.md
[2]: ../reference/restful/agent/Workflow_Agent/v1WorkflowAgent_CreateDefaultEmailFlow.md
[3]: ../reference/restful/agent/Workflow_Agent/v1WorkflowAgent_SaveEmailFlow.md
[4]: ./howto/flows-createdefault-emailflow.md
[5]: ./howto/flows-create-trigger.md
[6]: ./howto/flows-create-step.md
[7]: ./howto/flows-save-emailflow.md
[8]: https://github.com/SuperOffice/RESTful-HTTP-Queries/blob/eivinds/src/Flow.http