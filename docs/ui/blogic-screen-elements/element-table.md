---
title: blogic_element_table
description: Element table
author:
so.date:
keywords:
so.topic: reference
---

# Element table

The `Element table` is used for **layout**. It can contain other elements, which will be laid out in a 1-row grid.

This is a **group element**. It defines the beginning of a group of elements and requires a matching group end element.

## Configuration

| Setting       | Description                                           |
|:--------------|:------------------------------------------------------|
| columns       | The number of columns in the grid                     |
| verticalSpace | Whether to add vertical space between elements (Bool) |
| cellspacing   | Space between cells in the grid (in pixels)           |
| cellpadding   | Padding inside a cell (in pixels)                     |
| width         | The width of the table (in percent or pixels)         |

### Config for immediate child elements

You can set and position a labels, config vertical space, and config dynamic resizing (v. 4.2.21/4.4.2) for each immediate child of the element table.

| Setting                       | Description                                       |
|:------------------------------|:--------------------------------------------------|
| label                         | UI label in grid                                  |
| labelPos                      | positions element<br/>above or left (default)     |
| verticalSpace                 | full: unlimited (full-size)<br/>rest: resize element to remaining v. space |
| sizeAttributes_blockSetHeight | Set to true to prevent vertical resizing          |
| sizeAttributes_blockSetWidth  | Set to true to prevent horizontal resizing        |
| sizeAttributes_minHeight      | Sets the min height the element can be resized to |
| sizeAttributes_maxHeight      | Sets the max height the element can be resized to |
| sizeAttributes_absoluteHeight | Sets a fixed height for this element              |
| sizeAttributes_minWidth       | Sets the min width the element can be resized to  |
| sizeAttributes_maxWidth       | Sets the min width the element can be resized to  |
| sizeAttributes_absoluteWidth  | Sets a fixed width for this element               |

> [!NOTE]
> If multiple child elements have verticalSpace=rest, the remaining space will be divided equally.<br/>Size attributes apply only to child elements that support dynamic resizing. If not supported, these attributes will be ignored.
