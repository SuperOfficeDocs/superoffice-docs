---
uid: screen-grid
title: Working with grids
description: How to add and populate tables in a layout using the Screen Designer in Settings and maintenance.
author: Bergfrid Dias
so.date: 05.05.2023
keywords: ui, screen, customization, grid, table
so.topic: howto
so.version: 10
---

# Working with grids

[!include[Requirement](../../../../../common/includes/req-dev-tools.md)]

If you have many fields, you can use a grid element to position them with more finesse. This is an alternative to positioning based on sort order and columns.

The instructions below assume you're already [editing the layout][1].

## Add a grid

1. Select the tab you want to add a grid to.
1. Click to select the **Elements** section.
1. Click and drag the **Grid** element to the layout.

    ![Screen Designer grid element -screenshot][img1]

1. Click to select the new table.
1. In the **Settings** sections to the left, adjust the number of columns and rows to suit your needs.

    ![Screen Designer grid settings -screenshot][img2]

1. Choose a grid style: lines (default), none, or header.

## Add field to grid

1. Go to the location of the grid.
1. Hold the pointer over the grid and click the blue pencil.

    ![Screen Designer grid enter edit mode -screenshot][img3]

    This places the grid in edit mode, indicated by a green checkmark.

    ![Screen Designer grid in edit mode -screenshot][img4]

1. Make sure the **Fields** section is selected.
1. [Drag fields from the list][2] to a cell in the grid. You can also add [labels][3], [links, and buttons][4].

    > [!TIP]
    > Tab from cell to cell for efficient input.

1. When you are done, click the green checkmark to lock the grid and resume normal edit mode.

## Edit grid contents

1. Place the grid in edit mode as described above.

1. To move a field, click **=** to the left of the field and drag it to a new cell.

    If you drop a field into an occupied cell, the contents of the two cells are swapped.

1. To remove a field, hold the pointer over the cell and click the red circled x.

## Edit grid appearance

1. Select the tab containing the grid.
1. Click the grid in the preview. Make sure the grid itself isn't in edit mode. Click the green checkmark if you see it.
1. In the **Settings** section, adjust the grid's dimensions and style.

> [!NOTE]
> You can't remove specific rows or columns, however, you can reduce the number of rows and columns. When you decrease the number of rows, the **last row** disappears from the user interface along with its contents. When you decrease the number of column, the **last column** disappears. Rearrange your fields first to avoid surprises.

## Move grid

To move a grid, click **=** to the left of the grid and drag the field to a new position. This is similar to moving fields.

## Remove grid

When you remove a grid, its contents (fields and so on) is removed too.

This action affects only what is shown in the user interface, and doesn't change the database or table values in any way.

To remove a grid:

* Hold the pointer over the grid and click the red circled x.

To restore a grid:

* If you are working on a draft, simply discard the draft to undo all your changes.
* If you have published the layout after removal, you need to recreate the table.

<!-- Referenced links -->
[1]: edit-card-layout.md
[2]: working-with-fields.md
[3]: working-with-tabs.md#add-heading-or-divider
[4]: add-button.md

<!-- Referenced images -->
[img1]: media/new-grid.png
[img2]: media/grid-settings.png
[img3]: media/hover-grid.png
[img4]: media/edit-grid.png
