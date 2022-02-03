---
title: Ticket webhook events
uid: webhook_ticket_event
description: Ticket events
author:
so.date:
keywords: automation
so.topic: reference
# so.envir:
# so.client:
---

# Ticket webhook events

These webhook events are fired when requests are created or changed:

* `ticket.created`
* `ticket.changed`

Ticket events do not list changed fields.

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
  "Changes": [  ],
  "Event": "ticket.changed",
  "PrimaryKey": 527331,
  "Entity": "ticket",
  "ContextIdentifier": "Default",
  "ChangedByAssociateId": 37201,
  "WebhookName": "Name you provided"
}
```
