---
uid: help-en-selections-newselection-newdynamicselection
title: selections newSelection newDynamicSelection
description: selections newSelection newDynamicSelection
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Service
so.topic: help
language: en
---

# Create a dynamic selection

A dynamic selection can be compared to a saved search that is executed each time you view the selection. Each time you add a record that fulfils the search criteria in a dynamic selection, the selection will be updated with the new record, unlike a static selection. You could, for example, create a dynamic selection containing all requests belonging to a specific category and which have a high priority. See [Create a dynamic selection](selections.newSelection.newDynamicSelection.md).

> [!TIP]
> You can also create a dynamic selection based on search criteria. See [Create a selection based on search criteria](selections.newSelection.newSelection.md).

To do this:

1. Select **Selections** &gt; **New selection**. This takes you to the **New selection** screen.
2. In the **Source table** field, select which type of records you want to include in the selection. For instance, if you want to create a selection of requests, select **Request**.
3. Check **Dynamic selection**.
4. Click **Continue**. This takes you to the **Edit selection** screen.
5. In the **General info** tab, enter the following:
    * **Name**: Enter a descriptive name for the selection.
    * **ID string**: Here you can enter a unique identifier. In a web-based customer centre, you can refer to this ID string to make the selection available to customers.
    * **Folder**: If you have organised the selections into a folder structure (see [Administrate folders of selections](selections.editSelectionFolder.md)), click ![icon](../../media/btn_dropdown.png) and select a folder.
    * **Access**: In this list box, you select who is to have access to read and edit the selection.
    * **Show in left menu**: Check here if you want the name of the selection to appear under **Selections** in the Navigator.
    * **Field for parameter constraint**: This field can be used to enter a key or a filter in order to display a selection as a web panel.
6. In the **Selection** tab, specify the search criteria you want for the selection. You can read more about search criteria under [Search in SuperOffice Service](rms.search.md).
7. In the **Profile** tab, specify how the selection is to be presented:
    * **Entries per page**: In this list box, you specify how many records are to be displayed per page.
    * Under **Columns**, you can choose which columns are displayed in the selection, as well as their order. See [Manage columns in selections](selections.editSelection2.editProfile.md).
    * Under **Sample table** you can see what the selection will look like with the current settings.
8. Click **Execute** to display the result of the dynamic selection in the **Result** tab. If necessary, adjust the search criteria in the **Selection** tab and repeat this step.
9. Click **OK**. The selection is saved, and you are returned to the **List selections** screen.

## What would you like to do now?

[Update a selection](selections.updateSelection.md)

[View selections](selections.listSelections.md)

[Edit a selection](selections.editSelection2.md)
