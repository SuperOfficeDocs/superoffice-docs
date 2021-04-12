---
# Mandatory fields.
title: webhook_activity_event
description: Activity events
author:
so.date:
keywords: automation
so.topic: reference         # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Test event

This event is fired when the webhook is being registered. It is used to test that the webhook receiver is working.

* `test`

## Example

```json
POST /webhook HTTP/1.1
Content-Type: application/json; charset=utf-8
User-Agent: NetServer-Webhook/8.8.6684.1719
X-Superoffice-Event: test
X-Hook-Test: true
X-Superoffice-Signature: 8hH7Lu8JU8F4g3bYFfhseZWJ/g4GzN2zdfSxxhDVQLM=
X-Superoffice-Eventid: f0a473ae-6194-4701-8fd1-49caf355067a

{
  "EventId": "4b5ce038-50f2-4796-bdb2-f96908cf31c2",
  "Timestamp": "2018-04-24T08:52:59.0005158Z",
  "Changes": [],
  "Event": "test",
  "PrimaryKey": 0,
  "Entity": "test",
  "ContextIdentifier": "Default",
  "ChangedByAssociateId": 316,
  "WebhookName": "Name you provided"
}
```

> [!NOTE]
> You need to make sure you ignore the event in your webhook receiver, just **return 200 OK**.
