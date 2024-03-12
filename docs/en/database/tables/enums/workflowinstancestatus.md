---
uid: enum-workflowinstancestatus
title: Enum values for WorkflowInstanceStatus
description: Lists the enum values for WorkflowInstanceStatus.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# WorkflowInstanceStatus Enum

Status of the workflow instance

| Name | Value | Description |
|------|-------|-------------|
|None|0|None|
|Idle|1|Idle - internally used for two stage insert to avoid race condition duplicates|
|Active|2|Active (Running)|
|Finished|3|Finished|
|FinishedWithSuccess|4|Finished sith success (success criteria reached)|
|DropOut|5|Dropped out (or faulted) for some given reason|
|Cancelled|6|Cancelled|

## Usage

* [workflow_instance](../workflow-instance.md).status - A set of properties related to the workflow instance of one participant going through the flow
