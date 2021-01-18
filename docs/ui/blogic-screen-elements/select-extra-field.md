---
title: blogic_select_extra_field
description: Select extra field
author:
so.date:
keywords:
so.topic: reference
---

# Select extra field

This element is used to get input for an [extra field](@crmscript_extra_fields). The specifics of this element depend on the extra field's **type**.

## Configuration

| Setting  | Description                                                                      |
|:---------|:---------------------------------------------------------------------------------|
| id       | The ID of the extra field                                                        |
| field    | The name of the extra field, incl. table name.<br/>For example, ticket.x_myfield |
| notEmpty | Whether an empty choice is OK (required vs. optional)                            |

### Ticket relations

For ticket relations, it is possible to define the columns used to select a ticket in reg_id=228 (v. 4.9).

**Syntax:**
[displayField:searchField:op:label],[displayField:searchField:op:label],[displayField:searchField:op:label]

## Functions

Depending on the type of the field, the `setValue()` and `getValue()` methods will return the selected value.

For example, a date, the ID in a drop-down menu, or a text value.

### getValue()

### setValue(String value)

The flags of the extra field (such as **cannot be empty**) are used to specify the behavior of the field.
