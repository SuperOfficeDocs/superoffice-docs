---
title: Select Time Span
uid: blogic_select_timespan
description: Select Time Span
author:
so.date:
keywords:
so.topic: reference
---

# Select Time Span

This element adds a text input encoding the time-span in a string and a popup that lets you select time-spans with drop-down menus for hours, minutes, and so on.

## Configuration

The time-spans that can be selected are set to true in the config.

| Setting         | Description                                                                   |
|:----------------|:------------------------------------------------------------------------------|
| days            | Whether to add a drop-down for days                                           |
| hours           | Whether to add a drop-down for hours                                          |
| minutes         | Whether to add a drop-down for minutes                                        |
| seconds         | Whether to add a drop-down for seconds                                        |
| empty           | Whether the field is required (Bool)                                          |
| negatives       | Whether negative increments are allowed                                       |
| enableStartStop | Whether the element can be started and stopped (and count seconds if started) |
| returnMinutes   | Whether `toInteger()` returns minutes or seconds (default)                    |
| maxNum          | The upper limit of the time-span                                              |
| minJumps        | The smallest increment of the time-span                                       |

## Example

```crmscript
days = false
hours = true
minutes = true
seconds = false

negatives = true

maxNum = 24
minJumps = 15
```

This configuration adds a set of drop-down menus to select hours and minutes for the time-span. The user can select up to 24 hours and minutes in 15-minute increments.
