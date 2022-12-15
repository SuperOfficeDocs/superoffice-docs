---
uid: help-en-selections-static-create-service
title: Create a static selection
description: How to create a static selection in Service.
author: SuperOffice RnD
so.date: 06.29.2022
keywords: selection, static
so.topic: howto
language: en
---

# Create a static selection

You can find records and add them all, or some at a time, to a static selection. You can perform many searches in different tables and using different criteria, and select the records you want to include in the selection. When they are no longer relevant, you simply remove them from the selection.

A static selection contains only those records you added to it manually, unlike a [dynamic selection][1]. Once you create a static selection and added records to it, it will always contain the same records until you either add or remove some. A static selection works like a report where you always have full control over the records.

1. Select **Selections** > **New selection**. This takes you to the **New selection** screen.

2. In the **Source table** field, select which type of records you want to include in the selection. For instance, to create a selection of requests, select **Request**.

3. Click **Static selection**.

4. Click **Continue**. This takes you to the **Edit selection** screen.

5. In the **General info** tab, enter the following:

    [!include[Contents of Selection General info tab](includes/selection-general-info.md)]

6. In the **Selection** tab, specify the [search criteria you want for the selection][2].

7. Click the **Search** button to start the search.

8. When the search result appears, check the records you want to include in the selection.

9. Click the ![icon][img3] menu button in the lower left corner and select ![icon][img1] **Add to selection**. The selected records are moved to the **Result** tab.

10. Repeat steps 6-9 to add more records. Click the **Show criteria** button to access the search fields.

    > [!TIP]
    > To remove entries from the selection, select the relevant entries in the **Result** tab, click the ![icon][img3] menu button in the lower left corner, and select ![icon][img2] **Remove from selection** button.

11. In the **Profile** tab, specify how the selection should be presented:
    [!include[Contents of Selection Profile tab](includes/selection-profile-tab.md)]

12. Click **OK**. The selection is saved, and you are returned to the **List selections** screen.

## What would you like to do now?

* [Update a selection][3]
* [View selections][4]
* [Edit a selection][5]

<!-- Referenced links -->
[1]: create-dynamic.md
[2]:../../in-service/index.md
[3]: update.md
[4]: list.md
[5]: edit.md

<!-- Referenced images -->
[img1]: ../../../..../media/icons/btn-add.png
[img2]: ../../../../..../common/icons/delete-red.png
[img3]: ../../../..../media/icons/btn-menu.png
