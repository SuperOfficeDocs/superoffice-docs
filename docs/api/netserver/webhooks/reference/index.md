---
title: Reference
uid: webhook_reference
uid: webhooks_ref
description: SuperOffice Webhooks reference
author:
so.date: 04.06.2018
keywords: automation
---

# Reference

This section describes the events and how they appear when events are dispatched to your
webhook receiver.

## Delete events

Since the item has been deleted, the delete event contains the id values from the deleted object as part of the webhook payload.

```json
{
  "Timestamp": "2018-04-24T07:50:50.6812131Z",
  "Values": {
    "sale_id": 994863,
    "contact_id": 43,
    "person_id": 64,
    "project_id": 178105
  },
  "Event": "sale.deleted",
  "PrimaryKey": 994863,
  "Entity": "sale",
  "ContextIdentifier": "Cust1234",
  "ChangedByAssociateId": 316,
  "WebhookName":"Name you provided"
}
```

<!-- See also: @Reference-WebAPI-REST-Webhook-Webhook -->
