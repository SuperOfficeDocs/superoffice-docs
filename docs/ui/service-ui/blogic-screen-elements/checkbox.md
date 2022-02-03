---
title: Checkbox
uid: blogic_checkbox
description: Checkbox
author:
so.date:
keywords:
so.topic: reference
---

# Checkbox

Adds a checkbox to your screen.

## Configuration

| Setting     | Description                                                          |
|:------------|:---------------------------------------------------------------------|
| label       | UI label, displayed to the left of the box                           |
| suffixLabel | Optional description, displayed to the right of the box              |
| warning     | Adds a warning message<br>Shown in a pop-up when the box is checked |

## Functions

### setValue(String isSelected)

Marks the checkbox as selected ("1") or unselected ("0").

### toBool()

Returns the value of the checkbox as a Bool, true or false.

### toString()

Returns the value of the checkbox as a string, "1" or "0".
