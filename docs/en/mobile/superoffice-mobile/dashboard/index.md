---
uid: mobile-crm-dashboard
title: Dashboard
description: Learn about working with dashboards in SuperOffice Mobile CRM.
keywords: mobile, dashboard, tile, chart, drill down
date: 06.10.2025
version: 11.1
content_type: concept
platform: mobile
language: en
redirect_from: /en/mobile/superoffice-mobile/dashboard/drill-down
---

# Dashboard <i class="ph ph-gauge" aria-hidden="true"></i>

From the **dashboard** screen, you can view dashboards created in SuperOffice CRM.

![Mobile CRM: dashboard with multiple tiles -app-screen][img1]

> [!NOTE]
> Dashboards are read-only in Mobile CRM. To create, update, or delete a dashboard, use SuperOffice CRM on desktop. There is no action bar in the dashboard screen.

## Tabs

| Tab | Description |
|---|---|
| Search | Search field and history list. |
| Favorites | Dashboards marked as a favorite (yellow star). |
| Pinned | Dashboards pinned for you. |

## View dashboards

1. Go to the **dashboard** screen.
2. Search for a dashboard by name, or select one from the history list, favorites, or pinned dashboards.
3. Scroll through the tiles to view the content.

## <a id="drill-down"></a>Drill down

You can drill down from dashboard tiles to explore the data behind a chart, number, or list—just like in the web client.

### View data

1. Tap a tile to explore the data:

    * **Chart:** Tap once to select a segment, then tap again to open the details. These tiles visualize data.
    * **Big number:** Tap the number to view related records. These tiles show aggregate metrics or KPIs.
    * **List:** Tap a list item to open it. These tiles represent defined selections.

### Supported entities

You can drill down into the following entities:

* Appointment
* Company
* Contact
* Document
* Project
* Request
* Sale

**Not supported in Mobile CRM:**

* Product
* Quote lines
* Mailings
* Form submissions
* Chat conversations

## Related content

* [Introduction to dashboards][4]
* [Chart types][1]
* [Create dashboard (in SuperOffice CRM)][3]
* [Edit dashboard tiles (in SuperOffice CRM)][2]

<!-- Referenced links -->
[1]: ../../../dashboard/learn/index.md#charts
[2]: ../../../dashboard/learn/working-with-tiles.md
[3]: ../../../dashboard/learn/create.md
[4]: ../../../dashboard/learn/index.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/mobile/dashboard.png
