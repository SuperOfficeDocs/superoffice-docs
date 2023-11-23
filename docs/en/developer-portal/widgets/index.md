---
title: Widgets
uid: dp-widgets
description: About the SuperOffice Developer Portal home page and how to manage widgets.
author: Bergfrid Dias
so.date: 11.15.2023
keywords: Developer Portal, widget, home page
so.topic: concept
so.dp-version: 1.16
so.lang: en
so.envir: cloud
so.client: online
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
| Onboarding | Aids users getting started. |

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

<!-- Referenced links -->
[1]: ../create-app/message-center.md

<!-- Referenced images -->
[img1]: media/home-empty.png
[img2]: media/add-widget.png
[img3]: media/onboarding-widget.png
[img4]: media/remove-widget.png
[img5]: media/dp-dashboard.png
