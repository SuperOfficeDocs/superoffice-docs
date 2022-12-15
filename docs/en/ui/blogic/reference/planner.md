---
title: Planner
uid: blogic_planner
description: Planner
author:
so.date:
keywords:
so.topic: reference
---

# Planner

This element will display a planner (day schedule style).

It can contain one or more columns, which may represent multiple days, multiple people, and so on.

## Configuration

| Setting                 | Description                                                                                            |
|:------------------------|:-------------------------------------------------------------------------------------------------------|
| startHour               | The initial start of the day <br>For example, "8" for 08:00                                          |
| exactPosition           | Granularity:<br>true = use exact start and end of follow-up (minutes)<br>false = round follow-up down to nearest half hour |
| roundUpAppointment      | Whether to round up to nearest half hour instead of down<br>ignored if exactPosition = true           |
| overlappingAppointments | How to display overlapping follow-ups<br>true = draw overlapping<br>false = draw side-by-side      |
| hourSize                | Vertical space for 1 hour (in pixels)<br>Default = 40                                                |
| editEntryUrl            | The base URL to redirect to for editing an entry                                                       |
| newEntryUrl             | The base URL to redirect to for creating a new entry (when dragging in the planner)                    |

## Functions

### setFieldValue(String action, Map values)

| Action                  | Map keys                          | Description                                                                         |
|:------------------------|:----------------------------------|:------------------------------------------------------------------------------------|
| addDay                  | id<br>header<br>highlightStart<br>highlightStop | Adds a day to the calender                                      |
| addAppointment          | start<br>stop<br>id<br>body | Adds a follow-up to the calender                                                    |
| roundUpAppointment      | value                             | Whether to round up duration to nearest half hour                                   |
| overlappingAppointments | value                             | Whether to let follow-ups overlap if one ends after another starts                  |
| exactPosition           | value                             | Whether start and stop times are set exactly (true) or to nearest half hour (false) |
| hourSize                |                                   | Height in pixels per hour<br>Minimum height is 30                                  |

These fields are used for specifying the light area in the planner, normally indicating business hours (for example, 09:00 to 17:00).
