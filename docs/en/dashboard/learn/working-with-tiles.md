---
uid: help-en-dashboard-tiles
title: Working with tiles
description: Learn how to add, customize, and manage tiles in your SuperOffice dashboards.
keywords: add tile, edit tile, copy tile, duplicate tile, remove tile, customize tile, dataset, dashboard, tile
author: digitaldiina
date: 11.21.2025
version: 11.6
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: en
redirect_from:
  - /en/dashboard/learn/add-tile
  - /en/dashboard/learn/edit-tile
  - /en/dashboard/learn/remove-tile
---

# Working with tiles

Learn how to add, customize, and manage tiles in your SuperOffice dashboards. Tiles are visual summaries based on CRM data—ideal for tracking requests, sales, activities, or marketing results.

You can use pre-defined tiles or create your own.

## Prerequisite: switch to layout mode

To manage tiles, you must first enter layout mode:

1. Open the dashboard you wish to customize.

1. In the dashboard header, click <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i> and select **Edit dashboard tiles**.

    The dashboard enters layout mode:
    * The **Edit dashboard tiles** sidebar opens on the right.
    * Each tile shows an edit icon (<i class="ph ph-pencil" aria-hidden="true"></i>).
    * You can add, move, resize, or edit tiles.

## <a id="add"></a>Add tile

1. In the **Edit dashboard tiles** sidebar, choose the type of data (such as company, sale, or request) from the **Show tiles for** list.

    ![Edit dashboard tiles sidebar -screenshot][img1]

1. Choose a tile from either the **Library** (pre-defined tiles) or **Selections** (tiles based on your own dynamic selections).

    * Use the **search field** to quickly locate tiles.
    * Each tile has an icon indicating its type—such as chart, list, or big number.

1. Add the tile to the dashboard:
    * **Drag and drop** the tile into an available slot.
    * Or, click the <i class="ph ph-plus" aria-label="+"></i> icon that appears when hovering the tile name.

    The tile will automatically adjust to the available space and align with the dashboard layout.

1. Resize or reposition tiles as needed.

1. Click **Done** to exit layout mode.

### Create a tile from scratch

1. Select the **Empty tile** option for the type of data you want to visualize.
1. Add it to the dashboard.
1. In the **Edit tile** dialog, enter a descriptive name.
1. Select the **Dataset** tab and [define the criteria][4] to control what data the tile will display.

    ![Edit tile dialog, Dataset tab -screenshot][img2]

    This tab works like [the Find screen][5]. Use it to define filters such as owner, date range, or category.

1. Go to the **Layout** tab to configure the tile's appearance. Choose [chart type][3], labels, sorting, and other formatting options.

    ![Edit tile dialog, Layout tab -screenshot][img3]

1. Click **Save**, then click **Done** to exit layout mode.

### <a id="selection-chart"></a>About selection-based tiles

When you add a tile from the **Selections** tab, you are not linking the tile to a live selection. Instead, you are copying the current dataset and layout from the [chart defined in the selection][6]. After that point, the tile and the selection are independent.

The **Selections** tab only shows:

* Dynamic selections
* Selections matching the type chosen in **Show tiles for**
* Selections with a saved chart on the **Chart** tab

If a selection is missing from the list, check:

* Is it a static selection? Static selections are not supported here.
* Does the record type (company, sale, and so on) match the selected type?
* Has a chart been defined and saved on the **Chart** tab?

After you add the tile:

* Changes to the **criteria** or **chart** in the selection do **not** affect the tile.
* Changes to the **dataset** or **layout** in the tile do **not** affect the selection.
* The **tile does not stay in sync** with the selection, but it still updates dynamically based on its own dataset.

If you want the tile to reflect updates from a selection, either adjust the tile manually or delete and re-add it from the updated selection.

### Add a web panel tile

Use this tile to embed a webpage inside the dashboard:

1. Set **Show tiles for** to **Other**.
1. In the **Library** tab, select **Web panel**.
1. Enter the URL you want to display.
1. If the URL uses HTTP (not HTTPS), enable **Allow insecure address**.
1. Click **Save**, then click **Done** to exit layout mode.

### Add an HTML tile

Use this tile to display formatted text in your dashboard. For example, a welcome message, legend, or internal explanation.

1. Set **Show tiles for** to **Other**.
1. In the **Library** tab, select **HTML**.
1. Click **Add** to select at least one language for the content.
1. Use the built-in editor to enter and format your content.

    You can use the same formatting options available in Chat and Forms. Add content in multiple languages to ensure the tile displays correctly for all users.

1. Click **Save**, then click **Done** to exit layout mode.

## <a id="edit"></a>Edit a tile

1. While in layout mode, click the **Edit** icon (<i class="ph ph-pencil" aria-hidden="true"></i>) on the tile.
1. In the **Dataset** tab, adjust the filters as needed.
1. In the **Layout** tab, select the chart type and visual settings.
1. Update the tile name to match the updated data or layout.
1. Click <i class="ph ph-translate" aria-label="Translate"></i> to [add a translation][7] to the tile title and labels.
1. Click **Save**.

## <a id="copy"></a>Duplicate or copy a tile

You can reuse an existing tile by either duplicating it in the same dashboard or copying it to another dashboard. You must have **edit access to the target dashboard** to copy a tile to it.

1. Click <i class="ph ph-dots-three-vertical" aria-label="Task menu"></i> on the tile and select the duplicate or copy option.

| Option | What it does | What to do next | Use case |
|---|---|---|---|
| **Duplicate tile** | Creates a copy of the tile in the current dashboard. The name is updated (for example, *Tile name 2*). | Typically, you edit the duplicated tile: change the name, update the dataset or layout. | Show the same type of data with a different layout, or show similar data using the same layout. |
| **Copy tile to dashboard** | Adds the tile to another dashboard. Choose a target dashboard from the list. Hover over a dashboard name to preview its current tiles before copying. | Optionally open the target dashboard. Edit the tile there if needed. | Reuse a useful tile you found in a coworker's dashboard. Add it to one of your own dashboards. |

**Copy to dashboard** is also available outside layout mode (normal dashboard view).

## <a id="move"></a>Rearrange or resize tiles

While in layout mode:

* **Drag a tile by its header** to move it to a new position.
* **Resize a tile** by dragging its bottom or right edge, or the lower-right corner.

Tiles automatically snap to the dashboard's grid layout.

To change the number of columns, exit layout mode and update the dashboard details.

## <a id="remove"></a>Remove a tile

You can remove tiles from a dashboard, as long as you have editing access.

1. While in layout mode, click <i class="ph ph-dots-three-vertical" aria-label="Tile task menu"></i> on the tile.
1. Select **Remove tile**.
1. Confirm the deletion.

> [!CAUTION]
> Custom tiles, such as HTML, web panel, and selection-based tiles, are permanently deleted when removed. Only pre-defined tiles from the Library can be safely re-added later.

## <a id="export"></a>Export tiles

### Download or print the tile report

Click <i class="ph ph-dots-three-vertical" aria-label="Task menu"></i> in the header of a tile to access the following options:

* **Download PDF document** / **Download PNG document**: Download the tile in PDF or PNG format. The export files are downloaded to your browser (**Downloads** folder).

    For other formats (**SVG, CSV, and XLS**), choose **View in full screen** from the menu.

* **Print**: Open the tile in the print dialog.

> [!TIP]
> To hide specific data before exporting or printing a tile, click the data labels (legend) next to or under the tile to hide data.

### Export ALL rows in a dataset to Excel

1. Click a data point in the tile to drill down into the data.

    A new window opens with the related records.

1. Click <i class="ph ph-download-simple" aria-label="Download"></i> **Export** below the list.

1. Click **Yes** to confirm.

    This operation may take a while. You can continue working in SuperOffice while waiting. You will be notified when the export is complete.

## Tips

* **Hide currency labels:** To save space on tiles that show amounts, set **Currency** to **Hide** in the Layout tab.

* **Compare to target:** For sales dashboards, enable **Compare to target** in the Layout tab to visualize progress toward sales goals. This option depends on the chart type and dataset setup.

* **Use short numbers for better readability:** For tiles with large values, enable **Short number** format to display values in millions (for example, *1.2M*).

* **Big number tiles:** Use these for key metrics, like revenue or open requests. Keep the tile name short so the number stands out clearly.

* **Show duration on follow-up tiles:** When using follow-up tiles, set **Measure** to **Duration** to track time spent more effectively.

## Troubleshooting

* **I do not see the edit icon on the tile**
  * Is the dashboard in layout mode?

* **I do not find the option I am looking for in the Task menu**
  * Did you click the correct Task button? (dashboard vs. tile)
  * Is the dashboard in layout mode?

* **I cannot access the layout tab or fields**
  * You may not have the required functional rights. Contact your administrator.

* **A selection is missing from the Selections tab**
  * See [About selection-based tiles](#selection-chart)

* **I accidentally removed a custom tile**
  * These tiles cannot be restored. To avoid this, copy them to a private dashboard (for example, "Archived tiles") before deletion.

## Related content

* [Add a new dashboard][1]
* [Use dashboards to manage your sales pipeline][2]

<!-- Referenced links -->
[1]: create.md
[2]: show-sales-targets.md
[3]: index.md#charts
[4]: ../../search-options/learn/search-criteria.md
[5]: ../../search-options/learn/find-screen.md
[6]: ../../search-options/selection/learn/howto/display-as-charts.md
[7]: ../../localization/learn/translate-fields.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/dashboard/edit-dashboard-tiles-sidebar.png
[img2]: ../../../media/loc/en/dashboard/edit-tile-dataset.png
[img3]: ../../../media/loc/en/dashboard/edit-tile-layout.png
