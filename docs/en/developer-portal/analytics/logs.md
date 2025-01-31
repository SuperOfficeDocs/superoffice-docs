---
uid: dp-event-log
title: Logs - Track changes to partners and applications
description: How to check who-did-what-when per partner or application in the SuperOffice Developer Portal.
keywords: event log, audit log, log
author: Bergfrid Dias
date: 01.30.2025
version: 1.30
version_devportal: 1.30
topic: howto
envir: cloud
client: online
---

# Logs - Track changes to partners and applications

The event log allows partners and app developers to track changes related to their applications and partner settings. This provides a clear audit trail of key events, ensuring transparency and accountability.

![The Logs page for a partner in the SuperOffice Developer portal -screenshot][img1]

## Accessing the logs

You can access logs from two locations:

* From your partner page: Displays logs for all applications by that partner.
* From a specific application page: Automatically filters the log to show only entries related to that specific application.

To populate the list with log records, you must click the **Apply** button after selecting any filters.

## Filters and search options

You can refine logs using the following filters:

* Source: The type of the logged event (such as, request to publish, ownership update ).
* User: Filter actions performed by a specific user.
* Duration: Select a predefined or custom date range (such as, last 30 minutes, 24 hours).
* Sort By: Order logs by latest, oldest, or other criteria.

Use **Clear All** to reset filters before applying a new query.

## Log entries

Each log entry contains:

| Column | Description |
|---|---|
| Timestamp | When - the exact date and time of the event. |
| User | Who - the person who performed the action. |
| Description | What happened - a brief summary of the change. |
| Source | The event (hidden if the list is filtered on event type). |

> [!TIP]
> Click on a row to observe the details of the log entry.

### Viewing log details

To see more details about a specific log entry:

1. Click on an entry in the list.

1. A **Log Details** panel will appear, displaying:

    * Changed by
    * Timestamp
    * Message
    * Event type
    * Partner/App
    * Version (if applicable)

1. Events that modify fields include old vs. new values. Click **Read more** to inspect each field.

1. Click **X** in the upper-right corner to close the panel.

![The Logs page with details panel -screenshot][img2]

## Events (source)

<!-- markdownlint-disable-file MD051 -->
### [Application](#tab/app)

* Created application
* Deleted application

* Updated application settings
* Changed application's 'developed by'
* Changed application ownership
* Changed application's technical contact

* Created application configuration
* Updated application configuration
* Requested to publish application configuration
* Published application configuration
* Rejected publishing application configuration

* Created application profile
* Updated application profile
* Requested to publish application profile
* Published application profile
* Rejected publishing application profile

* Reported application failure

### [Partner](#tab/partner)

* Updated partner settings
* Changed partner's administrative contact
* Changed partner's technical contact

* Created partner profile
* Updated partner profile
* Requested to publish partner profile
* Published partner profile
* Rejected publishing partner profile

* Assigned user to partner
* Removed user from partner
* Updated partner user permission

### [App Store](#tab/store)

* App Store uninstall application
* Problem report from App Store

***

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: media/logs-partner.png
[img2]: media/log-details.png
