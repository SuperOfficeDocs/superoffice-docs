---
uid: enum-workflowtriggertype
title: Enum values for WorkflowTriggerType
description: Lists the enum values for WorkflowTriggerType.
so.generated: true
keywords:
  - "database"
so.date: 03.01.2023
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# WorkflowTriggerType Enum

What kind of trigger is this

| Name | Value | Description |
|------|-------|-------------|
|None|0|None|
|SendEmail|1|ContactCreated|
|SendSMS|2|ContactUpdated|
|WaitForTime|3|AddedToProject|
|WaitForAction|4|CreatedRequest|
|Split|5|LinkClicked|
|UpdateContact|6|AddedToSelection|
|AddToList|7|FormSubmitted|
|RemoveFromList|8|AddedMessage|
|CreateRequest|9|StartedChat|
|CreateFollowUp|10|OrderPlaced|
|CreateSale|11|SaleCreated|
|NotifyByEmail|12|SaleSold|
|NotifyBySMS|13|SaleLost|

## Usage

* [workflow_trigger](../workflow-trigger.md).trigger_type - A set of triggers related to a workflow.
