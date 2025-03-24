---
uid: help-en-dashboard
title: Dashboards
description: SuperOffice Dashboard are ideal for users and managers alike. Get an overview of your individual work or your team's performance with pre-defined tiles or create your own.
author: Kirsti Aakerholt
date: 07.05.2023
keywords: dashboard, tile, chart, report, dataset, layout, dashboard tabs, big numbers, gauge
topic: concept
language: en
---

# Dashboard

The **Dashboard** feature in SuperOffice CRM gives you quick access to the charts, reports and statistics that are most important to you. You can choose from a wide range of pre-defined tiles, and also add tiles from dynamic selections or create your own.

Dashboards are displayed as tabs at the top of the screen. Pinned dashboards and dashboards set as favorite are displayed here, in addition to the most recently used dashboard. To view other dashboards that you have access to, search in the navigator.

![Custom dashboard -screenshot][img4]

> [!NOTE]
> Some of the functions described here, require specific functional rights or licences.

## Terminology

* **Dashboard:** A dashboard is a way of displaying various types of visual data in one place. Usually, a dashboard is intended to convey different, but related information in an easy-to-digest form.

* **Report:** a list or selection shown in a tile

* **Tiles:** Adjustable squares that can visualize different data in your dashboard.

  * **Charts type:** A chart is a graphical representation for data visualization (sometimes known as graphs).
  * **List:** A list showing a defined selection.
  * **Big numbers:** Lets you emphasize an important aggregate metric or KPI (key performance indicator).
  * **Web panel:**  Display an url/web page inside a tile.
  * **HTML code:** Display HTML code inside a tile.

* **Dataset:** Selection of data showing in the tile, like a dynamic selection with search criteria.

* **Layout:** Change the settings to adjust how the data is displayed in a tile.

* **Dashboard tab:** Each tab contains a dashboard displaying different tiles with different data that can provide insight and serve as a decision-making guide.

## Tiles

In SuperOffice Dashboard you have many of [pre-defined standard tiles][6] to choose from, and charts that are linked to dynamic selections. The tiles fall into eight different categories: Company, Contact, Follow-up, Sale, Project, Document, Product, and Request.

Each tile in a dashboard contains either a chart, a list, or a number. A dashboard can contain multiple tiles.

The tiles can also be customized to show only data from selections. Access rights and confidentiality apply to the tile data, so tiles will display only information you have access to. Tile data typically relates to you, or your groups, and to a specific period (such as this month, last 6 month)

### <a id="charts"></a>Chart types

| Icon | Type | Description |
|:-:|---|---|
| <i class="ph ph-chart-pie" aria-label="Pie chart"></i> | Pie chart | A circular-shaped graph. |
| <i class="ph ph-number-square-three" aria-label="Big numbers"></i> | Big number | A number in big letters with options to compare to value or period. |
| <i class="ph ph-list-bullets" aria-label="List icon"></i> | List | A list overview with max 100 items. |
| <i class="ph ph-chart-bar" aria-label="Bar chart"></i> | Column chart | A column chart plots the variable value vertically. |
| <i class="ph ph-chart-bar" aria-label="Bar chart"></i> | Bar chart | A bar chart plots the variable value horizontally. |
| <i class="ph ph-chart-line-up" aria-label="Line chart"></i> | Line chart | A series of data points with a continuous line. |
| ![icon][img12] | Area chart | A graph that combines a line chart and a bar chart. |
| <i class="ph ph-gauge" aria-label="Gauge chart icon"></i> | Gauge chart | Also known as dial charts or speedometer charts, use needles to show information as a reading on a dial. |
| ![icon][img14] | Column + line (2 axes) | A dual axis chart that combines a column and line chart. |
| ![icon][img15] | Bar + line (2 axes) | A dual axis chart that combines a bar and line chart. |

## Create additional tabs

By default, only one dashboard tab, called Status, is set up. It contains different tiles with pre-defined charts. You can edit this tab and/or add extra dashboard tabs, where you can present all the tiles and charts of your choice.

> [!NOTE]
> Access rights and confidentiality apply to the tile data, so tiles will only display information you have access to.

## Options in the Dashboard screen

| Icon | Description |
|---|---|
| <i class="ph ph-push-pin" aria-label="Pin"></i> | The dashboard is pinned by an administrator and is likely distributed to multiple users. |
| <i class="ph ph-star" aria-label="Star icon"></i> | Click the star in the top-right corner to set a dashboard as favorite. |
| <i class="ph ph-arrow-clockwise" aria-label="Refresh"></i> | Click the **Refresh** button to update the data in all tiles. |
| <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i> | Click the **Task** button to access various functions. |

**Functions on the Task button:**

* [Create a new dashboard or duplicate an existing one][1]
* [Edit a dashboard][3]
* [Add tiles / Edit layout][4]
* Delete a dashboard
* [Targets][7]
* Help (F1)

A dashboard can consist of any number of tiles. Each tile contains a graphical or numerical representation of SuperOffice data.

It is the data that lies behind the tiles that makes a dashboard useful. Learn how to access the information in your dashboard, so that you can get a clear overview and prioritize your next steps better.

## View tiles and data

* Click on data in a tile (for instance a sector in a pie chart) to display the underlying data.

* Place the mouse-pointer over a section of a tile to view source data in a pop-up box.

* Click the data labels (legend) under the tile to hide/show specific data in the tiles. This can be useful for printing or exporting the tiles.

* Click <i class="ph ph-list" aria-label="Task menu"></i> in the header of a tile and select **View in full screen** to open the tile in full screen. Useful for tiles with much content.

### Examine underlying data

Follow the steps in this GIF or the steps below to see how you can access the data behind the tiles:

![Reveal the data behind your graph with dashboard drill down -screenshot][img2]

1. Open the **Dashboard** screen.

2. Select the relevant dashboard.

3. Click on data in a tile (for instance a column in a column chart). A new window displays the records in the section you clicked.

4. Here you have the following options:

    * Select a record to preview it.

    * Double-click a record to open it (or select a record and click **Open**).

    * To [copy the records to a selection][8], click <i class="ph ph-dots-three-circle-vertical" aria-label="Task button"></i> and select **Copy into selection**. If you do not select any records, all records are copied.

5. Click **Close** when you are done.

<!-- Referenced links -->
[1]: create.md
[3]: update.md
[4]: add-tile.md
[6]: working-with-tiles.md
[7]: ../../sale/learn/sales-targets/index.md
[8]: ../../search-options/selection/learn/add-remove-members-static.md

<!-- Referenced images -->
[img4]: ../../../media/loc/en/dashboard/dashboard-overview.png
[img12]: ../../../../common/icons/area.png
[img14]: ../../../../common/icons/combined.png
[img15]: ../../../../common/icons/combined-bar.png
[img2]: ../../../media/loc/en/dashboard/10-drill-down.gif
