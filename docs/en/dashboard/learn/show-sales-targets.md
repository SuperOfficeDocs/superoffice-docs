---
uid: help-en-dashboard-tile-sales-targets
title: Using sales targets in tiles
description: Use dashboards and tiles to compare your sales targets to your actual sales.
author: SuperOffice RnD
date: 12.13.2022
keywords: dashboard, sale, target, chart
topic: howto
language: en
---

# Using targets in tiles

If [sales targets][4] are defined for your company, teams/groups and/or sales people, you can add these targets to your dashboard tiles. You will then get a visual presentation of your actual sales and your targets.

To be able to visualize your targets in a dashboard, you first need to add or edit the tiles in the dashboard. After you have chosen the correct tile, you can edit the tiles' layout and chart type.

![Choose the Layout tab and select Compare to target in the Grouping section -screenshot][img7]

## Add tile with sales targets to dashboard

1. Open the **Dashboard** screen.

2. Select the dashboard you want to edit.

3. Click the **Task** button, and select **Add tile / Edit layout**. On the right side of the selected dashboard, the **Add tile / Edit layout** section is displayed.

4. In the **Show tiles for** list, select **Sale**.

5. In the **Library** tab, select one of the following charts:

    * <i class="ph ph-number-square-three" aria-hidden="true"></i> - Big number
    * <i class="ph ph-chart-bar" aria-hidden="true"></i> - Bar chart
    * <i class="ph ph-chart-bar" aria-hidden="true"></i> - Column chart
    * <i class="ph ph-gauge" aria-hidden="true"></i> - Gauge chart
    * Empty sale tile

    > [!TIP]
    > You can also [select an empty tile][1] to create a tile from scratch, but the chart type must be one of those listed above.

6. To add a tile to the dashboard, drag and drop it on the desired position on the dashboard. You can also click **Add** to add a tile to next available position. The tile will automatically adjust to the available space, and will align with the grid and columns setup.

7. Adjust the tiles on the dashboard:

    * Hold the mouse-pointer over a tile and click and drag the frame to adjust the tile size. Available slots/spaces in the dashboard are highlighted in yellow when the tile can fit in that position.

    * Click the header of a tile and drag it to another position.

8. In the dashboard, click the **Edit tile** icon (<i class="ph ph-note-pencil" aria-hidden="true"></i>) on the new tile.

9. In the **Dataset** tab, set **Sale date** to this year, quarter or month. Edit the other [criteria][2] as necessary. Remember to update the tile name to reflect any changes made here.

10. In the **Layout** tab, edit the layout:

    * **Chart type**: Change this to any chart type listed in step 5.
    * **Measure**: Select **Sum** or **Count**. For example, the sum of all sales or the total number (count) of all sales.
    * **Of**: If you selected **Count** above, select **Sale ID** in this list. If you selected **Sum**, select **Amount** or **Weighted amount**.
    * **By**: Select **Sale > Owner** (owner, full name or group) or **Sale > Sale date**. This option is relevant for bar charts and column charts only.
    * **Grouping** or **Footer**: Select **Compare to target**.
      * If this option is not visible or is inactive, double-check that you have completed the steps above. If you cannot select the option **Compare to target** (it is disabled), you can hover your mouse-pointer over the text. This will display a tooltip that explains what you need to change in order to enable and select the option.
    * **Target**: Select the target you want to add to the tile. (Not relevant for bar charts.)
    * **Show as %**: Select this option to show percentage of target instead of sums or counts. (Not relevant for column charts and big numbers.)

11. Edit the formatting. Based on the chart type you selected, you have additional options under **Formatting**:

    * Big number: You can edit the colors used to display targets.
    * Gauge chart: Use the option **Mark target at** to set the target on the gauge chart.

12. Click **A-Z** to [add a translation][3] to the tile name, titles and labels.

13. Click **Save**. Then click **Done**.

## Why can't I select Compare to target?

If you see the field Compare to target, but it is disabled, you can hover your mouse over the field to see a tooltip that explains what you need to change to enable and select the field.

![Hover over the Compare to target field to see a tooltip -screenshot][img8]

Is the Compare to target not visible at all, make sure that you have selected the correct chart type and you have used the Sales date as criteria in the Dataset tab.

## Related

* [Add new dashboard][5]
* [Edit or create tiles][2]
* [Set up sales targets][7]
* [Dashboard data][6]

<!-- Referenced links -->
[1]: edit-tile.md
[2]: ../../search-options/learn/search-criteria.md
[3]: ../../globalization-and-localization/learn/translate-fields.md
[4]: ../../sale/learn/sales-targets/index.md
[5]: create.md
[6]: working-with-tiles.md
[7]: ../../sale/learn/sales-targets/create.md

<!-- Referenced images -->
[img7]: ../../../media/loc/en/dashboard/user-dashboard-tile-comparetotarget.png
[img8]: ../../../media/loc/en/dashboard/user-dashboard-tile-disabled-comparetotarget.png
