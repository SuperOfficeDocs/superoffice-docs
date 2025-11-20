---
uid: help-en-screen-designer-fields
title: Working with fields
description: How to add, move, and delete fields in a layout using the Screen Designer in Settings and maintenance.
keywords: add field, new field, move field, remove field, hide field, edit layout, field settings
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
  - /en/ui/screen-designer/configurable-screens/working-with-fields
  - /en/customization/screen-designer/working-with-fields
---

# Working with fields

[!include[Requirement](../../../includes/req-dev-tools.md)]

Labels and fields represent the essential contents of a screen. Whether creating a new layout or modify an existing one, start by clicking <i class="ph ph-pencil-simple" aria-label="Edit layout"></i>. [Show me the detailed steps.][1] When done, **save or publish** the layout.

> [!TIP]
> You might want to [add or remove tabs][2] before you fine-tune the fields.

![Screen designer, company card, default field layout -screenshot][img1]

The list of fields on any screen contains all standard SuperOffice fields for that area plus all custom fields (both user-defined and extra).

## <a id="add"></a>Add field

Any field can appear in multiple locations, if relevant.

1. Select the tab where you want to add the field.
2. Make sure the **Fields** section is selected.
3. Locate the desired field in the **Fields** list.

    > [!TIP]
    > Use the filter function to find specific fields.

4. Drag the field from the list to a stapled area in the selected tab.

    ![Boxes with stapled lines -screenshot][img6]

    To make a field visible on all tabs, place the field in the header or footer of the main card.

## <a id="settings"></a>Edit field settings

Edit field formatting (such as font size) to improve visibility.

1. Select the tab containing the field.
1. Click the field in the preview.
1. In the **Settings** section, edit the field formatting. The available settings depend on the selected field type.

    * Choose **Bold** or *Italic* to change the font style
    * Switch between left and right aligned values
    * Choose between small, normal, and large font

For example formatting, see the screenshot in the section about [adding a heading or divider][3].

## <a id="move"></a>Move field

Add or move important custom fields to the main (left-most) tab for easy access. Move less important fields to secondary tabs as an alternative to removing them.

**Steps:**

1. Select the tab containing the field.
2. Click **=** to the left of the field's label and drag the field to a new position.

    > [!TIP]
    > To move a field to a different tab, drag it to the new tab, wait for the preview to update, and then drop the field into a stapled area on the new tab.

## <a id="delete"></a>Remove (hide) field

To reduce clutter, hide fields that are never used. Removed fields affect only what is shown in the user interface, and do not change the database or table values in any way.

* To remove a field, hold the pointer over a field and click the red circled x.

* To restore the field, simply [re-add the field](#add).

> [!NOTE]
> Mandatory fields cannot be deleted. However, you can move a mandatory field to another tab.

<!-- Referenced links -->
[1]: edit-layout.md
[2]: working-with-tabs.md
[3]: working-with-tabs.md#label

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/customization/edit-card-layout-fields.png
[img6]: ../../../../media/loc/en/customization/screendesigner-field-place.png
