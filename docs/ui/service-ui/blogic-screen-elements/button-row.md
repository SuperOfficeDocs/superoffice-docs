---
title: blogic_button_row
description: Button row
author:
so.date:
keywords:
so.topic: reference
---

# Button row

This element adds a row of clickable buttons to your screen.

## Configuration

| Setting           | Description                                                             |
|:------------------|:------------------------------------------------------------------------|
| buttons.n.name    | Adds a name to the nth button                                           |
| buttons.n.label   | Adds a value to the nth button                                          |
| buttons.n.warning | Adds a warning message<br>Shown in a pop-up when the button is pressed |
| buttons.n.iconurl | Custom icon to use                                                      |
| buttons.n.style   | *See list of styles*                                                    |
| align             | Justifies the row<br>left, center, or right (default)                  |

### Styles

* StyleNormal
* StyleSmall
* StyleIconOnly
* StyleBlue
* StyleLargeBlue
* StyleGreen
* StyleLargeGreen
* StyleRed

## Example

```crmscript
buttons.0.name = ok
buttons.0.label = Ok
buttons.1.warning = Are you sure?
buttons.1.name = delete
buttons.1.label = Delete
buttons.2.name = cancel
buttons.2.label = Cancel
buttons.length = 3
```

## Functions

### setFieldValue(String action, Map values)

| Action    | Map keys               | Description                                            |
|:----------|:-----------------------|:-------------------------------------------------------|
| addButton | name<br>label<br>warning<br>iconUrl<br>className | Adds a button to the row |

> [!NOTE]
> The name of the buttons **must be mapped to scripts** that might be run for the current screen.
