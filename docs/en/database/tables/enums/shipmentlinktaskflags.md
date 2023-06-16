---
uid: enum-shipmentlinktaskflags
title: Enum values for ShipmentLinkTaskFlags
description: Lists the enum values for ShipmentLinkTaskFlags.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# ShipmentLinkTaskFlags Enum

Flags that control how the task is created

| Name | Value | Description |
|------|-------|-------------|
|None|0|No special options, values taken from other fields|
|AssignToOurContact|1|Assign task to contact owner|
|UseNextAvailableTime|2|Use the soonest-available working time slot (after the task-creation evcent is triggered)|
|IsAssignment|4|Create as an assignment (shown in Invitation dialog)|

## Usage

* [s_link](../s-link.md).task_flags - Links in messages to measure success rate of a campaign.
