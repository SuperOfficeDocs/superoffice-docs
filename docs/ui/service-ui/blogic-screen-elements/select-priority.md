---
title: blogic_select_priority
description: Select priority
author:
so.date:
keywords:
so.topic: reference
---

# Select priority

This element is used to select ticket priority.

## Configuration

| Setting      | Description                                             |
|:-------------|:--------------------------------------------------------|
| addAutomatic | Adds the *automatic* option                             |
| addNone      | Adds the *none* option                                  |
| addNoValue   | Adds an empty option                                    |
| externalOnly | Whether to display only externally available priorities |
| notEmpty     | Whether an empty choice is OK                           |

## Functions

### setValue(String id)

Sets the priority with the given ID.

### getValue()

Returns the priority with the given ID.
