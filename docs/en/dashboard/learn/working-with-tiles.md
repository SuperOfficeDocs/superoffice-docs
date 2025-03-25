---
uid: help-en-dashboard-tiles
title: Working with tiles
description: In this how-to guide, you will learn how to create a dashboard tile.
keywords: dashboard, tile
date: 03.25.2025
version: 10.5.3
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: en
---

# Working with tiles / edit layout in dashboard

If you do not find the tile you need among the set of pre-defined tiles in SuperOffice Dashboard, you can always create your own tile.

## Add tile

If you do not find the tile you need among the set of pre-defined tiles in SuperOffice Dashboard, you can always create your own.

Watch this video or follow the steps below to learn how to create your own dashboard tile (video length – 7:20):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/zoAuq0IK_6k]

### Steps

1. Open the **Dashboard** screen.

2. Select the dashboard you want to edit.

3. Click the **Task** button (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>) and select **Add tile / Edit layout**. On the right side of the selected dashboard, the **Add tile / Edit layout** section is displayed.

    ![Select tile type -screenshot][img1]

    > [!NOTE]
    > If the **Layout** tab and the fields are disabled, this means you do not have sufficient user rights. Please contact your administrator to get the right access.

4. In the **Show tiles for** list, select the type of records you want to use, for instance companies, follow-ups or sales. Relevant tiles are displayed in the **Library** and **Selections** tabs below:

    * **Library**: This tab contains a set of pre-defined tiles from the online template library. The icon next to the tile name indicates the tile type.

        > [!TIP]
        > You can also select an empty tile to create a tile from scratch.

    * **Selections**: This tab contains dynamic selections with [charts][2], and will only show selections of the same record/entity type selected in the **View** list above (for example, company or sale).

    > [!NOTE]
    > When using a selection chart, the dataset is copied, and any changes to the selection will not be reflected in the tile.

5. Optional: Use the search field to find specific tiles.

6. To add a tile to the dashboard, drag and drop it on the desired position on the dashboard. You can also click **Add** to add a tile to next available position. The tile will automatically adjust to the available space, and will align with the grid and columns setup.

7. Repeat steps 4-6 to add more tiles.

8. Adjust the tiles on the dashboard:

    * Hold the mouse-pointer over a tile and click and drag the frame to adjust the tile size. Available slots/spaces in the dashboard are highlighted in yellow when the tile can fit in that position.

    * Click the header of a tile and drag it to another position.

9. Click **Done**.

### The dataset tab

The tab for Dataset will show the criteria overview like you are used to in Find and Selection. The different criteria you select here will filter the wanted data for your tile.

You have various edit options for your dashboard tiles, including the Source of the data

### The layout tab

The tab for Layout gives you a lot of possibilities to fine-tune the visual look of the tile. If you are happy with the layout of a tile, you can also duplicate the tile to change the dataset behind without changing the layout.

Choose the wanted chart type and the settings needed. The output of the tile is shown on the right side

## Edit a tile

1. Go to the required dashboard.

2. Click <i class="ph ph-dots-three-circle-vertical" aria-label="Task button"></i> and select **Add tile / Edit layout**.

3. In the dashboard, click the **Edit tile** icon (<i class="ph ph-note-pencil" aria-hidden="true"></i>).

4. In the **Dataset** tab, you can [edit the criteria][11] for the data displayed in the tile. Remember to update the tile name to reflect any changes made here.

5. In the **Layout** tab, you can edit various settings, values and formatting of the tile. The preview on the right will update with the selected settings.

6. Click <i class="ph ph-translate" aria-label="Translate"></i> to [add a translation][12] to the tile name, titles and labels.

7. Click **Save**.

## Remove a tile

You can remove tiles from a dashboard, as long as you have editing access to it.

> [!NOTE]
> Removed tiles are still available to add to dashboards.

**Steps:**

1. Go to the required dashboard.

2. Click <i class="ph ph-dots-three-circle-vertical" aria-label="Task button"></i> and select **Add tile / Edit layout**.

3. In the dashboard, click the **Remove tile** icon (<i class="ph ph-x-circle" aria-hidden="true"></i>) on the tile you want to remove.

4. Click **OK** to confirm.

## Export tiles

Click <i class="ph ph-list" aria-label="Task menu"></i> in the header of a tile to access the following options:

* **Download PDF document** / **Download PNG document**: Download the tile in PDF or PNG format. The export files are downloaded to your browser (**Downloads** folder).

* **Print**: Open the tile in the print dialog.

> [!TIP]
> To hide specific data before exporting or printing a tile, click the data labels (legend) next to or under the tile to hide data.

## Related content

* [Add a new dashboard][1]
* [Use dashboards to manage your sales pipeline][15]
* [Read more about criteria][4]
* [The Find screen][5]

<!-- Referenced links -->
[1]: create.md
[2]: ../../search-options/selection/learn/howto/display-as-charts.md
[11]: ../../search-options/learn/search-criteria.md
[12]: ../../globalization-and-localization/learn/translate-fields.md
[15]: show-sales-targets.md
[4]: ../../search-options/learn/search-criteria.md
[5]: ../../search-options/learn/find-screen.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/dashboard/dashboard-add-tile-sale.png
