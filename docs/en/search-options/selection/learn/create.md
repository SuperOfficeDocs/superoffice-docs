---
uid: help-en-selection-create
title: Create selection
description: Work with dynamic and static selections
keywords: add selection, create selection, new selection, save as selection, selection
author: Bergfrid Dias
date: 03.21.2025
version: 10.5.3
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: en
redirect_from:
  - /en/sale/saint/learn/using-status-monitors-in-dynamic-selections
  - /en/search-options/selection/learn/create/copy
  - /en/search-options/selection/learn/create/index
  - /en/search-options/selection/learn/create/tutorial
---

# Create selections

You start off with a set of criteria from the **Find** screen by using a typical search or adding your own criteria. From there you can save the result as a dynamic or static selection. The difference between the two are a selection that keeps on updating the number of members (dynamic) or a selection that have the members frozen with a snapshot of today's set of members (static).

## Steps

1. Click **New** on the top bar and select **Selection**.

1. In the Find screen, click the **Find** option that is relevant for the data type you want to use in your selection. You can also click **Typical searches** to use predefined searches.

1. [Add your search criteria][9] in the **Criteria** tab.

1. Click **Find**. The **Results** tab displays the data matching your criteria.

1. To save the results in a selection, click **Save as selection**. If not, refine your search criteria.

1. In the **Save as selection** dialog, choose type:

    * **Dynamic selection:** This type of selection will always be updated with members that match the selection criteria.
    * **Static selection:** This type of selection will contain only the members you have added manually.
    * **Add to existing static selection:** Save the result to an existing selection. You can manually add or remove members from the selection at a later time.

1. Click **Save**.

1. Type the name of the new selection where *Selection name* appears. This field is mandatory.

1. In the **Selection is** field, you can change to another type of selection if necessary.

1. **Set properties:**

    * **Owner:** The field automatically displays the user currently logged in.

        After saving a new selection, you can change the owner by [editing the selection][6]. In practice, this means that you transfer it from yourself to someone else.

    * **Category:** Choose the type of selection you require. These are defined in Settings and maintenance.

    * **Visible for:** Choose if the selection should be visible to everyone, private (only visible to the person defined as owner) or visible to everyone in the user group that the owner belongs to.

1. Add a description of the selection in the **Description** field, if relevant.

1. When you have finished defining the core data for the selection, click **Save**.

## <a id="copy"></a>Copy a selection

Selecting the **Copy the selection** task provides a quick and easy way of making an exact copy of a selection.

When you click this button, a copy of the selection is created, with the text (copy) next to the selection name. In other words, if you copy the selection named *My static selection*, the copy will be named *My static selection (copy)*.

1. [!include[Start](includes/steps-start-task.md)]

1. Click <i class="ph ph-dots-three-circle-vertical" aria-label="Task button"></i> and select **Copy the selection**. This creates a copy of the selection.

1. Give the new selection a new name.

## Tips

* If you try to create a selection with the same name as an existing selection, the [Duplicates dialog][8] opens. This works in the same way as for companies.

* Click <i class="ph ph-star" aria-label="Star icon"></i> to add the selection to [your favorites][7].

* Click <i class="ph ph-gear" aria-label="Gear"></i> to the right of the column headers. Here you can group and filter records, and add/remove columns. These settings can be saved for the active selection by selecting **Save columns for current selection only**.

* Check **Completed** to specify that the selection is inactive. If you want the selection to be active, leave this box unchecked.

* With **SAINT** enabled (requires Sales-Premium or Service-Premium), you can use [activity monitors][14] as criteria for creating dynamic selections. This allows you to get an overview of companies, contacts, or projects that meet specific status criteria. SAINT criteria are located under **Counters (SAINT)** in the [list of criteria][9] on the **Find** screen.

## Related content

* [Combine selections][3]
* [Update a selection][6]
* [Perform tasks using selections][5]

<!-- Referenced links -->
[3]: combine.md
[7]: ../../../learn/basics/fav.md
[8]: ../../../learn/basics/duplicates.md
[5]: howto/index.md
[6]: update.md
[9]: ../../learn/search-criteria.md
[14]: ../../../saint/learn/index.md
