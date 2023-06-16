---
uid: enum-webhookstate
title: Enum values for WebhookState
description: Lists the enum values for WebhookState.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# WebhookState Enum

Webhook status - should we post events to the URL? 1=Active, 2=Stopped or 3=TooManyErrors

| Name | Value | Description |
|------|-------|-------------|
|Unknown|0|0: Unknown state|
|Active|1|1: Active - webhook is posting events to receiver|
|Stopped|2|2: Stopped - webhook has been turned off. Not posting events to receiver.|
|TooManyErrors|3|3: Too many errors received - webhook has been turned off automatically.|

## Usage

* [Webhook](../webhook.md).state - Webhook URL to call when events occur in the client or in NetServer. Also tracks call+error statistics.
