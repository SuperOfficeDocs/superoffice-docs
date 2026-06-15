---
uid: webhook-overview
title: Webhooks
description: SuperOffice webhooks push event notifications to external systems in real time. Admins can manage them from Settings and maintenance; developers can register them via the REST API or CRMScript.
keywords: automation, webhook, integration, event, notification
author: digitaldiina
date: 06.15.2026
version: 12.1
content_type: concept
tier: core
index: true
language: en
---

# Webhooks

SuperOffice webhooks let your systems react to events as they happen. Instead of polling for changes, your application or integration receives a notification automatically when a contact is created, a sale is updated, a ticket is closed, or any other supported event occurs.

A webhook delivers a payload to a target URL. The payload contains the event name, the affected entity, and a list of changed fields — everything a subscriber needs to take action without a follow-up request to SuperOffice.

Webhooks are available to both administrators managing integrations in SuperOffice and developers building custom applications on the SuperOffice platform.

## Administrators

Administrators can create and manage webhook subscriptions directly in SuperOffice, without writing code.

* [Manage webhooks in Settings and maintenance][1]

## Developers

Developers can register webhooks via the REST API or CRMScript, configure shared secrets for payload verification, and route events to CRMScript handlers instead of external URLs.

* [Webhooks developer guide][2]

<!-- Referenced links -->
[1]: admin/index.md
[2]: dev/index.md
