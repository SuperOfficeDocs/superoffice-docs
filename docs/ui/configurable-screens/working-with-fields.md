---
uid: screen-fields
title: Working with fields
description: How to add, move, and delete fields in a layout using the Screen Designer in Settings and maintenance.
author: Bergfrid Dias
so.date: 10.10.2022
keywords: ui, screen, customization
so.topic: howto
so.version: 10
---

# Working with fields

[!include[Requirement](../../../common/includes/req-dev-tools.md)]

Fields represent the essential contents of a card. Whether you create a new layout or modify an existing, you start by clicking **Edit layout**. [Show me the detailed steps.][1]

> [!TIP]
> You might want to [add or remove tabs][2] before you fine-tune the fields.

![Screen designer, company card, default field layout -screenshot][img1]

## Add

You can place the same field in multiple locations in the screen layout, if relevant.

To add a new field:

1. Select the tab you want to add the field to.
2. Make sure the **Fields** section is selected.
3. Locate the field you want to add in the list.

    > [!TIP]
    > Use the filter function to find specific fields.

4. Drag the field from the list to a stapled area in the selected tab.

    To make a field visible on all tabs, place the field in the header or footer of the card.

## Edit field settings

Edit field formatting (such as font format) and other settings by clicking the field.

## Highlight essential data

Format fields to improve visibility

## Use columns, labels/titles and dividers to organize information into logical groups

### Add heading or divider

### Group fields in tabs/columns

## Organize custom fields in the **More** tab

## Move

You can give easy access to important custom fields by adding or moving them to the main (left-most) tab. You can also move less important fields to secondary tabs as an alternative to removing them.

To move a field:

1. Select the tab containing the field.
2. Click **=** to the left of the field's label and dragging the field to a new position.

    > [!TIP]
    > To move a field to a different tab, drag it to the new tab, wait for the preview to update, and then drop the field into a stapled area on the new tab.

## Remove (hide)

To reduce clutter, it is useful to hide fields that are never used (either by the organization or a specific user group). The field and its contents remains in the database even tho it's not shown on the card.

To remove a field:

* Hold the pointer over a field and click the red x.

If you want the field back later, simply [re-add the field](#add).

> [!NOTE]
> Mandatory fields can't be deleted. However, you can move a mandatory field to another tab.

<!-- Referenced links -->
[1]: edit-card-layout.md
[2]: add-tab.md

<!-- Referenced images -->
[img1]: media/edit-card-layout-fields.png
