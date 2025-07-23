---
uid: webhook_ticket_event
title: Ticket webhook events
description: Ticket events
keywords: ticket webhook
author: SuperOffice Product and Engineering
date: 11.22.2023
version: 10.2.11
content_type: reference
category: automation
topic: webhook
---

# Ticket webhook events

These webhook events are fired when requests are created or changed:

* `ticket.created`
* `ticket.changed`

> [!NOTE]
> From version 10.2.11 ticket events list changed fields.

## FieldValues for ticket events

The following fields are included in the `FieldValues` property of the webhook payload for ticket events:

* `category` - ID of the category
* `connect_id` - ID of parent ticket
* `contact_id` - ID of the company
* `created_at` - Date of the creation
* `cust_id` - ID of the customer. NULL or -1 if ticket is not connected to customer.
* `has_attachment` - ticket has attachment flag
* `last_changed` - date of the last change
* `owned_by` - ID of the owner
* `priority` - priority of the ticket
* `project_id` - ID of the project
* `sale_id` - ID of the sale
* `slevel` - security level of the ticket
* `status` - status level of the ticket
* `ticket_status` - status of the ticket
* `ticket_type` - type of the ticket

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
  "WebhookName": "Name you provided",
  "FieldValues": {
    "category": 2,
    "connect_id": -1,
    "contact_id": 2,
    "created_at": "2025-05-16T14:25:37",
    "cust_id": 5,
    "has_attachment": 1,
    "last_changed": "2025-05-19T10:51:32",
    "owned_by": 8,
    "priority": 2,
    "project_id": 0,
    "sale_id": 0,
    "slevel": 1,
    "status": 1,
    "ticket_status": 1,
    "ticket_type": 1
  }
}
```

## Ticket.Changed

```json
{
  "EventId": "32a093ac-418a-40f1-a14a-f4193ea92b59",
  "Timestamp": "2025-05-19T09:56:33.1554128Z",
  "Changes": [
    "id",
    "read_by_owner"
  ],
  "Event": "ticket.changed",
  "PrimaryKey": 76,
  "Entity": "ticket",
  "ContextIdentifier": "Cust31038",
  "ChangedByAssociateId": 19,
  "WebhookName": "My Ticket Webhook",
  "FieldValues": {
    "category": 2,
    "connect_id": -1,
    "contact_id": 2,
    "created_at": "2025-05-16T14:25:37",
    "cust_id": 5,
    "has_attachment": 1,
    "last_changed": "2025-05-19T10:51:32",
    "owned_by": 8,
    "priority": 2,
    "project_id": 0,
    "sale_id": 0,
    "slevel": 1,
    "status": 1,
    "ticket_status": 1,
    "ticket_type": 1
  }
}

```
