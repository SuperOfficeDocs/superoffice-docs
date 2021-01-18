---
title: blogic_static_grid
description: Static Grid
author:
so.date:
keywords:
so.topic: reference
---

# Static Grid

This element lets you create a static grid (table) where the contents is manually added and not directly fetched from the database.

## Configuration

The following settings are all boolean.

| Setting             | Description                                              |
|:--------------------|:---------------------------------------------------------|
| hideWhenEmpty       | Whether to hide the grid if it has no rows               |
| persistent          | Whether to preserve grid contents between requests       |
| showTicketStatus    | Whether to show the ticket status (generic grids only)   |
| sortByArrows        | Whether to use headers with arrows for sorting           |
| hideFooter          | Whether to print the footer                              |
| setFocusOnLoad      | Whether to set focus to the grid when the page is loaded |

### Headers

Config for column headers.

| Setting                  | Description                                                            |
|:-------------------------|:-----------------------------------------------------------------------|
| headers.length           | The number of columns or headers in the grid                           |
| headers.i.selectRow      | If true, then this column will contain a checkbox that will specify which row is selected |
| headers.i.arrows         | If true, then this column will contain arrows for sorting the elements |
| headers.i.hidden         | If true, then this column will not be displayed                        |
| headers.i.left           | If true, the contents of this column will be left-justified            |
| headers.i.center         | If true, the contents of this column will be centered                  |
| headers.i.right          | If true, the contents of this column will be right-justified           |
| headers.i.orderByInteger | If true, the grid will sort by the numerical values in this column     |
| headers.i.noSorting      | If true, this column will not be selectable for sorting                |
| headers.i.textBox        | If true, this column will contain an editable text field               |
| headers.i.dropDown       | If true, this column will contain a drop-down menu                     |
| headers.i.checkBox       | If true, then this column will contain a checkbox                      |
| headers.i.delete         | If true, this column will contain an icon that will remove the row when clicked |
| headers.i.containsHtml   | If true, the contents of this column will be parsed as straight HTML   |
| headers.i.dragDrop       | If true, this column can drag rows up and down with the mouse          |
| headers.i.icon           | If true, this column will be shown as an icon                          |
| headers.i.label          | The label of this column                                               |
| headers.i.chop           |                                                                        |

## Functions

### getFieldValue(string)

| Value                      | Description                    |
|:---------------------------|:-------------------------------|
| numRows                    | The number of rows in the grid |
| pageSize                   | The size of a page             |
| flags                      | The flags for the grid         |
| maxHeight                  | The maximum height             |
| width                      | The width of the grid          |
| allRowsCount               | Whether to count all rows      |
| header.n.label             | The label for header n         |
| header.n.flags             | The flags for header n         |
| header.n.chop              | The max amount of characters shown for cells in column n |
| row.n.id                   | The IF for row n               |
| row.n.url                  | The url for the row            |
| row.n.flags                | The flags for the row          |
| row.n.selected             | Whether the row is selected    |
| row.n.numCells             | The number of cells in the row |
| row.n.cell.m.label         | The label of cell m in row n   |
| row.n.cell.m.m_sortString  | The sort string                |
| row.n.cell.m.m_sortInteger | The sort number                |
| row.n.cell.m.m_flags       | The flags                      |

> [!TIP]
> You can also use `rowid.n.<field>` where n is the ID of the row instead of its number.

### setFieldValue(String action, Map values)

| Action               | Map keys             | Description                                    |
|:---------------------|:---------------------|:-----------------------------------------------|
| addHeader            | label<br>flags<br>chop<br>width | Adds a header                   |
| addRow               | id<br>url<br>target<br>flags<br>color<br>toolTip<br>selected | Adds a row |
| addRowUnique         | same as addRow       | Adds a row with a unique ID                    |
| addCell              | label<br>sort<br>url<br>target<br>flags<br>toolTip | Adds a cell |
| deleteSelectedRows   |                      | Deletes the selected rows                      |
| clearSelectedRows    |                      | Removes selected mark on the selected rows     |
| deleteRows           |                      | Deletes all rows                               |
| set                  | pageSize<br>flags<br>maxHeight<br>width<br>allRowsCount<br>selectedRows | Sets various fields |
| defaultOrder         | column<br>direction | Sets the column that by default orders the rows<br>"asc" or "desc" |
| setDropDownOptions.n |                      | Sets the drop-down options for column n        |
| addCommand           | title<br>url<br>returnUrl<br>idString<br>menuIndex<br>commandIndex | Adds a menu command with parameters (v. 4.5) |
| addCommandMenu       | label<br>title<br>iconUrl<br>idString<br>/url(v. 7.1) | Adds a menu (for commands) with parameters (v. 4.5)  |
| deleteCommand        | idString            | Deletes commands (v. 4.5)                       |
| deleteCommandMenu    | idString            | Deletes menus (v. 4.5)                          |
| addGroup             | column<br>order    | Adds groups (v. 8.4R07)<br>descending or ascending (default) |

menuIndex and commandIndex are optional zero-based indexes for placement.

If you add a URL to addCommandMenu (v. 7.1), it will create an instant menu (a button that navigates directly, instead of opening up a context menu).

## The flags

**To get the decimal value: use 2^shift value.**

For example, to get | HeaderFlag_Right: 2^3 = 8

### Table flags

| Position (1\<\<n)   | Flag                     | Description                  |
|:-------------------:|:-------------------------|:-----------------------------|
| 0                   | Flag_HideWhenEmpty       |                              |
| 1                   | Flag_Persistent          | Only used by HtmlStaticGrid  |
| 2                   | Flag_ShowTicketStatus    | Only used by HtmlGenericGrid |
| 3                   | Flag_SortByArrows        | Sort grid by arrows          |
| 4                   | Flag_HideFooter          | Hide footer                  |
| 5                   | Flag_NoVerticalScrollbar | Ignore height parameter and make the grid in full height |
| 6                   | Flag_ShowFooterFunctions | Show footer aggregate functions at the bottom of the grid |
| 7                   | Flag_SelectRow           | Select a row with the mouse  |
| 8                   | Flag_LinksForSuperOffice | Used for SuperOffice-screen with grids, row links will open in new window without framework |
| 9                   | Flag_OuterBorder         | Show a border around         |
| 10                  | Flag_NoExportMenu        | Do not show the export menu  |

### Header flags

| Position (1\<\<n)   | Flag                     | Description                  |
|:-------------------:|:-------------------------|:-----------------------------|
| 0                   | HeaderFlag_Hidden        | Hide column                  |
| 1                   | HeaderFlag_Left          | Left align header            |
| 2                   | HeaderFlag_Center        | Center align header          |
| 3                   | HeaderFlag_Right         | Right align header           |
| 4                   | HeaderFlag_OrderByInteger | Order by integer value instead of string value cell.m_sort |
| 5                   | HeaderFlag_NoSorting     | Disable sorting by clicking on header |
| 6                   | HeaderFlag_SelectRow     | This is an checkbox column   |
| 7                   | HeaderFlag_TextBox       | This is a textbox column     |
| 8                   | HeaderFlag_DropDown      | This is a drop-down column   |
| 9                   | HeaderFlag_Arrows        | This is an arrows column     |
| 10                  | HeaderFlag_CheckBox      | This is an checkbox column   |
| 11                  | HeaderFlag_ContainsHtml  | Do not encode text           |
| 12                  | HeaderFlag_Delete        | Delete icon                  |
| 13                  | HeaderFlag_DragDrop      | Drag and drop this cell      |
| 14                  | HeaderFlag_Icon          | Custom icon                  |

### Row flags

| Position (1\<\<n)   | Flag                   |
|:-------------------:|:-----------------------|
| 0                   | RowFlag_Bold           |
| 1                   | RowFlag_JavaScriptLink |
| 2                   | RowFlag_Color          |
| 3                   | RowFlag_OwnedByUser    |
| 4                   | RowFlag_IsDeleted      |

### Cell flags

| Position (1\<\<n)   | Flag                     |
|:-------------------:|:-------------------------|
| 0                   | CellFlag_Red             |
| 1                   | CellFlag_Yellow          |
| 2                   | CellFlag_Green           |
| 3                   | CellFlag_Disabled        |
| 4                   | CellFlag_IconFromLabel   |
| 5                   | CellFlag_ContextMenuIcon |
