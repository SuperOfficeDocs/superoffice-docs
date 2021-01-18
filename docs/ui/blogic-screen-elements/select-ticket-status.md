---
title: blogic_select_ticket_status
description: Select ticket status
author:
so.date:
keywords:
so.topic: reference
---

# Select ticket status

This element adds **radio buttons** with all statuses. It also adds a calendar field to pick the date and time for postponed requests.

## Configuration

| Setting           | Description                              |
|:------------------|:-----------------------------------------|
| default           | The default status to be selected        |
| valueId           | Whether to use entry ID as ticket ID     |
| ticketId          | The ticket ID to get status from         |
| filterIds         |                                          |
| addDeleted        | Adds the *deleted* status to the listing |
| defaultAddMessage | Whether the default status for adding messages for this user is used |
| category          | Whether to set the  default status to the one for new ticket for this user for the given category |

## Functions

### getFieldValue(String field)

| Field    | Description         |
|:---------|:--------------------|
| activate | The activation date |
| status   | The status          |

### setValue(String value)

### setFieldValue(String action, Map values)

| Action | Map keys            | Description         |
|:-------|:--------------------|:--------------------|
| set    | activate<br/>status | Sets various values |

### toString()

### toInteger()

### toDate()
