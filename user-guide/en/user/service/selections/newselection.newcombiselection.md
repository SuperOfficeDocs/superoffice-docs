---
uid: help-en-selections-newselection-newcombiselection
title: selections newSelection newCombiSelection
description: selections newSelection newCombiSelection
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Service
so.topic: help
language: en
---

# Create a combined selection

A combined selection is a combination of two or more existing selections. Here you can add records from one selection to another, or remove records in one selection from another. This is useful if, for example, you want a selection containing all customers based on specific criteria (dynamic selection), but excluding individual customers (static selection). [!include[To do this](../../../includes/to-do-this.md)]

1. Select **Selections** &gt; **New selection**. This takes you to the **New selection** screen.

2. In the **Source table** field, select which type of records you want to include in the selection. For instance, if you want to create a selection of requests, select **Request**.

    > [!NOTE]
    > You can only combine selections with the same source table.

3. Check **Combined selection**.

4. Click **Continue**. This takes you to the **Edit selection** screen.

5. In the **General info** tab, enter the following:

    [!include[Contents of Selection General info tab](../../includes/selection-general-info.md)]

6. Go to the **Selection** tab. Here you're going to choose which selections you want to combine.

7. Click the list button ( ![icon][img1] ) next to **Add selection** at the bottom left, and select the option you want to use for combining the selections. The choice you make here is irrelevant for the first selection you add, so you can leave it at **All**.

8. Click the next list button ( ![icon][img1] ), and pick a selection.

9. Click the **Add selection** button. The selection is added to the list above.

10. You are now going to add selection number 2. Click the list button ( ![icon][img1] ) next to **Add selection** at the bottom left, and select the option you want to use for combining selection number 1 and selection number 2.
    * **All**: Displays all records from both selections 1 and 2.
    * **Only in Selection 1**: Displays records in selection 1, excluding those which are in both selection 1 and selection 2.
    * **Difference**: Displays only records which are either in selection 1 and or in selection 2 (but not in both).
    * **Common**: Displays only records which are in both selection 1 and selection 2.

11. Click the next list button ( ![icon][img1] ), and pick a selection.

12. Click the **Add selection** button. The selection is added to the list above.

13. To combine more selections, repeat steps 10-12 for each selection. If you combine more selections, it works as follows:

    * Selection number 3 will be combined with the combined result of selections 1 and 2.
    * Selection number 4 will be combined with the combined result of selections 1, 2 and 3.
    * And so forth.

    > [!TIP]
    > You can remove a selection from the combined selection by clicking **Delete** ( ![icon][img2] ) on the right of the row.

14. In the **Profile** tab, specify how the selection is to be presented:
   [!include[Contents of Selection Profile tab](../../includes/selection-profile-tab.md)]

15. Click **Execute** to display the result of the combined selection in the **Result** tab.

16. Click **OK**. The selection is saved, and you are returned to the **List selections** screen.

## What would you like to do now?

* [Update a selection](updateSelection.md)
* [View selections](listSelections.md)
* [Edit a selection](editSelection2.md)

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: ../../../../media/icons/btn-dropdown.png
[img2]: ../../../../media/icons/btn-delete.png
