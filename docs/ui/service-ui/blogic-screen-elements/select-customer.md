---
title: blogic_select_contact
description: Select contact
author:
so.date:
keywords:
so.topic: reference
---

# Select contact

This element adds the **Select contact** field to your screen.

Previously called *Select customer*.

## Configuration

| Setting  | Description                   |
|:---------|:------------------------------|
| notEmpty | Whether an empty choice is OK |

### Selecting a contact

It's possible to define the columns used to select a contact in reg_id=226 (v. 4.9).

**Syntax:**
[displayField:searchField:op:label],[displayField:searchField:op:label],[displayField:searchField:op:label]

## Functions

### setValue(String id)

Sets the selected contact with the given ID.

### toInteger()

Returns the selected contact ID as a number.

### toString()

Returns the selected contact ID as a string.
