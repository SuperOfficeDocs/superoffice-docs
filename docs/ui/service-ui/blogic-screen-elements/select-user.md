---
title: blogic_select_user
description: Select User
author:
so.date:
keywords:
so.topic: reference
---

# Select User

This element is used to select a user in the system.

## Configuration

The settings specify which users and options to add to the drop-down menu.

| Setting         | Description                                         |
|:----------------|:----------------------------------------------------|
| AddNone         | Adds the value *None*                               |
| RemoveNone      | Removes the blank value (None)                      |
| AddNoValue      | Adds an empty entry (other/unset)                   |
| AddNotDelegated | Adds the value *Not delegated*                      |
| AddDelegate     | Adds the value *Automatically assigned* (v. 3.0.11) |
| AddAll          | Adds the value *All users*                          |
| AddActiveUser   | Adds the value *Active user*                        |
| AddNotPresent   | Whether to include users with status = not present  |
| AddReadOnly     | Whether to include users with status = read-only    |
| AddDeleted      | Whether to include deleted users                    |

## Functions

### setValue(String id)

Sets the user from the supplied ID.

### toString()

Returns the ID of the selected user as a string.

### toInteger()

Returns the ID of the selected user as a number.
