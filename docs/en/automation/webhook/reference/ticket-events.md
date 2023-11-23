---
title: Ticket webhook events
uid: webhook_ticket_event
description: Ticket events
author:
so.date: 11.22.2023
so.version: 10.2.11
keywords: automation
so.topic: reference
# so.envir:
# so.client:
---

# Ticket webhook events

These webhook events are fired when requests are created or changed:

* `ticket.created`
* `ticket.changed`

> [!NOTE]
> From version 10.2.11 ticket events list changed fields.

## Ticket.Created

```json
POST /webhook HTTP/1.1
Content-Type: application/json; charset=utf-8
User-Agent: NetServer-Webhook/8.8.6684.1719
X-Superoffice-Event: ticket.created
X-Superoffice-Eventid: 1fc5752a-6de8-412d-847a-12d5529a0ec6
X-Superoffice-Signature: X1FmmRIXuzH8o0MDanva1lnuNZXoix6M0US1S64s+e8=

{
  "EventId": "1fc5752a-6de8-412d-847a-12d5529a0ec6",
  "Timestamp": "2018-04-24T08:13:02.8352175Z",
  "Changes": [  ],
  "Event": "ticket.created",
  "PrimaryKey": 527331,
  "Entity": "ticket",
  "ContextIdentifier": "Default",
  "ChangedByAssociateId": 37201,
  "WebhookName": "Name you provided"
}
```

## Ticket.Changed

```json
{
  "EventId": "1fc5752a-6de8-412d-847a-12d5529a0ec6",
  "Timestamp": "2018-04-24T08:13:02.8352175Z",
  "Changes": [ 
    "created_at",
    "title",
    "last_changed",
    "read_by_owner",
    "read_by_customer",
    "closed_at",
    "time_to_close",
    "real_time_to_close",
    "time_to_reply",
    "real_time_to_reply",
    "author",
    "created_by",
    "alert_level",
    "alert_timeout",
    "connect_id",
    "filter_id",
    "read_status",
    "has_attachment",
    "num_replies",
    "num_messages",
    "display_filter",
    "alert_stop",
    "replied_at",
    "slevel",
    "category",
    "priority",
    "cust_id",
    "status",
    "ticket_status",
    "deadline",
    "first_read_by_user",
    "first_read_by_owner",
    "activate",
    "owned_by",
    "agent_id",
    "dbi_key",
    "dbi_last_syncronized",
    "extraField",
    "filter_address",
    "time_spent_internally",
    "time_spent_externally",
    "time_spent_queue",
    "real_time_spent_internally",
    "real_time_spent_externally",
    "real_time_spent_queue",
    "tags",
    "ticket_type"
   ],
  "Event": "ticket.changed",
  "PrimaryKey": 527331,
  "Entity": "ticket",
  "ContextIdentifier": "Default",
  "ChangedByAssociateId": 37201,
  "WebhookName": "Name you provided"
}
```
