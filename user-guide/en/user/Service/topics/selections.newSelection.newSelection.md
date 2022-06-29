---
uid: help-en-selections-newselection-newselection
title: selections newSelection newSelection
description: selections newSelection newSelection
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Service
so.topic: help
language: en
---

# Create a selection based on search criteria

The simplest way to create a selection is to base it on a search. This creates a dynamic selection. <!-- Fix reuse ID=a1 --> Proceed as follows:

A dynamic selection can be compared to a saved search that is executed each time you view the selection. Each time you add a record that fulfils the search criteria in a dynamic selection, the selection will be updated with the new record, unlike a static selection. You could, for example, create a dynamic selection containing all requests belonging to a specific category and which have a high priority. See [Create a dynamic selection](selections.newSelection.newDynamicSelection.md).

Open the search screen. <!-- Fix reuse ID=a2 -->

* You can select **Requests** &gt; **Find requests** to search for requests. See <a href="../../topics/ticket.listTickets.findTickets" target="_top">Search for requests</a>.
* You can use predefined lists to search for requests. See <a href="../../topics/ticket.listTickets.useLists" target="_top">Use lists</a>.
* You can select **Customers** &gt; **Find contacts** or **Find companies** to search for contacts and companies.
* In the knowledge base, you can click the **Search** icon ( ![icon](../media/search.png) ) to the right of a folder name to search for different types of content.

Enter or adjust the criteria as described under [Search in SuperOffice Service](rms.search.md).

Click ![icon](../media/btn_Menu.png) &gt; **Save as selection**. The **Edit selection** screen is displayed.

In the **General info** tab, enter the following:

* **Name**: Enter a descriptive name for the selection.
* **ID string**: Here you can enter a unique identifier. In a web-based customer centre, you can refer to this ID string to make the selection available to customers.
* **Folder**: If you have organised the selections into a folder structure (see [Administrate folders of selections](selections.editSelectionFolder.md)), click ![icon](../../media/btn_dropdown.png) and select a folder.
* **Access**: In this list box, you select who is to have access to read and edit the selection.
* **Show in left menu**: Check here if you want the name of the selection to appear under **Selections** in the Navigator.
* **Field for parameter constraint**: This field can be used to enter a key or a filter in order to display a selection as a web panel.

In the **Selection** tab you can view the search criteria specified for the selection. If necessary, adjust the criteria as described under [Search in SuperOffice Service](rms.search.md).

In the **Profile** tab, specify how the selection is to be presented:

* **Entries per page**: In this list box, you specify how many records are to be displayed per page.
* Under **Columns**, you can choose which columns are displayed in the selection, as well as their order. See [Manage columns in selections](selections.editSelection2.editProfile.md).
* Under **Sample table** you can see what the selection will look like with the current settings.

Click **OK**. The selection is saved, and you are returned to the **List selections** screen. From here you can, for example, update the selection.

## What would you like to do now?

[Update a selection](selections.updateSelection.md)

[View selections](selections.listSelections.md)

[Edit a selection](selections.editSelection2.md)
