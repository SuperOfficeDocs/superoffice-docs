---
title: blogic_messages
description: Messages
author:
so.date:
keywords:
so.topic: reference
---

# Messages

This element will display the messages for a ticket.

## Configuration

| Setting         | Description                                      |
|:----------------|:-------------------------------------------------|
| ticketId        | The ticket to list messages from                 |
| limit           | The max number of messages to show (v. 4.0)      |
| showChange      | Whether to display changed lines (Bool) (v. 4.0) |
| blockQuickReply |                                                  |
| where           | additional criteria (v. 3.1.5)                   |

> [!NOTE]
> The element must have a ticket ID to show messages for. If you don't set a ticket ID, the entryId CGI variable is used. If that variable is empty, **no messages will be shown**.

### Deprecated from v. 4.2

* descending
* previewImages
* showForward

## Example

```crmscript
fields.0.field = message.id
fields.length = 1
where.0.critPriority = 0
where.0.field = message.id
where.0.operator = OperatorLte
where.0.rowOperator = OperatorAnd
where.0.value = 60
where.length = 1
```
