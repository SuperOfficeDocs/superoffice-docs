---
title: blogic_listbox
description: List box
author:
so.date:
keywords:
so.topic: reference
---

# List box

This element adds a drop-down menu to your screen.

## Configuration

| Setting            | Description                                            |
|:-------------------|:-------------------------------------------------------|
| label              | UI label of the list                                   |
| options.length     | The number of items                                    |
| options.n.value    | UI label of option                                     |
| options.n.name     | ID of option                                           |
| options.n.selected | Sets the nth option as selected by default (v. 7.5SR1) |
| JavaScript         | HTML code                                              |

## Example

```html
JavaScript = onblur="alert('Wow! You changed it!');"
```

## Functions

### setFieldValue(String action, Map values) (v.7.0 SR1)

| Action | Map keys       | Description                              |
|:-------|:---------------|:-----------------------------------------|
| add    | name<br/>value | Adds an option                           |
| remove | value          | Removes all options with the given value |
| clear  |                | Removes all options                      |

### toString()

Converts the selected value to a string.

### toInteger()

Converts the selected value to a number.
