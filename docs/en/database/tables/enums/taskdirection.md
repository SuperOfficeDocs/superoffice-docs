---
uid: enum-taskdirection
title: Enum values for TaskDirection
description: Lists the enum values for TaskDirection.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# TaskDirection Enum

1 = incoming, 2 = outgoing, see EAppntDirection

| Name | Value | Description |
|------|-------|-------------|
|Unknown|0|Unknown - used when initializing|
|Incoming|1|The task is sent in to SuperOffice CRM 5|
|Outgoing|2|The task is sent out from SuperOffice CRM 5|
|SaintAll|3|All' choice for Saint. This is NOT an acceptable value for a task definition, but is used by the Saint system for indexing all directions|

## Usage

* [Task](../task.md).direction - Task list table, activity types, like Phone, Meeting
