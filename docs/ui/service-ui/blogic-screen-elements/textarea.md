---
title: Textarea
uid: blogic_textarea
description: Textarea
author:
so.date:
keywords:
so.topic: reference
---

# Textarea

This element creates an input field that can span several lines.

## Configuration

| Setting   | Description                                        |
|:----------|:---------------------------------------------------|
| label     | UI label                                           |
| maxLength | The max number of characters the field can contain |
| cols      | The width of the text area (in characters)         |
| rows      | The height of the text area (in characters)        |
| notEmpty  | Whether an empty choice is OK (Bool)               |
| readOnly  | Whether the field can be changed (Bool)            |

## Example

```crmscript
label = Comments
cols = 40
rows = 5
notEmpty = false
```

## Functions

### setValue(String value)

Sets the initial contents of the text area.

### toString()

Returns the value of the text area.
