---
uid: help-en-udef-layout
title: Customize layout of user-defined fields
description: How to customize layout of user-defined fields without the Screen Designer.
keywords: udef, user-defined field, custom field, page 1, align fields, move field
author: Bergfrid Dias
date: 01.16.2024
version: 10
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: en
index: true
---

# Customize layout of user-defined fields

[!include[License requirement](../../includes/req-dev-tools.md)]

SuperOffice version 10 (released October 2021) introduced [Screen designer][1] with customizable screen layouts for specific user groups. Any custom screen layouts using screen designer may override the settings described below.

When you [add new fields][2], they are placed beneath each other by default. Each field consists of a label with a data field on the right. You can decide where in the grid these fields are to be placed.

## Where to begin

1. [!include[Go to fields and select tab](includes/goto-fields.md)]

**How to select fields:**

* Click a field in the grid to select it.
* Click and drag in the grid to select several fields.
* Click a field in the **Fields** list to select both the label and the data field in the grid.

## Move field

* Click and drag using the mouse. The fields will automatically be adjusted to fit the grid.
* Click a field and use the arrow keys on the keyboard.
* Click a field and use the arrow buttons in the bottom-right corner (<i class="ph ph-arrow-circle-left" aria-hidden="true"></i> <i class="ph ph-arrow-circle-right" aria-hidden="true"></i> <i class="ph ph-arrow-circle-up" aria-hidden="true"></i> <i class="ph ph-arrow-circle-down" aria-hidden="true"></i>).
* Double-click a field and specify position values **X** and **Y** in the **Fields** dialog.

## Set position

1. Specify the following in the fields to the right of **Label**:

    **X**: horizontal position of the label. The higher the number, the further to the right.

    **Y**: vertical position of the label. The higher the number, the further down.

2. Specify the following in the fields to the right of **Data**:

    **X**: horizontal position of the data field. The higher the number, the further to the right.

    **Y**: vertical position of the data field. The higher the number, the further down.

## Align fields (right/left)

Select the fields you want to adjust and click left-align (<i class="ph ph-text-align-left" aria-hidden="true"></i>) or right-align (<i class="ph ph-text-align-right" aria-hidden="true"></i>) below the grid.

## Change the width of a field

1. Double-click the relevant field in the **Fields** list or the grid
2. Specify the width of the label in the field to the right of **Label**.
3. Specify the width of the data field in the field to the right of **Data**.

## Edit the TAB order of fields in the More tab

The TAB order is the order that you move between the various fields when you press the TAB key. You can change the TAB order to reflect the logical sequence users normally enter data in fields.

The TAB order is displayed in the **Name** list on the left of the screen. This order is not the same as the fields' physical positions, which are shown in the preview field at the upper right.

**Steps:**

1. Select the required field below the list.

1. Click <i class="ph ph-arrow-circle-up" aria-label="Arrow up"></i> <i class="ph ph-arrow-circle-down" aria-label="Arrow down"></i> below the list to move the field either up or down.

1. Click **Publish** to make the changes available to SuperOffice CRM users.

## <a id="page-1"></a>Display a user-defined field on the first page

1. Check **Allow different page 1 fields for different user groups** at the bottom of the tab to specify different page 1 fields for different user groups. If not checked, the fields you specify are used for all user groups.

1. In the user group list above, select the required user group (if you checked **Allow different page 1 fields for different user groups** in the previous step).

1. In the **Field 1** list box, choose the field to display at the top. Choose the fields to display in the next positions in the **Field 2** and **Field 3** list boxes.

1. Click **Save** to save your changes only in Settings and maintenance or click **Publish** to make the changes available to SuperOffice CRM users.

### User groups and page 1 fields

User groups are defined in the **Lists** screen, and the group that a user belongs to is defined in the Users screen. When you select a name in the **User group** list, the available page 1 fields for the selected user group are displayed under **Fields 1**, **2**, and **3**.

If you select **(all user groups)** in the **User group** list, select a field or fields and save the setup, the same selection of fields will apply to all user groups in SuperOffice CRM. If you then select a specific user group, you can override the existing field setup for just this group by using a different specification. If you do not specify anything in a field, it is left empty – because the override applies to all three fields irrespective of their contents.

> [!NOTE]
> You must publish an override for a single user group *after* you specify a setup for all user groups. Otherwise, it will not take effect.

<!-- Referenced links -->
[1]: ../../customization/screen-designer/admin/index.md
[2]: add-udef.md
