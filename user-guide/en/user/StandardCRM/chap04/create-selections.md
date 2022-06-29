---
uid: help-en-create-selections
title: Create selections
description: Create selections
author: SuperOffice RnD
so.date: 06.29.2022
keywords: CRM
so.topic: help
language: en
---

# Create selections

The first thing you must do when creating a new static or dynamic selection, is to find the data you want to included in the selection via the **Find** screen.

See also [Create combined selections](Creating-combined-selections.md).

To create a new static or dynamic selection:

1. Click **New** on the Top bar and select **Selection**.  
    The **Find** screen opens.

2. Click the **Find** option that is relevant for the data type you want to use in your selection. You can also click **Typical searches** to use pre-defined searches.

3. Add your search criteria in the **Criteria** tab as described in [Use search criteria](../chap01/Using-search-criteria.md).

4. Click **Find**. The **Results** tab displays the data matching your criteria.

5. If you want to save the results in a selection, click **Save as selection**. If not, refine your search criteria.

6. In the **Save as selection** dialog, select one of the following options:
    * **Dynamic selection**: This type of selection will always be updated with members that match the selection criteria.
    * **Static selection**: This type of selection will contain only the members you have added manually.
    * **Add to existing static selection**: Use this option to add additional members to an existing static selection.

7. Click **Save**.

8. Type the name of the new selection where ***Selection name*** appears. This field is mandatory.  
    If you try to create a selection with the same name as an existing selection, the **Duplicates** dialog opens. This works in the same way as for companies. For more details, see [Duplicates](../chap01/Duplicates.md).

9. In the **Selection is** field, you can change to another type of selection if necessary.

10. The **Owner** field automatically displays the user currently logged in. After you have saved a new selection, you can change the owner by [editing the selection](Editing-Selections.md). In practice, this means that you transfer it from yourself to someone else. To be able to edit a selection, you must own it, or have administrator access, or have been given editing access in SuperOffice Settings and maintenance.

11. In the **Category** field, choose the type of selection you require. Click the arrow to display a predefined list of alternatives.

12. In the **Visible for**, choose whether the selection will be visible to everyone, private (i.e. only visible to the person defined as owner) or visible to everyone in the user group that the owner belongs to.

13. Add a description of the selection in the **Description** field, if relevant.

14. Check **Completed** if you want to specify that the selection is inactive. If you want the selection to be active, leave this box unchecked.

15. To add the selection to favourites, click the star icon ![icon](../../Service/media/favourite-inactive.png). The star turns yellow ![icon](../../Service/media/favourite-active.png), and the selection is instantly added to favourites. Now you can quickly access the selection by clicking ![icon](../../media/navmenu-favourites.png) from the Navigator menu.

16. When you have finished defining the core data for the selection, click **Save** to save.

17. The screen now displays the following tabs:

* [The list of members](The-List-of-Members.md): All selection types except **Company/contact** will have two tabs containing selection data. Selection members can be projects, sales, documents, requests, follow-ups, form submissions, chat conversations, mailings or products.
* [Company/contact](selection-tab-Company-contact.md): The **Company/contact** tab contains companies and contacts linked to list of members. Example: All contacts or companies linked to the sales in a selection.
* [Criteria](selection-tab-Criteria.md): Here you can edit the criteria for a dynamic selection.
* [Details](selection-tab-Details.md): Here you can edit general information for a selection.
* [Charts](Display-selections-as-charts.md): Here you can view the selection data in a chart. Charts of selections can also be used in [dashboards](../Dashboard/Dashboard-Create.md).
* [Mailings](Mailings-section-tab.md): Here you can create a mailing to contacts in a selection. You can also see the mailings that have been archived on this selection.

> [!TIP]
> Click ![icon](../../media/btn-columnheaderoptions.png) on the far right of the column headers in a selection. Here you can group and filter records, and add/remove columns. These settings can be saved for the active selection by selecting **Save columns for current selection only**. See also [The section tabs](../chap01/The-Section-tabs.md) for additional functions.

## Related topics

[Perform tasks using selections](Performing-tasks-using-selections.md)

[Create combined selections](Creating-combined-selections.md)
