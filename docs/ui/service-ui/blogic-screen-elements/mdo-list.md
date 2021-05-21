---
title: MDO list
uid: blogic_mdolist
description: MDO list
author:
so.date:
keywords:
so.topic: reference
---

# MDO list

This element creates a drop-down menu for any of the available MDO lists in SuperOffice CRM.

## Configuration

| Setting | Description                                |
|:--------|:-------------------------------------------|
| label   | UI label of the list                       |
| list    | The MDO list to get drop-down options from |

## Example

```crmscript
label = Project type
list = projecttype
```

## Functions

### toString()

Converts the selected value to a string.

### toInteger()

Converts the selected value to a number.
