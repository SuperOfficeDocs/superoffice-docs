---
uid: enum-workflowgoaltype
title: Enum values for WorkflowGoalType
description: Lists the enum values for WorkflowGoalType.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# WorkflowGoalType Enum

A goal that will conclude the workflow

| Name | Value | Description |
|------|-------|-------------|
|None|0|None|
|PersonUpdated|1|PersonUpdated|
|SaleCreatedOnPerson|2|SaleCreatedOnPerson|
|SaleCreatedOnCompany|3|SaleCreatedOnCompany|
|AppointmentCreated|4|AppointmentCreated|
|AddedToProject|5|AddedToProject|
|AddedToSelection|6|AddedToSelection|
|FormSubmitted|7|FormSubmitted|
|HadChat|8|HadChat|
|LinkClicked|9|LinkClicked|
|RequestCreated|10|RequestCreated|

## Usage

* [workflow_goal](../workflow-goal.md).goal_type - A set of goals related to a workflow. Some goals will have search criterias associated with it to determine if the goal has been reached.
