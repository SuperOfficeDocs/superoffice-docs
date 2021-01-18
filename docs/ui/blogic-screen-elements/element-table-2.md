---
title: blogic_element_table_2
description: Element table v2
author:
so.date:
keywords:
so.topic: reference
---

# Element table v2

The `Element table v2` is used for **layout**. It can contain other elements, which will be laid out in a grid.The children are laid out in a tabular fashion, starting in the top-left corner. When all columns in the current row are filled, the next child element starts a new row.

This is a **group element**. It defines the beginning of a group of elements and requires a matching group end element.

> [!NOTE]
> The number of rows will expand dynamically if there are more children than initial space.

* Each cell can have a header.
* Each cell can have additional padding on all sides.
* The whole table supports cell padding (inside cells), and cell spacing (between cells). Padding is always set in pixels.

> [!NOTE]
> Cell spacing doesn't create space between cells and outer table edges!

**Sizing:**

* Exact - pixels (px)
* Relative - percent (%)
* Dynamic -divide remaining space (*)

## Configuration

| Setting               | Description                                            |
|:----------------------|:-------------------------------------------------------|
| rows                  | Initial size                                           |
| columns               | Initial size                                           |
| border                | Whether to outline the table and each cell (Bool)      |
| cellspacing           | Pixels between neighboring cells, both horizontally and vertically |
| cellpadding           | Pixels of padding on each side of a cell and the table outer edges |
| row                   | Array with size and padding for each row (optional)    |
| row.length            | Number of rows (in array)                              |
| row.n.size            | Height of row n (specify unit)                         |
| row.n.paddingTop      | Top padding for all cells in this row                  |
| row.n.paddingBottom   | Bottom padding for all cells in this row               |
| column                | Array with size and padding for each column (optional) |
| column.length         | Number of columns (in array)                           |
| column.n.size         | Width of column (specify units)                        |
| column.n.paddingLeft  | Left padding for all cells in this column              |
| column.n.paddingRight | Right padding for all cells in this column             |
| margin                | Outer margin for all 4 table sides                     |
| marginLeft            | Outer margin - left                                    |
| marginTop             | Outer margin - top                                     |
| marginRight           | Outer margin - right                                   |
| marginBottom          | Outer margin - bottom                                  |

> [!TIP]
> Setting margin for a specific side (top,bottom,left,right) overwrites the generic *margin*.

### Config for immediate child elements

You can define these config values for the children, and they will be picked up by the layout table and applied.

| Setting              | Description                                       |
|:---------------------|:--------------------------------------------------|
| layout.label         | Add header to this child                          |
| layout.colspan       | Whether the child may span multiple columns       |
| layout.rowspan       | Whether the child may span multiple rows          |
| layout.paddingLeft   | Left padding of this child                        |
| layout.paddingTop    | Top padding of this child                         |
| layout.paddingRight  | Right padding of this child                       |
| layout.paddingBottom | Bottom padding of this child                      |
