---
uid: webhook_error_event
title: Error events
description: Error webhook events
keywords: webhook, state change
author: AnthonyYates
date: 06.24.2023
content_type: reference
category: automation
topic: webhook
---

# Webhook State change events

In order to subscribe to webhook state change events, you must first create a webhook to get the `WebhookId`, then use that id in the webhook subscription `Event` property.

These events are fired when a webhook `State` property changes.

* `webhook{webhookId}.started` - when state is set to `Active`
* `webhook{webhookId}.stopped` - when state is set to `Stopped`
* `webhook{webhookId}.errors`  - when state is set to `TooManyErrors`

When webhook 123 is activated, signal **webhook123.started**

When webhook 123 is disabled, signal **webhook123.stopped**

When webhook 123 is disabled by errors, signal **webhook123.errors**

## FieldValues for webhook events

The following fields are included in the `FieldValues` property of the webhook payload for webhook events:

* `events` - number of events sent to the webhook
* `registered` - date of the webhook registration
* `registered_associate_id` - ID of the associate who registered the webhook
* `state` - state of the webhook (0 = Active, 1 = Stopped, 2 = TooManyErrors)
* `updated` - date of the last update
* `updated_associate_id` - ID of the associate who last updated the webhook

## webhook{webhookId}.started

```json
POST /webhook HTTP/1.1
Content-Type: application/json; charset=utf-8
User-Agent: NetServer-Webhook/{version}
X-SuperOffice-Event: webhook{webhookId}.started
X-SuperOffice-EventId: 1848cc1f-d395-49ba-9b35-04a9269996d4

{
  "EventId": "1848cc1f-d395-49ba-9b35-04a9269996d4",
  "Timestamp": "2018-07-05T11:58:18.5809908Z",
  "Changes": [],
  "Event": "webhook.started",
  "PrimaryKey": 66,
  "ContextIdentifier": "Cust12345",
  "ChangedByAssociateId": 0,
  "WebhookName": "Name you provided",
  "FieldValues": {
    "events": 1,
    "registered": "2025-05-14T16:11:02.4593434+02:00",
    "registered_associate_id": 5,
    "state": 2,
    "updated": "0001-01-01T00:00:00",
    "updated_associate_id": 0
  }
}
```

## webhook{webhookId}.stopped

```json
POST /webhook HTTP/1.1
Content-Type: application/json; charset=utf-8
User-Agent: NetServer-Webhook/{version}
X-SuperOffice-Event: webhook{webhookId}.stopped
X-SuperOffice-EventId: 1848cc1f-d395-49ba-9b35-04a9269996d4

{
  "EventId": "1848cc1f-d395-49ba-9b35-04a9269996d4",
  "Timestamp": "2018-07-05T11:58:18.5809908Z",
  "Changes": [],
  "Event": "webhook.stopped",
  "PrimaryKey": 66,
  "ContextIdentifier": "Cust12345",
  "ChangedByAssociateId": 0,
  "WebhookName": "Name you provided",
  "FieldValues": {
    "events": 1,
    "registered": "2025-05-14T16:11:02.4593434+02:00",
    "registered_associate_id": 5,
    "state": 2,
    "updated": "0001-01-01T00:00:00",
    "updated_associate_id": 0
  }
}
```

## webhook{webhookId}.errors

Whenever the hook gets disabled due to multiple errors or permanent failure (HTTP STATUS 410 GONE).

```json
POST /webhook HTTP/1.1
Content-Type: application/json; charset=utf-8
User-Agent: NetServer-Webhook/{version}
X-SuperOffice-Event: webhook{webhookId}.errors
X-SuperOffice-EventId: 1848cc1f-d395-49ba-9b35-04a9269996d4

{
  "EventId": "1848cc1f-d395-49ba-9b35-04a9269996d4",
  "Timestamp": "2018-07-05T11:58:18.5809908Z",
  "Changes": [],
  "Event": "webhook.errors",
  "PrimaryKey": 66,
  "ContextIdentifier": "Cust12345",
  "ChangedByAssociateId": 0,
  "WebhookName": "Name you provided",
  "FieldValues": {
    "events": 1,
    "registered": "2025-05-14T16:11:02.4593434+02:00",
    "registered_associate_id": 5,
    "state": 2,
    "updated": "0001-01-01T00:00:00",
    "updated_associate_id": 0
  }
}
```
