---
uid: help-en-screen-designer-edit-layout
title: Edit the layout of a card
description: How to edit the layout of a main card using the Screen Designer in Settings and maintenance.
keywords: Screen designer, layout, field
author: Bergfrid Dias
date: 10.07.2024
version: 10.3.10
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: en
---

# Edit the layout of a card

[!include[Requirement](../../../../../common/includes/req-dev-tools.md)]

When you have [created a new layout][6], it is time to customize it. Personalize the layout for the main cards and archives to match your organization's information needs.

## Considerations

Before customizing a layout, determine who the intended users are.

* What do they need at their fingertips?
* Do they need all default fields and tabs, or should you remove something?
* Do they require additional tabs?
* What is the logical order of fields?

> [!NOTE]
> You can edit the **default layout**, however, you cannot edit the default control settings and you cannot re-assign the layout to a user group.

Watch this video and find out how to use the screen designer to configure your screens in SuperOffice CRM or follow the step-by-step guide below (video length - 6:41):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/EcL4TEXXvmU]

## <a id="edit"></a>Edit card layout

1. Open the Screen Designer.
2. At the top, select a screen or dialog to customize.
3. Select a layout in the list on the left side.
4. Click **Edit layout** below the preview.
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

If you need to revert to an earlier version of the screen, you can access the following options from the **Task** button:

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
[img3]: ../../../../media/loc/en/ui/edit-the-screen-layout-of-companies-and-contacts.png
