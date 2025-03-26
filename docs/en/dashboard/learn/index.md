---
uid: help-en-dashboard
title: Dashboards
description: SuperOffice Dashboard are ideal for users and managers alike. Get an overview of your individual work or your team's performance with pre-defined tiles or create your own.
keywords: dashboard administrator, chart, report, dataset, big number, gauge, dashboard, tile
author: Bergfrid Dias, Kirsti Aakerholt
date: 03.25.2025
version: 10.5.3
topic: concept
audience: person
audience_tooltip: SuperOffice CRM
language: en
---

# Dashboards

Dashboards in SuperOffice CRM give you instant visual insight into your work, your team's progress, and key company metrics. They display key numbers and trends using tiles linked to selections or other data sources.

Use dashboards to track activities, sales, requests, and more. You can view pre-defined dashboards or create your own.

![Request dashboard -screenshot][img4]

> [!NOTE]
> Your access to dashboards and tile data depends on your user plan and assigned rights.

## What is a dashboard?

A dashboard is a customizable view of your CRM data. It displays one or more tiles—mini visual reports that show summaries, counts, or charts based on your data. Dashboards help you stay informed and make decisions faster.

Each tile contains a graphical or numerical representation of SuperOffice data. It is the data behind the tiles that makes a dashboard useful.

### Terminology

* **Dashboard:** A screen that displays CRM data visually using one or more tiles.
* **Tile:** A configurable panel in a dashboard. Tiles can show charts, lists, or numbers.
* **Chart:** A graphical representation of tile data, such as a pie chart or bar chart.
* **Dataset:** The underlying data source for a tile. Usually based on a dynamic selection.

## Access your dashboards

Select **Dashboard** in the navigator to open the dashboard screen. You can access:

* **Pinned dashboards:** Distributed to you by an administrator
* **Favorite dashboards:** Marked with a star icon
* **Own dashboards:** Dashboards you created yourself

By default, a dashboard called **Status** is available and pinned. It contains tiles with pre-defined charts and key numbers. If you have the SuperOffice Service user plan, a second dashboard called **Requests** is also available.

You can create additional dashboards or duplicate existing ones to customize them.

Pinned and favorite dashboards are displayed across the top of the screen, along with the most recently used dashboard. Use the search field in the navigator to find other dashboards available to you.

| Icon | Description |
|---|---|
| <i class="ph ph-push-pin" aria-label="Pin icon"></i> | Pinned dashboard. |
| <i class="ph ph-star" aria-label="Star icon"></i> | Favorite dashboard. Click to toggle. |
| <i class="ph ph-arrow-clockwise" aria-label="Refresh icon"></i> | Refresh all tile data. |
| <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i> | Task menu for dashboard actions. |

## Tiles

Tiles are the building blocks of a dashboard. Tile data typically relates to you, or your groups, and to a specific period (such as this month, last 6 months).

A tile can show:

* A **chart**, such as a bar or pie chart. Charts are graphical visualizations of data, sometimes called a graph.
* A **list** of up to 100 records from a selection
* A **big number**, such as total sales. Highlights a key performance indicator (KPI).
* A **web panel** that loads a URL
* **HTML content**, formatted directly in the tile

You can add pre-defined tiles or create your own.

## <a id="charts"></a>Chart types

The chart type determines how data is displayed inside the tile.

| Icon | Type | Description |
|:-:|---|---|
| <i class="ph ph-chart-pie" aria-label="Pie chart"></i> | Pie chart | A circular-shaped graph. |
| <i class="ph ph-number-square-three" aria-label="Big numbers"></i> | Big number | A number in big letters with options to compare to value or period. |
| <i class="ph ph-list-bullets" aria-label="List icon"></i> | List | A list overview with max 100 items. |
| <i class="ph ph-chart-bar" aria-label="Column chart"></i> | Column chart | A column chart plots the variable value vertically. |
| <i class="ph ph-chart-bar-horizontal" aria-label="Bar chart"></i> | Bar chart | A bar chart plots the variable value horizontally. |
| <i class="ph ph-chart-line-up" aria-label="Line chart"></i> | Line chart | A series of data points with a continuous line. |
| <i class="ph ph-chart-line-up ph-fill" aria-label="Line chart"></i> | Area chart | A graph that combines a line chart and a bar chart. |
| <i class="ph ph-gauge" aria-label="Gauge chart icon"></i> | Gauge chart | Also known as dial charts or speedometer charts, use needles to show information as a reading on a dial. |
| <i class="ph ph-chart-bar" aria-label="Column chart"></i> | Column + line (2 axes) | A dual axis chart that combines a column and line chart. |
| <i class="ph ph-chart-bar-horizontal" aria-label="Bar chart"></i> | Bar + line (2 axes) | A dual axis chart that combines a bar and line chart. |

## View and interact with tiles

Each tile shows a snapshot of real-time data from its source. You can interact with tiles to explore the underlying data.

* **Hover** over chart areas to view tooltips with more detail.
* **Click a value in the chart legend** to show or hide data series. This is useful when printing or exporting tiles.
* To **expand a tile**, click <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i> and select **View in full screen**.

    ![Tile Task menu -screenshot][img1]

* **Drill down into data** by clicking a data point (for example, a bar or pie segment). A new window opens with the related records.

In the drill-down view:

* Select a record to preview it.
* Double-click a record to open it, or select a record and click **Open**.
* Click <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i> and select **Copy into selection** to copy one or more records for follow-up. If no records are selected, the entire result set is copied.

![Drill down to underlying data -screenshot][img2]

## Requirements

Dashboard features depend on your assigned functional rights and license level. All users can:

* View dashboards pinned or shared with them
* Create, customize, and delete their own dashboards

> [!NOTE]
> Tiles display only data you have access to.

If you cannot edit or pin a dashboard, contact your administrator to check your functional rights.

### Functional rights

Functional rights are assigned to user roles in Settings and maintenance. These rights control who can share and manage dashboards.

* **Dashboard administrator:**
  * Pin dashboards to users or groups
* **General administrator:**
  * Update dashboards created by others
  * Cannot delete dashboards they do not own

Only the **owner** of a dashboard can delete it.

### License-specific dashboard features

| License | Dashboards included | Tile types |
|---|---|---|
| All CRM plans | Status dashboard with standard tiles | Charts, lists, big numbers |
| **Service** | Requests dashboard | Request-related tiles |
| **Marketing** (Essentials or higher) | – | Mailing, form submissions, chats |
| **Sales Premium** | – | Product-level forecasts, KPIs, sales targets, quotes |
| **Sales or Service Premium** | – | Activity monitors (SAINT) |

## Tips

* Use **favorites** <i class="ph ph-star" aria-label="Star icon"></i> to quickly access your most-used dashboards.

## Related content

* [Create a new dashboard or duplicate an existing one][1]
* [Edit a dashboard][3]
* [Add tiles / Edit layout][6]

<!-- Referenced links -->
[1]: create.md
[3]: update.md
[6]: working-with-tiles.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/dashboard/tile-task-menu.png
[img2]: ../../../media/loc/en/dashboard/10-drill-down.gif
[img4]: ../../../media/loc/en/dashboard/dashboard-overview.png
