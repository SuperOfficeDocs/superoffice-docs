---
title: Select contacts
uid: blogic_select_contacts
description: Select contacts
author:
so.date:
keywords:
so.topic: reference
---

# Select contacts

A variant of [select contact][1] that lets you select more than 1 contact person.

Previously called *Select customer*.

## Configuration

No settings.

## Functions

### getFieldValue(String field)

| Field | Description                      |
|:------|:---------------------------------|
| all   | Returns a list of all recipients |

### setFieldValue(String action, Map values)

| Action      | Map keys | Description                          |
|:----------- |:---------|:-------------------------------------|
| addCustomer | id       | Adds 1 contact with the specified ID |

### toString()

Returns a comma-separated list of the IDs of the customers.

<!-- Referenced links -->
[1]: select-customers.md
