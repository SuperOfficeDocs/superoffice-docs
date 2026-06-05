---
uid: enum-webhooknotifyvia
title: Enum values for WebhookNotifyVia
description: Lists the enum values for WebhookNotifyVia.
generated: true
keywords: database enum
content_type: reference
envir: onsite, online
---

# WebhookNotifyVia Enum

How to notify recipients when this webhook changes state. 1=Email, 2=InApp.

| Name | Value | Description |
|------|-------|-------------|
|None|0|0: No notification channels|
|Email|1|1: Send e-mail notification|
|InApp|2|2: Send in-app notification|

## Usage

* [Webhook](../webhook.md).notify_via - Webhook URL to call when events occur in the client or in NetServer. Also tracks call+error statistics.
