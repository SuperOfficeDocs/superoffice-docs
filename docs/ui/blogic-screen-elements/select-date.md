---
title: blogic_select_date
description: Select Date
author:
so.date:
keywords:
so.topic: reference
---

# Select Date

This element is used to input a [Date](../../crmscript/datatypes/date-type.md).

## Configuration

| Setting   | Description                          |
|:----------|:-------------------------------------|
| mayBeNull | Whether the field is required (Bool) |
| empty     | Whether the field is required (Bool) |

## Functions

### setValue(String date)

Sets the selected `Date`. The value must be formatted in a standard way, for example, YYYY-MM-DD.

### toString()

Returns the date as a string formatted as **YYYY-MM-DD**.
