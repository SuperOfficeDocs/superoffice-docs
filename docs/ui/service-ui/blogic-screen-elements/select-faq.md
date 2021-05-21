---
title: Select FAQ
uid: blogic_select_faq
description: Select FAQ
author:
so.date:
keywords:
so.topic: reference
---

# Select FAQ

This element is used to select an entry from the FAQ database.

## Configuration

| Setting     | Description              |
|:------------|:-------------------------|
| accessLevel | The minimum access level |

### Access levels

* 1: private entries
* 2: internal entries
* 3: public authenticated entries (default)
* 4: public not authenticated entries

When you set a specific access level, all FAQ entries on that level and higher will be returned.

## Functions

### getValue()

Returns the ID of the FAQ entry.
