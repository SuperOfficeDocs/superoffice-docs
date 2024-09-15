---
uid: enum-recurrencepattern
title: Enum values for RecurrencePattern
description: Lists the enum values for RecurrencePattern.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# RecurrencePattern Enum

Recurrence pattern (daily, weekly etc)

| Name | Value | Description |
|------|-------|-------------|
|Unknown|0|0: Unknown/undecided type|
|Daily|1|Dayly recurrence.|
|Weekly|2|Weekly recurrence.|
|Monthly|3|Monthly recurrence.|
|Yearly|4|Yearly recurrence.|
|Custom|5|Custom recurrence, only dates are specified.  See RecurrenceDayPattern for details|

## Usage

* [RecurrenceRule](../recurrencerule.md).pattern - The recurrency pattern for a recurring event. Each recurring event has an appointment.recurrenceRuleId pointing to its pattern.
