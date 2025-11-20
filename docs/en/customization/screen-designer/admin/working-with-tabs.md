---
uid: help-en-screen-designer-tabs
title: Working with tabs
description: How to add, organize, delete, and restore a tab in a layout and how to organize its information into logical groups using the Screen Designer in Settings and maintenance.
keywords: layout, tab layout, add tab, remove tab, restore tab, group fields, More tab, add heading, add label, add divider
author: digitaldiina
date: 11.20.2025
version: 11.6
content_type: howto
license: development-tools
audience: settings
audience_tooltip: Settings and maintenance
category: customization
topic: screen designer
language: en
index: true
redirect_from:
  - /en/ui/screen-designer/configurable-screens/working-with-tabs
  - /en/customization/screen-designer/working-with-tabs
---

# Working with tabs

[!include[Requirement](../../../includes/req-dev-tools.md)]

This guide assumes you are already [editing the layout][2]. The following sections explain how to organize and customize tabs in SuperOffice CRM, helping you tailor the interface to meet your organization's needs.

## Add tab

Creating custom tabs allows you to group related fields in a way that makes sense for your organization. For instance, you can create tabs dedicated to specific business areas, making information easier to find.

**Steps:**

1. Click **Add**. The **Tab layout** section opens to the left.

2. Under Tab title, replace the text "New tab" with the new tab name.

    You can also click <i class="ph ph-translate" aria-label="Translate"></i> to [add the tab name in other languages][3].

3. Select the number of columns you want to use in the new tab.

## Rename tab

If you need to rename the tab later, select the tab and go to **Tab layout**. You **cannot rename any of the default tabs**.

## Remove tab

To streamline the interface, you may want to remove tabs that are no longer necessary. A layout must have at least one tab. If only one tab remains, it cannot be removed.

> [!NOTE]
> If the tab contains mandatory fields, you must move those fields to another tab before deleting the current one.

**Steps:**

1. Select the tab.
1. Click <i class="ph ph-dots-three-circle-vertical" aria-label="Task button"></i> and choose **Remove tab**.
1. Click **OK** to confirm and close the dialog.

## Restore tab

If you remove a tab and later decide you need it, you can easily restore it.

1. Open the layout in edit mode.
1. Click <i class="ph ph-dots-three-circle-vertical" aria-label="Task button"></i> and select **Restore tabs**.

> [!NOTE]
> This action restores **all** previously removed tabs.

## <a id="label"></a>Add heading or divider

Labels and dividers help to organize fields within a tab, making the information more readable and accessible. Use labels to create headings and dividers to separate sections within a column.

1. Select the tab where you want to add the element.
2. Click to select the **Elements** section.
3. To add a header, drag the **Label** element into the layout.

    * In the **Settings** sections, replace "New label" with the new label name. Optionally, click <i class="ph ph-translate" aria-label="Translate"></i> to [add the tab name in other languages][9].
    * Adjust the font as needed.

4. To add a horizontal divider, drag the **Divider** element into the layout. Change the spacer type if necessary.

![Screen Designer fields and elements -screenshot][img2]

## <a id="columns"></a>Group fields in columns

By default, tabs have two columns, but you can adjust this to meet your needs. Each tab can have 1, 2, 3, or 4 columns, depending on the amount of information you want to display.

> [!NOTE]
> Tabs with specific functions, such as **ERP** and **Note**, do not support column customization. Go to **Settings and maintenance** > **ERP** to configure the contents of the ERP tab.

**Steps:**

1. Select the tab where you want to adjust columns.
1. Go to the **Tab layout** section.
1. Choose one of the four layout options.

When reducing the number of columns, fields from the removed columns will move to the last remaining column. For example, if you reduce from three columns to two, fields in the third column will move to the bottom of the second column.

Columns will stack vertically when the screen is too small to display them horizontally.

If you have a wide screen, using more columns allows you to view more data simultaneously. However, be cautious. Using four columns might reduce the visibility of some fields. Hiding field labels can help create more space.

> [!TIP]
> If a tab becomes too crowded, consider adding additional tabs to better organize the information.

## <a id="more"></a>The More tab

The **More** tab automatically contains all [custom fields][3], arranged by rank. You can configure these fields within this tab and optionally add them to other screens.

[User-defined fields][5] (udef) and [extra fields][4] are created the same way as before.

## Related content

* [Working with fields][1]

<!-- Referenced links -->
[1]: working-with-fields.md
[2]: edit-layout.md
[3]: ../../../custom-objects/learn/index.md
[4]: ../../../custom-objects/admin/create-extra-field.md
[5]: ../../../custom-objects/admin/add-udef.md
[9]: ../../../localization/learn/translate-fields.md

<!-- Referenced images -->
[img2]: ../../../../media/loc/en/customization/field-settings.png
