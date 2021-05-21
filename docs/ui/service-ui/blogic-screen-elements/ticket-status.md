---
title: Ticket status
uid: blogic_ticket_status
description: Ticket status
author:
so.date:
keywords:
so.topic: reference
---

# Ticket status

This element shows the ticket status field.

**Statuses:**

* active
* closed
* postponed

A calendar element is also shown next to status *postponed*.

## Configuration

| Value      | Description                              |
|:-----------|:-----------------------------------------|
| deleted    | Whether to include status deleted (Bool) |

## Functions

### getFieldValue(String field)

| Field    | Description         |
|:---------|:--------------------|
| activate | The activation date |
| status   | The status          |

### setValue()

### setFieldValue("set", Map)

| Value      | Description                                |
|:-----------|:-------------------------------------------|
| status     | Choose status                              |
| activate   | Sets activation date for postponed tickets |
