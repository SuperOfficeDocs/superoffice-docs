---
uid: enum-workflowsteptype
title: Enum values for WorkflowStepType
description: Lists the enum values for WorkflowStepType.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# WorkflowStepType Enum

Step type

| Name | Value | Description |
|------|-------|-------------|
|None|0|None|
|SendEmail|1|SendEmail|
|SendSMS|2|SendSMS|
|WaitForTime|3|WaitForTime|
|WaitForAction|4|WaitForAction|
|Split|5|Split|
|UpdateParticipant|6|UpdateParticipant|
|AddToList|7|AddToList|
|RemoveFromList|8|RemoveFromList|
|CreateRequest|9|CreateRequest|
|CreateFollowUp|10|CreateFollowUp|
|CreateSale|11|CreateSale|
|NotifyByEmail|12|NotifyByEmail|
|NotifyBySMS|13|NotifyBySMS|
|RunScript|14|RunScript|

## Usage

* [workflow_step](../workflow-step.md).step_type - A set of steps related to a workflow.
