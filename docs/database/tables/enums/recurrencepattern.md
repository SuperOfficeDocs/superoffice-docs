---
uid: enum-recurrencepattern
title: Enum values for RecurrencePattern
description: Lists the enum values for RecurrencePattern.
so.generated: true
keywords:
  - "database"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# RecurrencePattern Enum

Recurrence pattern (daily, weekly etc)

* Unknown = 0
* Daily = 1
* Weekly = 2
* Monthly = 3
* Yearly = 4
* Custom = 5

## Usage

* [RecurrenceRule](../recurrencerule.md).pattern - The recurrency pattern for a recurring event. Each recurring event has an appointment.recurrenceRuleId pointing to its pattern.
