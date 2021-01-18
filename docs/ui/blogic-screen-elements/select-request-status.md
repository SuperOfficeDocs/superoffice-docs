---
title: blogic_select_request_status
description: Select request status
author:
so.date:
keywords:
so.topic: reference
---

# Select request status

This element adds a **drop-down** menu with all statuses. It also adds a calendar field to pick the date and time for postponed requests.

It is available in version 3.1.7.5

## Configuration

| Setting           | Description                                                   |
|:------------------|:--------------------------------------------------------------|
| default           | The ID of the status you want as default                      |
| ticketId          | Whether to use the status of the ticket as the default status |
| valueId           | Whether to use entryId as ticketId                            |
| defaultAddMessage | Whether to use the default status for adding messages for this user<br/>Used in combination with ticketId or valueId. |
| category          | Whether to set the  default status to the one for new ticket for this user for the given category                     |

### Default status

If you set **category**, the default status will be the same as in the standard new ticket screen, when this category is the standard category.

Category applies only if ticketId, valueId, and default are not set!

If you set **defaultAddMessage**, the default status will be the same as in the standard add message screen.

defaultAddMessage applies only if ticketId or valueId is set.

## Functions

### getFieldValue(String field)

| Field    | Description                            |
|:---------|:---------------------------------------|
| activate | Returns the date in the calendar field |
| status   | Returns the ID of the status           |

### setFieldValue(Sting action, Map values)

| Action | Map keys            | Description         |
|:-------|:--------------------|:--------------------|
| set    | activate<br/>status | Sets various values |

1. Set the default status by inserting key = status and value = ID to the map.
2. Set the calendar field by inserting key = activate and value = DateTime to the map.

```crmscript
map.insert("status", "2");
map.insert("activate", "2006-11-24 14:59:26");
setFieldValue("set", map);
```

### toString()

Returns the ID of the status.
