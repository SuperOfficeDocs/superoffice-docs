---
title: Radio buttons
uid: blogic_radiobuttons
description: Radio buttons
author:
so.date:
keywords:
so.topic: reference
---

# Radio buttons

Adds radio buttons to your screen.

## Configuration

| Setting           | Description                                         |
|:------------------|:----------------------------------------------------|
| label             | UI label for the group of options                   |
| buttons.length    | The number of items                                 |
| buttons.i.value   | Value of option                                     |
| buttons.i.label   | UI label of option                                  |
| buttons.i.checked | If true, will set the option as selected by default |

## Example

```crmscript
label = Meal
buttons.0.value = lunch
buttons.0.label = Lunch
buttons.0.checked = true
buttons.1.value = dinner
buttons.1.label = Dinner
buttons.length = 2
```

## Functions

### getValue()

Returns the value of the checked button.

### getFieldValue(String field)

| Field        | Description                                  |
|:-------------|:---------------------------------------------|
| checkedLabel | Returns the value of the checked radiobutton |

### setFieldValue(String action, Map values)

| Action     | Map keys                    | Description                  |
|:-----------|:----------------------------|:-----------------------------|
| addButton  | label<br>value<br>checked | Adds a button                |
| setChecked | buttonValue                 | Sets a button value (0 or 1) |

```crmscript
Map m;
m.insert("label", "Red");
m.insert("value", "red");
m.insert("checked", "0" );
```

### toString()

Converts the value of the checked button to a string.

### toInteger()

Converts the selected value to a number.
