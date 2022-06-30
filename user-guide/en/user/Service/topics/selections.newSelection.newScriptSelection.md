---
uid: help-en-selections-newselection-newscriptselection
title: selections newSelection newScriptSelection
description: selections newSelection newScriptSelection
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Service
so.topic: help
language: en
---

# Create a script-based selection

> [!NOTE]
> This feature requires the SuperOffice Expander Services licence.

In a script-based selection, you define a data selection using a CRMScript, which offers almost unlimited possibilities for advanced calculations and criteria for defining the selection. You can order a script tailored to your company's needs from SuperOffice or a SuperOffice partner. You can also create a CRMScript yourself. See the [CRMScript documentation][1].

Assuming you already have a script to use as a basis, a script-based selection is created as follows:

1. Select **Selections** &gt; **New selection**. This takes you to the **New selection** screen.
2. In the **Source table** field, select which type of records you want to include in the selection. For instance, if you want to create a selection of requests, select **Request**.
3. Check **Script-based selection**.
4. Click **Continue**. This takes you to the **Edit selection** screen.
5. In the **General info** tab, enter the following:
    * **Name**: Enter a descriptive name for the selection.
    * **ID string**: Here you can enter a unique identifier. In a web-based customer centre, you can refer to this ID string to make the selection available to customers.
    * **Folder**: If you have organised the selections into a folder structure (see [Administrate folders of selections](selections.editSelectionFolder.md)), click ![icon](../../media/btn-dropdown.png) and select a folder.
    * **Access**: In this list box, you select who is to have access to read and edit the selection.
    * **Show in left menu**: Check here if you want the name of the selection to appear under **Selections** in the Navigator.
    * **Field for parameter constraint**: This field can be used to enter a key or a filter in order to display a selection as a web panel.
6. In the **Selection** tab, paste the script into the text field.
7. In the **Profile** tab, specify how the selection is to be presented:
    * **Entries per page**: In this list box, you specify how many records are to be displayed per page.
    * Under **Columns**, you can choose which columns are displayed in the selection, as well as their order. See [Manage columns in selections](selections.editSelection2.editProfile.md).
    * Under **Sample table** you can see what the selection will look like with the current settings.
8. Click **Execute** to display the result of the script-based selection in the **Result** tab.
9. Click **OK**. The selection is saved, and you are returned to the **List selections** screen.

## What would you like to do now?

[Update a selection](selections.updateSelection.md)

[View selections](selections.listSelections.md)

[Edit a selection](selections.editSelection2.md)

<!-- Referenced links -->
[1]: ../../../../../docs/automation/crmscript/index.yml

<!-- Referenced images -->
