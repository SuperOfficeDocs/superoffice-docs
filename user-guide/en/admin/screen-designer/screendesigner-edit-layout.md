---
uid: help-en-screendesigner-edit-layout
title: ScreenDesigner Edit layout
description: ScreenDesigner Edit layout
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
---

# Edit layout

When you have created a new layout as described in [Add new layout][4], it is time to customize it according to the needs of the assigned user group(s). If you are customizing a layout for the sales team, you should have a clear plan of what their needs are with regards to the layout and formatting of the tabs, fields, elements and columns. Which information should be first and easiest to find? Do they need all fields and tabs? What is the logical order of the fields?

**To edit a screen layout:**

Click the **Screen designer** button in the Navigator (![icon][img3]).

Click **Company** or **Contact** at the top.

Select a layout in the list on the left side.

Click **Edit layout** below the preview. The **Edit card layout** window opens.

See the sections below for more information on how to edit the layout.

When you have finished the screen layout, click one of the following buttons:

* **Save draft**: Click this button if the layout is not finished yet.
* **Save + Publish**: Click this button to publish the layout to the selected user groups.
* **Cancel**: Click this button to discard all changes. See also [Undo changes](#undo-changes).

## Edit existing fields in the layout

1. Select the tab you want to edit.
2. Edit existing fields as follows:
    * Move fields by clicking ![icon][img4] to the left of a field label and dragging the field to a new position. To add a new field, see [Fields](#fields).
    * Delete fields by holding the mouse-pointer over a field and clicking ![icon][img2]. Deleted fields can be re-added from the **Fields** section. Mandatory fields cannot be deleted, and the **Delete** button will not appear for such fields. See [Fields](#fields).
    * Edit field formatting (such as font format) and other settings by clicking the field. The **Settings** section opens in the left part of the window. See [Settings](#settings).
3. Change the number of columns in a tab, from the **Columns** section. See [Columns](#columns).
4. Save the changes as described above.

## Add new content to a layout

Select the tab you want to edit, or click ![icon][img5] **Add** to add a new tab. See [Tabs](#tabs).

Edit the layout by selecting one of the following sections:

* **Fields**: Drag fields from the list to the layout. <!-- Reuse-->Boxes with stapled lines in the layout, indicate where you can place a field. Fields can be placed in the columns and in the header and footer. See [Fields](#fields).
* **Elements**: Drag various elements such as labels, dividers, links and buttons to the layout. Place the elements as described above. See [Elements](#elements).
* **Settings**: Click a field or element in the layout to edit the relevant settings. The available settings may vary according to the selected object. See [Settings](#settings).
* **Columns**: Select how many columns you want to display in a tab. See [Columns](#columns).

When you have finished customizing the screen layout, click one of the following buttons:

* **Save draft**: Click this button if the layout is not finished yet.
* **Save + Publish**: Click this button to publish the layout to the selected user groups.
* **Cancel**: Click this button to discard all changes.

Below you can find more detailed descriptions of the various sections and functions.

## Fields

In the **Fields** section you can find all available data fields for the selected screen layout. Use the filter function to find specific fields.

* Drag a field from the list to a stapled area in the selected tab.
* To make sure a field is always visible, no matter which tab is selected, place the field in the header or footer.
* You can place the same field in multiple locations in the screen layout, if relevant.
* Move fields by clicking ![icon][img4] to the left of a field label and dragging the field to a new position. To move a field to another tab, drag the field to the tab header to open the tab, and then place the field in the open tab.
* Delete fields by holding the mouse-pointer over a field and clicking ![icon][img2]. Mandatory fields cannot be deleted, and the **Delete** button will not appear for such fields.

Limitations:

* Mandatory fields cannot be deleted. This is defined in [Fields][5] screen.
* Some tabs, such as **ERP** and **Note**, cannot be edited, since they have specific functions.

## Elements

In the **Elements** section you can add various non-data elements such as labels, dividers, links and buttons.

Click the links below to learn more about the various elements and how to add them:

<!-- Fix reuse ID=a2 -->

Labels can be used to create headings for specific groups of fields or a column.

1. Select the tab you want to edit.
2. Click and drag the **Label** element to the layout.
3. Click the label. The **Settings** sections opens to the left.
4. Replace the text **New label** with the new label name.
5. You can also add the label in other languages by clicking ![icon][img1] (see [Translation][2]).
6. Change the font formatting as necessary.

<!-- Fix reuse ID=a3 -->

Use dividers to create sections within columns. This is particularly useful for grouping various types of information.

1. Select the tab you want to edit.
2. Click and drag the **Divider** element to the layout.
3. Click the divider. The **Settings** sections opens to the left.
4. If relevant, change the spacer type.

<!-- Fix reuse ID=a4 -->

Add links for looking up information in other websites, allow users to run CRM scripts from the company and contact cards, and add navigation to other parts of SuperOffice using soprotocol. You can also use buttons to add links.

> [!TIP]
> You can use [Template variables][3] in the URLs.

Select the tab you want to edit.

Click and drag the **Link** element to the layout.

Click the link field. The **Settings** sections opens to the left.

Replace the text **Link** with the new link name.

You can also add the link name in other languages by clicking ![icon][img1] (see [Translation][2]).

In the **Action** list, select the action to perform when clicking the link:

* **Open website**: Select this option to add a link to a website. Select the URL encoding and target as necessary.
* **Execute CRMScript**: Select this option to add a CRM script to run specific actions in SuperOffice. See [CRMScript][6].
* **Shortcut (soprotocol)**: Select this option to add a shortcut to other screens and records in SuperOffice. See [SOProtocol][1].

In the **Mode** list, choose if the link should always be available, or if it should only be available in read or edit mode.

<!-- Fix reuse ID=a5 -->

Buttons work similarly to links. You can add links for looking up information in other websites, allow users to run CRM scripts from the company and contact cards, and add navigation to other parts of SuperOffice using soprotocol.

> [!TIP]
> You can use [Template variables][3] in the URLs.

Select the tab you want to edit.

Click and drag the **Button** element to the layout.

Click the button. The **Settings** sections opens to the left.

Replace the text **Button** with the new button name.

You can also add the button name in other languages by clicking ![icon][img1] (see [Translation][2]).

In the **Action** list, select the action to perform when clicking the button:

* **Open website**: Select this option to add a link to a website. Select the URL encoding and target as necessary.
* **Execute CRMScript**: Select this option to add a CRM script to run specific actions in SuperOffice. See [CRMScript][6].
* **Shortcut (soprotocol)**: Select this option to add a shortcut to other screens and records in SuperOffice. See [SOProtocol][1].

In the **Mode** list, choose if the button should always be available, or if it should only be available in read or edit mode.

In the **Style** list, select the style of the button. The preview on the right will update with the selected button style.

## Settings

Make fields more visible by changing the font to bold and large text. Make room for more fields by using a smaller font. Save screen space by hiding labels.

Click a field or element in the layout to edit its settings. The available setting will vary according to the type of field or element.

## Columns

By default a tab has 2 columns, but you can use anything from 1-4 columns depending on you needs. Users with wide screens may prefer more columns, to be able to view and sort more data.

Limitations:

* Changing from 2-4 columns to 1 column will move all fields into 1 column.
* Using 4 columns may affect visibility of some fields. You may consider to hide the labels of some fields (see [Settings](#settings)).
* Some tabs, such as **ERP** and **Note**, do not have a column setup, since they have specific functions.
* If a user does not have the screen size to fit all columns, they will be stacked on top of each other.

## Tabs

Add more tabs for additional fields, or remove irrelevant tabs.

To remove a tab, select it and click **Task** &gt; **Remove tab**. Click **OK** in the dialog that displays.

To add a new tab:

1. Click ![icon][img5] **Add**. The **Columns** section opens to the left.
2. Under **Tab title**, replace the text **New tab** with the new tab name.
3. You can also add the tab name in other languages by clicking ![icon][img1] (see [Translation][2]).
4. Select the number of columns you want to use in the new tab.

> [!TIP]
> If you later want to rename the tab, select the tab and select **Columns**.

Limitations:

* You cannot rename any of the default tabs.
* You cannot remove a tab that contains mandatory fields. Mandatory fields must be moved to another tab first.
* If there is only one tab left, you cannot delete it.

## Undo changes

If you need to revert to an earlier version of the screen, you can access the following options from the **Task** button:

* **Reset to factory settings**: This option discards all changes and resets the screen layout to the standard layout delivered by SuperOffice.
* **Discard draft**: Discards all changes and resets to the published version of the screen layout.

<!-- Referenced links -->
[1]: ../../../../docs/ui/soprotocol/index.md
[2]: ../../user/standardcrm/translate-fields.md
[3]: ../../user/diary/template-variables.md
[4]: screendesigner-add-new-layout.md
[5]: ../fields-web/fields-web.md
[6]: ../../user/service/automation/index.md

<!-- Referenced images -->
[img1]: ../../../media/icons/translate.png
[img2]: ../media/btn-delete-admin.png
[img3]: ../media/knapp-screendesigner-small.png
[img4]: ../media/btn-move.png
[img5]: ../media/btn-add2.png
