---
uid: elp-en-screen-designer-tabs
title: Working with tabs
description: How to add, organize, delete, and restore a tab in a layout and how to organize its information into logical groups using the Screen Designer in Settings and maintenance.
keywords: ui, screen, customization, tab layout, heading, label, divider
author: Bergfrid Dias
date: 06.11.2024
version: 10.3.7
topic: howto
language: en
audience: settings
audience_tooltip: Settings and maintenance
---

# Working with tabs

[!include[Requirement](../../../../../common/includes/req-dev-tools.md)]

The instructions below assume you are already [editing the layout][2].

## Add a tab

You can add custom tabs, for example, for fields related to a specific area.

To add a new tab:

1. Click **Add**. The **Tab layout** section opens to the left.

2. Under Tab title, replace the text "New tab" with the new tab name.

    > [!NOTE]
    > You can also click ![icon][img1] to [add the tab name in other languages][3].

3. Select the number of columns you want to use in the new tab.

> [!TIP]
> To rename the tab, select the tab and select **Tab layout**. You **cannot rename any of the default tabs**.

## Remove a tab

To reduce clutter, remove irrelevant and no longer useful tabs.

Layouts must have at least one tab. If there is only one tab remaining, you cannot remove it.

> [!NOTE]
> If the tab contains any mandatory fields, you must move those to another tab before deleting the current tab.

To remove a tab:

1. Select the tab.
1. Click **Task** and select **Remove tab**.
1. Click **OK** to confirm and close the dialog.

## Restore a tab

If you remove a tab and later want it back, you can restore it.

1. Open the layout in edit mode.
1. Click **Task** and select **Restore tabs**.

> [!NOTE]
> This action restores **all** tabs that you have removed.

## Add heading or divider

Labels can be used to create headings for specific groups of fields or a column. Use dividers to create sections within columns. Useful for grouping various types of information.

1. Select the tab you want to add the element to.
2. Click to select the **Elements** section.
3. To add a header, click and drag the **Label** element to the layout.

    * In the **Settings** sections, replace the text "New tab" with the new label name. Optionally, click ![icon][img1] to [add the tab name in other languages][3].
    * Change the font formatting as necessary.

4. To add a horizontal dotted line, click and drag the **Divider** element to the layout. If relevant, change the spacer type.

![Screen Designer fields and elements -screenshot][img2]

## <a id="columns"></a>Group fields in columns

By default, tabs have two columns. You can customize each tab individually and choose 1, 2, 3, or 4 columns depending on your needs.

> [!NOTE]
> Tabs with specific functions, such as **ERP** and **Note**, do not have a column setup. Go to **Settings and maintenance** > **ERP** to configure the contents of the ERP tab.

**Steps:**

1. Select the tab you want to adjust columns for.
1. Select the **Tab layout** section.
1. Choose one of the four layout options.

If you reduce the number of columns, the fields are moved to the new last column. For example, when reducing the number of columns from three to two, all fields in the third column move to the bottom of column 2. When reduced to one column, all fields move to the first column.

The columns are vertically stacked when the screen size is too small to show them all horizontally.

Users with wide screens may prefer more columns, to view and sort more data. However, with four columns, the visibility of some fields can be impaired. Consider hiding the field label to gain more space.

> [!TIP]
> You can also add tabs if things get crowded.

## Related content

* [Working with fields][1]

<!-- Referenced links -->
[1]: ../configurable-screens/working-with-fields.md
[2]: ../configurable-screens/edit-card-layout.md
[3]: ../../../globalization-and-localization/learn/translate-fields.md

<!-- Referenced images -->
[img1]: ../../../../../common/icons/az.png
[img2]: ../../../../media/loc/en/ui/field-settings.png
