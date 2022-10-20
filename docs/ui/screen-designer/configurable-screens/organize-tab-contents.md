---
uid: screen-organize-tab
title: Columns, labels/titles, and dividers
description: How to organize information into logical groups in the Screen Designer in Settings and maintenance.
author: Bergfrid Dias
so.date: 10.14.2022
keywords: ui, screen, customization
so.topic: howto
so.version: 10
---

# Use columns, labels/titles and dividers to organize information into logical groups

[!include[Requirement](../../../../common/includes/req-dev-tools.md)]

The instructions below assume you're already [editing the layout][1].

## Add heading or divider

1. Select the tab you want to add the element to.
2. Click to select the **Elements** section.
3. To add a header, click and drag the **Label** element to the layout.
4. To add a horizontal dotted line, click and drag the **Divider** element to the layout.

![Screen Designer fields and elements -screenshot][img2]

## Group fields in columns

By default, tabs have two columns. You can customize each tab individually and choose 1, 2, 3, or 4 columns depending on your needs.

> [!NOTE]
> Tabs with specific functions, such as **ERP** and **Note**, don't have a column setup. Go to **Settings and maintenance** > **ERP** to configure the contents of the ERP tab.

1. Select the tab you want to adjust columns for.
1. Select the **Columns** section.
1. Choose one of the four layout options.

If you reduce the number of columns, the fields will be moved to the new last column. For example, If you change from three to two, all fields in the third column are moved to the bottom of column 2. If you change to one column, all fields are moved to the first column.

If a user doesn't have the screen size to fit all columns, the columns will be stacked vertically.

With four columns, the visibility of some fields can be impaired. Consider hiding the field label to gain more space.

> [!TIP]
> You can also [add tabs][2] if things get crowded.

<!-- Referenced links -->
[1]: edit-card-layout.md
[2]: add-tab.md

<!-- Referenced images -->
[img2]: media/field-settings.png
