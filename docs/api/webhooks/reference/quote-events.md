---
# Mandatory fields.
title: webhook_quote_event
description: Quote events
author:
so.date:
keywords: automation
so.topic: reference         # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Quote webhook events

These webhook events are fired when quotes are changed:

* `quote.approved`
* `quote.rejected`
* `quote.sent` - when quote version has been sent
* `quote.ordered` - when quote order has been placed

## Quote.Approved

```json
POST /webhook HTTP/1.1
Content-Type: application/json; charset=utf-8
User-Agent: NetServer-Webhook/8.8.6684.1719
X-Superoffice-Event: quote.approved
X-Superoffice-Eventid: 1fc5752a-6de8-412d-847a-12d5529a0ec6
X-Superoffice-Signature: X1FmmRIXuzH8o0MDanva1lnuNZXoix6M0US1S64s+e8=

{
  "EventId": "1fc5752a-6de8-412d-847a-12d5529a0ec6",
  "Timestamp": "2018-04-24T08:13:02.8352175Z",
  "Changes": [  ],
  "Event": "quote.approved",
  "PrimaryKey": 527331,
  "Entity": "quote",
  "ContextIdentifier": "Default",
  "ChangedByAssociateId": 37201,
  "WebhookName": "Name you provided"
}
```

## Quote.Rejected

```json
{
  "EventId": "1fc5752a-6de8-412d-847a-12d5529a0ec6",
  "Timestamp": "2018-04-24T08:13:02.8352175Z",
  "Changes": [  ],
  "Event": "quote.rejected",
  "PrimaryKey": 527331,
  "Entity": "quote",
  "ContextIdentifier": "Default",
  "ChangedByAssociateId": 37201,
  "WebhookName": "Name you provided"
}
```

## Quote.Sent

```json
{
  "EventId": "1fc5752a-6de8-412d-847a-12d5529a0ec6",
  "Timestamp": "2018-04-24T08:13:02.8352175Z",
  "Changes": [  ],
  "Event": "quote.sent",
  "PrimaryKey": 527331,
  "Entity": "quote",
  "ContextIdentifier": "Default",
  "ChangedByAssociateId": 37201,
  "WebhookName": "Name you provided"
}
```

## Quote.Ordered

```json
{
  "EventId": "1fc5752a-6de8-412d-847a-12d5529a0ec6",
  "Timestamp": "2018-04-24T08:13:02.8352175Z",
  "Changes": [  ],
  "Event": "quote.ordered",
  "PrimaryKey": 527331,
  "Entity": "quote",
  "ContextIdentifier": "Default",
  "ChangedByAssociateId": 37201,
  "WebhookName": "Name you provided"
}
```
