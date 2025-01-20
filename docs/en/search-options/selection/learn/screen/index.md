---
uid: help-en-selection-screen
title: Section tabs in the Selection screen
description: Section tabs in the Selection screen
keywords: selection
author: SuperOffice RnD
date: 09.17.2024
version: 10.3.9
topic: reference
language: en
audience: person
audience_tooltip: SuperOffice CRM
---

# The Selection screen

The first tab in a selection contains a list of members (records, data) in the active selection. Selection members can be companies or contacts, projects, sales, documents, follow-ups, form submissions, chat conversations, mailings or products.

The appearance of the list of members varies slightly depending on what the selection contains. All selection types except **Company/contact** have two tabs containing selection data.

> [!TIP]
> If you double-click a record in the list of members, the record in question is displayed.

## Section tabs in the Selection screen

| Tab | Description |
|---|---|
| The list of members | Contains selection data. |
| Company/contact | Contains companies and contacts linked to list of members. Example: All contacts or companies linked to the sales in a selection. If the selection is a selection of companies/contacts, this is the only tab with members. |
| Criteria | View and [edit the criteria][3] for a dynamic selection. |
| Details | View and edit [general information for a selection][1]. |
| Charts | [View the selection data in a chart.][5] Charts of selections can also be used in [dashboards][6]. |
| Mailings | Create a mailing to contacts in a selection. [View the mailings](#mailing) that are archived on this selection. |

> [!TIP]
> Click <i class="ph ph-gear" aria-label="Gear"></i> to the right of the column headers in a selection to group and filter records, add/remove columns, and specify calculations. These settings can be saved for the active selection by selecting **Save columns for current selection only**. See also [The section tabs][9] for additional functions.

To move between selections, click the previous/next buttons (<i class="ph ph-arrow-left" aria-hidden="true"></i><i class="ph ph-arrow-right" aria-hidden="true"></i>) at the upper right of the screen.

### <a id="filter"></a>Filtering the list of members

> [!NOTE]
> Before you filter the list of members (for instance sales or follow-ups), you must click **Show all** in the tab footer. This ensures that the tab displays all records in the selection. To optimize performance when working with large selections, only the first 100 records are usually loaded in the list of members.

To activate the column filter, click <i class="ph ph-gear" aria-label="Gear"></i> to the right of the column headers and click **Enable filter**. The filter button (<i class="ph ph-funnel" aria-hidden="true"></i>) is now displayed on column which can be [filtered][8].

### The Task button <i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>

Use the **Task** button to perform different tasks for the members or some of the members of the selection. Examples: sending emails, mass-editing and exporting. Which tasks are displayed depends on what type of records the selection consists of (what is selected in the **Selection of** field).

### Other buttons

* **Remove members**. This option is only available for static selections. To [remove specific members of the selection][2], select the relevant members, right-click and select **Remove**.

* **Count: number**, The number of members in the active selection.

* **Show all**. Used to display all selection members.

    > [!NOTE]
    > By default the list displays only the 100 first records in the selection. To change this value, go to <i class="ph ph-user-circle" aria-hidden="true"></i> **Personal settings** > **Preferences** > **Functions** > **Archive page size**.

* <i class="ph ph-arrow-clockwise" aria-label="Refresh"></i> : Refreshes the data in the list.

### <a id="mailing"></a> View mailings archived on selection

Use the **Mailings** tab in the Selection screen to keep track of all mailings related to a selection.

Double-click a mailing to open it.

**Create a mailing**: Click to [create a new mailing][7] to the contacts in this selection.

**Export**: Used to export the list to a spreadsheet.

## Related topics

* [Perform tasks using selections][4]
* [Use filters in the section tabs][8]
* [Create selections][1]

<!-- Referenced links -->
[1]: ../create/index.md
[2]: ../update/add-remove-members-static.md
[5]: ../howto/display-as-charts.md
[3]: ../../../learn/search-criteria.md
[6]: ../../../../dashboard/learn/create.md
[7]: ../../../../marketing/mailing/learn/create/index.md
[8]: ../../../../learn/section-tabs/filter.md
[9]: ../../../../learn/section-tabs/index.md
[4]: ../../../../learn/getting-started/index.md

<!-- Referenced images -->
