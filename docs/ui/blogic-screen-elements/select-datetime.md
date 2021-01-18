---
title: blogic_select_datetime
description: Select DateTime
author:
so.date:
keywords:
so.topic: reference
---

# Select DateTime

This element is used to input a [DateTime][1].

## Configuration

| Setting   | Description                          |
|:----------|:-------------------------------------|
| mayBeNull | Whether the field is required (Bool) |
| empty     | Whether the field is required (Bool) |

## Functions

### setValue(String dateTime)

Sets the selected `DateTime`. The value must be formatted in a standard way, for example, YYYY-MM-DD HH:MI:SS.

### toString()

Returns the date as a string formatted as **YYYY-MM-DD HH:MI:SS**.

<!-- Referenced links -->
[1]: ../../crmscript/datatypes/datetime-type.md
