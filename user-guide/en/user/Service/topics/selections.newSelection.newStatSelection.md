---
uid: help-en-selections-newselection-newstatselection
title: selections newSelection newStatSelection
description: selections newSelection newStatSelection
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Service
so.topic: help
language: en
---

# Create a static selection

You can find records and add them all, or some of them at a time, to a static selection. You can perform many searches in different tables and using different criteria, and select the records you want to include in the selection. When they are no longer relevant, you simply remove them from the selection.

A static selection contains only those records you have added to it manually, unlike a dynamic selection (see [Create a dynamic selection](selections.newSelection.newDynamicSelection.md)). Once you have created a static selection and added records to it, it will always contain the same records until you either add or remove some. A static selection works like a report in which you always have full control over the records.

To do this:

1. Select **Selections** &gt; **New selection**. This takes you to the **New selection** screen.

2. In the **Source table** field, select which type of records you want to include in the selection. For instance, if you want to create a selection of requests, select **Request**.

3. Click **Static selection**.

4. Click **Continue**. This takes you to the **Edit selection** screen.

5. In the **General info** tab, enter the following:
    * **Name**: Enter a descriptive name for the selection.
    * **ID string**: Here you can enter a unique identifier. In a web-based customer centre, you can refer to this ID string to make the selection available to customers.
    * **Folder**: If you have organised the selections into a folder structure (see [Administrate folders of selections](selections.editSelectionFolder.md)), click ![icon](../../media/btn-dropdown.png) and select a folder.
    * **Access**: In this list box, you select who is to have access to read and edit the selection.
    * **Show in left menu**: Check here if you want the name of the selection to appear under **Selections** in the Navigator.
    * **Field for parameter constraint**: This field can be used to enter a key or a filter in order to display a selection as a web panel.

6. In the **Selection** tab, specify the search criteria you want for the selection. You can read more about search criteria under [Search in SuperOffice Service](rms.search.md).

7. Click the **Search** button to start the search.

8. When the search result appears, check the records you want to include in the selection.

9. Click the ![icon](../media/btn-Menu.png) menu button in the lower left corner and select ![icon](../media/btn-add.png)**Add to selection**. The selected records are moved to the **Result** tab.

10. Repeat steps 6-9 to add more records. Click the **Show criteria** button to access the search fields.

    > [!TIP]
    > To remove entries from the selection, select the relevant entries in the **Result** tab, click the ![icon](../media/btn-Menu.png) menu button in the lower left corner, and select ![icon](../media/btn-delete.png)**Remove from selection** button.

11. In the **Profile** tab, specify how the selection is to be presented:
    * **Entries per page**: In this list box, you specify how many records are to be displayed per page.
    * Under **Columns**, you can choose which columns are displayed in the selection, as well as their order. See [Manage columns in selections](selections.editSelection2.editProfile.md).
    * Under **Sample table** you can see what the selection will look like with the current settings.

12. Click **OK**. The selection is saved, and you are returned to the **List selections** screen.

## What would you like to do now?

[Update a selection](selections.updateSelection.md)

[View selections](selections.listSelections.md)

[Edit a selection](selections.editSelection2.md)
