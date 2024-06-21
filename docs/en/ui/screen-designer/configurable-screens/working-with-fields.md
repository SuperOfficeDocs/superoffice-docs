---
uid: screen-fields
title: Working with fields
description: How to add, move, and delete fields in a layout using the Screen Designer in Settings and maintenance.
author: Bergfrid Dias
date: 01.03.2024
keywords: ui, screen, customization
topic: howto
version: 10
audience: settings
audience_tooltip: Settings and maintenance
---

# Working with fields

[!include[Requirement](../../../../../common/includes/req-dev-tools.md)]

Labels and fields represent the essential contents of a screen. Whether creating a new layout or modify an existing one, start by clicking **Edit layout**. [Show me the detailed steps.][1] When done, **save or publish** the layout.

> [!TIP]
> You might want to [add or remove tabs][2] before you fine-tune the fields.

![Screen designer, company card, default field layout -screenshot][img1]

The list of fields on any screen contains all standard SuperOffice fields for that area plus all custom fields (both user-defined and extra).

## Add field

Any field can appear in multiple locations, if relevant.

To add a new field:

1. Select the tab where you want to add the field.
2. Make sure the **Fields** section is selected.
3. Locate the desired field in the **Fields** list.

    > [!TIP]
    > Use the filter function to find specific fields.

4. Drag the field from the list to a stapled area in the selected tab.

    To make a field visible on all tabs, place the field in the header or footer of the main card.

## Edit field settings

Edit field formatting (such as font size) to improve visibility.

1. Select the tab containing the field.
1. Click the field in the preview.
1. In the **Settings** section, edit the field formatting. The available settings depend on the selected field type.

    * Choose **Bold** or *Italic* to change the font style
    * Switch between left and right aligned values
    * Choose between small, normal, and large font

For example formatting, see the screenshot in the section about [adding a heading or divider][3].

## Move field

Add or move important custom fields to the main (left-most) tab for easy access. Move less important fields to secondary tabs as an alternative to removing them.

To move a field:

1. Select the tab containing the field.
2. Click **=** to the left of the field's label and dragging the field to a new position.

    > [!TIP]
    > To move a field to a different tab, drag it to the new tab, wait for the preview to update, and then drop the field into a stapled area on the new tab.

## Remove (hide) field

To reduce clutter, hide fields that are never used. Removed fields affect only what is shown in the user interface, and don't change the database or table values in any way.

To remove a field:

* Hold the pointer over a field and click the red circled x.

To restore the field, simply [re-add the field](#add-field).

> [!NOTE]
> Mandatory fields can't be deleted. However, you can move a mandatory field to another tab.

<!-- Referenced links -->
[1]: edit-card-layout.md
[2]: working-with-tabs.md
[3]: working-with-tabs.md#add-heading-or-divider

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/ui/edit-card-layout-fields.png
