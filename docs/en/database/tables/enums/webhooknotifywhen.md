---
uid: enum-webhooknotifywhen
title: Enum values for WebhookNotifyWhen
description: Lists the enum values for WebhookNotifyWhen.
generated: true
keywords: database enum
content_type: reference
envir: onsite, online
---

# WebhookNotifyWhen Enum

When to notify recipients. Bitflag: 1=FirstFailure, 2=Disabling.

| Name | Value | Description |
|------|-------|-------------|
|None|0|0: No notifications|
|FirstFailure|1|1: Notify on first failure|
|Disabling|2|2: Notify when webhook is disabled due to too many errors|

## Usage

* [Webhook](../webhook.md).notify_when - Webhook URL to call when events occur in the client or in NetServer. Also tracks call+error statistics.
