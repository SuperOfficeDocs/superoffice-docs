---
uid: dp-widgets
title: Widgets
description: About the SuperOffice Developer Portal home page and how to manage widgets.
keywords: Developer Portal, widget, home page, new customers, publishing, request to publish, publish status, application failures, onboarding
author: Bergfrid Dias
date: 04.30.2025
version_devportal: 2.2
content_type: concept
deployment: online
platform: web
language: en
---

# Widgets

The new dashboard offers an intuitive, centralized location for at-a-glance information from the Developer Portal. It also provides personalized navigation to pertinent pages.

![Developer Portal Home dashboard -screenshot][img5]

The contents and card-style layout of the dashboard is customizable - each user chooses which widgets to show and how they appear.

Each widget represents distinctive features.

| Widget | Purpose |
|---|---|
| Application Failures | Monitors problems with API calls. |
| Messaging Center | Provides quick information on communication related to requests. |
| New Customers | Provides quick information on new customers signed up to use your standard applications. |
| Onboarding | Aids users getting started. |
| Publish Status | Explore pending requests to publish app configuration, App Store information, and partner profile. |

## Go to dashboard

To access the dashboard, click **Home** in the Top bar.

## Customize dashboard with widgets

Organize your dashboard based on your specific needs and preferences.

![Developer Portal Home dashboard with no widgets -screenshot][img1]

### Add widget

1. Go to **Home**. If the dashboard is empty (as in the previous screenshot), click **Add Widgets**. Otherwise, click **Edit Widgets**.

1. In the **Widgets** dialog, select one or more widgets by clicking **Add Widget**.

    ![Developer Portal add widgets -screenshot][img2]

1. Click **Save changes**.

    ![Developer Portal Onboarding widget added -screenshot][img3]

### Resize or move widget

* To move a widget, click the widget's header and drag it to a new position. It will snap to the grid. Other widgets re-position to accommodate the move.

* To resize a widget, hover over the right or bottom edge. When the pointer becomes a double-pointed arrow, drag the pointer to adjust the width or height of the widget.

### Remove widget

1. On the dashboard, click **Edit Widgets**.

2. Select which widget to remove and then save the changes.

    ![Developer Portal remove widgets -screenshot][img4]

## Available widgets

Below are the details for each widget.

### Application failures

Displays the cumulative errors per application, showcasing the top 10 applications with the highest count of exceptions.

Filter failures by:

[!include[Legend](../includes/list-failure-types.md)]

### Onboarding

The Onboarding widget is a hub of useful links when starting out, such as to the Developer Portal documentation and the YouTube video archive.

### Messaging Center

This widget shows real-time statistics from the [Messaging Center][1]. Click a tile for details.

| Stats | Description |
|---|---|
| New open requests | The number of newly received open requests. |
| Pending/waiting requests | The number of requests that are awaiting action. |
| Message status changes | Notification of any status change in the messaging center. |

### New Customers

All customers within a specified timerange, those who have signed in and given consent to allow your application, will appear in the New Customers widget.

The available timeframes are:

* Last 7 days (default)
* Last month
* Last quarter
* Last six months
* Last year

### Publish status

The Publish status widget displays open requests related to application publishing. These include app configuration, App Store information, and partner profile submissions.

Each card represents an application or partner profile, along with its current publishing status. Use this widget to track what is pending, where it is in the workflow, and if any action is required from you.

Key interactions and indicators:

* <i class="ph ph-shield" aria-label="Security audit pending"></i> / <i class="ph ph-shield-check" aria-label="Security audit ok"></i> Security audit pending or approved.
* <i class="ph ph-seal" aria-label="Certification pending"></i> / <i class="ph ph-seal-check" aria-label="Certification ok"></i> Certification pending or approved.
* Hover over workflow steps to see its current status.
* Click any step with a red dot to view error details or required actions.
* Click the **partner name**/**app name** link to open the partner or app page.
* Click the **oval label** (for example, *v3* or *New redirect URL*) to view the version submitted for publishing.
* Click the **request ID** to open the request in the [Messaging Center][1].

![Publish status widget showing various app configurations and statuses -screenshot][img6]

<!-- Referenced links -->
[1]: ../create-app/message-center.md

<!-- Referenced images -->
[img1]: media/home-empty.png
[img2]: media/add-widget.png
[img3]: media/onboarding-widget.png
[img4]: media/remove-widget.png
[img5]: media/dp-dashboard.png
[img6]: media/publishing-widget.png
