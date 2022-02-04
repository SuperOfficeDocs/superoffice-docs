---
title: Message grid
uid: blogic_message_grid
description: Message grid
author:
so.date:
keywords:
so.topic: reference
---

# Message grid

This element will display ticket messages in a grid including a checkbox.

This element can be useful in screens such as **forward ticket** where we want to select messages in a ticket.

> [!NOTE]
> If you don't set a ticket ID, the entryId is used.

## Configuration

| Setting  | Description                                            |
|:---------|:-------------------------------------------------------|
| label    | UI label                                               |
| ticketId | Whether to add the messages on this ticket to the grid |

## Functions

### toString()

Returns the selected message IDs in a comma-separated string.
