---
uid: help-en-screen-designer-edit-layout
title: Edit the layout of a card
description: How to edit the layout of a main card using the Screen Designer in Settings and maintenance.
keywords: screen layout, edit layout, change layout, delete layout, Reset to factory settings
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
  - /en/customization/screen-designer/edit-layout
  - /en/ui/screen-designer/configurable-screens/edit-card-layout
  - /en/ui/screen-designer/learn/elements
---

# Edit the layout of a card

[!include[Requirement](../../../includes/req-dev-tools.md)]

When you have [created a new layout][6], it is time to customize it. Personalize the layout for the main cards and archives to match your organization's information needs.

## Considerations

Before customizing a layout, determine who the intended users are.

* What do they need at their fingertips?
* Do they need all default fields and tabs, or should you remove something?
* Do they require additional tabs?
* What is the logical order of fields?

> [!NOTE]
> You can edit the **default layout**, however, you cannot edit the default control settings and you cannot re-assign the layout to a user group.

## <a id="edit"></a>Edit card layout

1. Open the Screen Designer.
2. At the top, select a screen or dialog to customize.
3. Select a layout in the list on the left side.
4. Click <i class="ph ph-pencil-simple" aria-label="Edit layout"></i> below the preview.
5. In the **Edit card layout** screen, work your way through the tabs of the screen.

    * [Add, edit, move, or remove a field][1]
    * [Add link or button][2]
    * [Organize information into logical groups][4]
    * [Add, remove, or restore a tab][3]
    * [Change the number of columns in a tab][5]<a id="columns"></a>

![Remove, add and move the different fields in the layout -screenshot][img3]

## <a id="save"></a>Save, publish, or cancel

After editing a layout, click one of the following buttons:

| Button | Description |
|---|---|
| Save draft | Saves an unpublished version of the layout, which you can resume editing later or ask someone to review. |
| Save + Publish | Applies the layout to the selected user groups **or** sale/project/request/follow-up type . |
| Cancel | Discards all changes. |

## <a id="undo-changes"></a>Undo changes

If you need to revert to an earlier version of the screen, you can access the following options from the **Task** button (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>):

* **Reset to factory settings**: This option discards all changes and resets the layout to the default version provided by SuperOffice.

* **Restore tabs**: This option reinstates any tabs that have been previously removed.

* **Discard draft**: This option discards all unsaved changes and reverts the layout to the most recently published version.

## <a id="delete"></a>Delete layout

When a user-group-based layout is deleted, users in that group see the default (system) layout.

To delete a layout:

1. Select the layout in the **Layouts** list.
1. Click **Delete**.

## Related content

* [Working with section tabs (archives)][7]

<!-- Referenced links -->
[1]: working-with-fields.md
[2]: add-button.md
[3]: working-with-tabs.md
[4]: working-with-tabs.md#label
[5]: working-with-tabs.md#columns
[6]: add-layout.md
[7]: working-with-archives.md

<!-- Referenced images -->
[img3]: ../../../../media/loc/en/customization/edit-the-screen-layout-of-companies-and-contacts.png
