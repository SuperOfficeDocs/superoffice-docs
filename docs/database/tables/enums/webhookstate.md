---
uid: enum-webhookstate
title: Enum values for WebhookState
description: Lists the enum values for WebhookState.
so.generated: true
keywords:
  - "database"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# WebhookState Enum

Webhook status - should we post events to the URL? 1=Active, 2=Stopped or 3=TooManyErrors

* Unknown = 0
* Active = 1
* Stopped = 2
* TooManyErrors = 3

## Usage

* [Webhook](../webhook.md).state - Webhook URL to call when events occur in the client or in NetServer. Also tracks call+error statistics.
