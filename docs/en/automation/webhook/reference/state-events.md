---
title: Error events
uid: webhook_error_event
description: Error webhook events
author: AnthonyYates
date: 06.24.2023
keywords: automation, webhook
topic: reference
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
  "WebhookName": "Name you provided"
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
  "WebhookName": "Name you provided"
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
  "WebhookName": "Name you provided"
}
```
