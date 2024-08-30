---
uid: help-en-screen-designer-edit-layout
title: Edit main cards layout
description: In this how-to guide, you will learn how to edit a layout.
keywords: screen designer, layout, field
author: Bergfrid Dias
date: 06.11.2024
version: 10.3.7
topic: howto
language: en
audience: settings
audience_tooltip: Settings and maintenance
---

# Edit layout - Main cards

When you have [created a new layout][4], it is time to customize it according to the needs of the assigned user group(s). If you are customizing a layout for the sales team, you should have a clear plan of what their needs are with regards to the layout and formatting of the tabs, fields, elements and columns on the main card. Which information should be first and easiest to find? Do they need all fields and tabs? What is the logical order of the fields?

Personalize the layout for the main cards and archives to match your organization's information needs. When you edit the layout on a main card, you can add and remove fields, or rearrange the order to fit your team's needs. First, you need to know what information is most important for the team.

Watch this video and find out how to use the screen designer to configure your screens in SuperOffice CRM or follow the step-by-step guide below (video length - 6:41):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/EcL4TEXXvmU]

## Steps

<!-- markdownlint-disable MD029 -->
[!include[Go to screen designer](includes/goto-screen-designer.md)]
<!-- List starts in the include. Next line MUST be 3. -->
3. Click **Main cards**.

4. Select a layout in the list on the left side.

5. Click **Edit layout** below the preview.

6. In the **Edit card layout** window, edit the layout as described below.

7. After finishing, click one of the following buttons:

    * **Save draft**: Click this button if the layout is not finished yet.
    * **Save + Publish**: Click this button to publish the layout to the selected user groups.
    * **Cancel**: Click this button to [discard all changes](#undo-changes).
<!-- markdownlint-restore -->

## Edit existing fields in the layout (working with fields)

1. Select the tab you want to edit.

2. Edit existing fields:

    * Move fields by clicking ![icon][img4] to the left of a field label and dragging the field to a new position. To add a new field, see [Fields](#fields).

    * Delete fields by holding the mouse-pointer over a field and clicking ![icon][img2]. Deleted fields can be re-added from the **Fields** section. Mandatory fields cannot be deleted, and the **Delete** button will not appear for such fields. See [Fields](#fields).

    * Edit field formatting (such as font format) and other settings by clicking the field. The **Settings** section opens in the left part of the window. See [Settings](#settings).

3. [Change the number of columns in a tab](#columns) from the **Tab layout** section.

4. Save the changes as described above.

![Remove, add and move the different fields in the layout -screenshot][img3]

## Add new content to a layout

1. Select the tab you want to edit, or click ![icon][img5] **Add** to [add a new tab](#tabs).

2. Edit the layout by selecting one of the following sections:

    * **Fields**: Drag [fields](#fields) from the list to the layout. Fields can be placed in the columns and in the header and footer.

    * **Elements**: Drag various elements such as labels, dividers, links and buttons to the layout.

    * **Settings**: Click a field or element in the layout to edit the relevant settings. The available settings may vary according to the selected object. See [Settings](#settings).

    * **Tab layout**: [Select how many columns you want to display in a tab](#columns).

3. After customizing the screen layout, click one of the following buttons:

    * **Save draft**: Click this button if the layout is not finished yet.
    * **Save + Publish**: Click this button to publish the layout to the selected user groups.
    * **Cancel**: Click this button to discard all changes.

Boxes with stapled lines in the layout, indicate where you can place a field:

![Boxes with stapled lines -screenshot][img6]

Below you can find more detailed descriptions of the various sections and functions.

## <a id="fields"></a>Fields (working with fields)

In the **Fields** section you can find all available data fields for the selected screen layout. Use the filter function to find specific fields.

* Drag a field from the list to a stapled area in the selected tab.
* To make sure a field is always visible, no matter which tab is selected, place the field in the header or footer.
* You can place the same field in multiple locations in the screen layout, if relevant.
* Move fields by clicking ![icon][img4] to the left of a field label and dragging the field to a new position. To move a field to another tab, drag the field to the tab header to open the tab, and then place the field in the open tab.
* Delete fields by holding the mouse-pointer over a field and clicking ![icon][img2]. Mandatory fields cannot be deleted, and the **Delete** button will not appear for such fields.

**Limitations:**

* Mandatory fields cannot be deleted. This is defined in [Fields][3] screen.
* Some tabs, such as **ERP** and **Note**, cannot be edited, because they have specific functions.

## Elements

In the **Elements** section you can add various non-data elements such as labels, dividers, links and buttons.

## <a id="settings"></a>Settings

Make fields more visible by changing the font to bold and large text. Make room for more fields by using a smaller font. Save screen space by hiding labels.

Click a field or element in the layout to edit its settings. The available setting will vary according to the type of field or element.

## <a id="columns"></a>Tab layout

By default a tab has two columns, but you can [rearrange fields into 1-4 columns][2] depending on you needs.

## <a id="tabs"></a>Tabs

Add more tabs for additional fields, or remove irrelevant tabs. For details, see [working with tabs][1].

## <a id="undo-changes"></a>Undo changes

If you need to revert to an earlier version of the screen, you can access the following options from the **Task** button:

* **Reset to factory settings**: This option discards all changes and resets the screen layout to the standard layout delivered by SuperOffice.
* **Discard draft**: Discards all changes and resets to the published version of the screen layout.

<!-- Referenced links -->
[1]: working-with-tabs.md
[2]: working-with-tabs.md#columns
[3]: ../../../custom-objects/admin/create-extra-field.md
[4]: add-new-layout.md

<!-- Referenced images -->
[img2]: ../../../../../common/icons/delete-circle-red.png
[img4]: ../../../../media/icons/criteria-move.png
[img5]: ../../../../../common/icons/add-icon.png
[img3]: ../../../../media/loc/en/ui/edit-the-screen-layout-of-companies-and-contacts.png
[img6]: ../../../../media/loc/en/ui/screendesigner-field-place.png
