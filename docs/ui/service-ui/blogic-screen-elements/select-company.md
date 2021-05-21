---
title: Select company
uid: blogic_select_company
description: Select company
author:
so.date:
keywords:
so.topic: reference
---

# Select company

This element adds the **Select company** field to your screen.

## Configuration

| Setting        | Description                          |
|:---------------|:-------------------------------------|
| notEmpty       | Whether an empty choice is OK        |
| controlVersion | The version of this element (1 or 2) |

### Selecting company

It's possible to define the columns used to select a company in reg_id=227 (v. 4.9).

**Syntax:**
[displayField:searchField:op:label],[displayField:searchField:op:label],[displayField:searchField:op:label]

## Functions

### setValue(String id)

Sets the selected company with the given ID.

### toInteger()

Returns the selected company ID as a number.

### toString()

Returns the selected company ID as a string.
