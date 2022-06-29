---
uid: help-en-creating-combined-selections
title: Creating combined selections
description: Creating combined selections
author: SuperOffice RnD
so.date: 06.29.2022
keywords: CRM
so.topic: help
language: en
---

# Create combined selections

To create a new combined selection:

1. Open one of the selections you want to combine.

2. Click the **Task** button and select **Combine selection with**. A new selection screen opens.

3. Type the name of the new selection in the field containing ***Selection name***. This field is mandatory.

4. In the **Selection of** field, choose what the selection is to contain. The choices here are limited to **Company/contact** and the type of selection you have selected. You cannot change this once it has been saved to the database.

5. In the **Selection is** field, **Combined** has been selected by default.

6. Under **Selection 2**, choose the other selection you want to combine.

    > [!NOTE]
    > If you selected **Companies/contacts** under **Selection of**, you can choose from all types of selection here (a sales selection also contains companies/contacts related to the sales). But if the combined selection comprises Sales, Projects, Documents, Follow-ups, Requests, Form submissions, Chat conversations, Mailings or Products, you can only choose the same type of selections for **Selection 1** and **Selection 2**.

7. Under **Compare**, select which entries from the two selections to include in the combined selection.  
    <!-- Fix reuse ID=a2 -->
    <table>
    <tbody>
    <tr>
    <td>![icon](../media/selection-comb-onlyin1.png)</p></td>
    <td>Only in Selection 1</p></td>
    <td>Shows entries that are in selection 1, and excludes entries that are in both selection 1 and selection 2.</p></td>
    </tr>
    <tr>
    <td>![icon](../media/selection-comb-onlyin2.png)</p></td>
    <td>Only in Selection 2</p></td>
    <td>Shows entries that are in selection 2, and excludes entries that are in both selection 1 and selection 2.</p></td>
    </tr>
    <tr>
    <td>![icon](../media/selection-comb-common.png)</p></td>
    <td>Common</p></td>
    <td>Shows only entries that are in both selection 1 and selection 2.</p></td>
    </tr>
    <tr>
    <td>![icon](../media/selection-comb-diff.png)</p></td>
    <td>Difference</p></td>
    <td>Shows only entries that are either in selection 1 or in selection 2.</p></td>
    </tr>
    <tr>
    <td>![icon](../media/selection-comb-all.png)</p></td>
    <td>All</p></td>
    <td>Shows only entries in selection 1 and selection 2.</p></td>
    </tr>
    </tbody>
    </table>

8. The **Owner** field automatically displays the user currently logged in. After you have saved a new selection, you can change the owner by [editing the selection](Editing-Selections.md). In practice, this means that you transfer it from yourself to someone else. In order to edit a selection, you must either be the owner or have administrator access, or you must have been given editing access via the **Functions** preference in SuperOffice Settings and maintenance.

9. In the **Category** field, choose the type of selection you require. These options are defined in SuperOffice Settings and maintenance.

10. In the **Visible for** field, choose whether the selection will be visible to everyone, private (i.e. only visible to the person defined as owner) or visible to everyone in the user group that the owner belongs to.

11. Add a description of the selection in the **Description** field, if relevant.

12. Check **Completed** if you want to specify that the selection is inactive. If you want the selection to be active, leave this box unchecked.

13. To add the selection to favourites, click the star icon ![icon](../../Service/media/favourite-inactive.png). The star turns yellow ![icon](../../Service/media/favourite-active.png), and the selection is instantly added to favourites. Now you can quickly access the selection by clicking ![icon](../../media/navmenu-favourites.png) from the Navigator menu.

14. Click **Save** to save the selection in the database.  
    Once the selection has been saved, you can [edit it](Editing-Selections.md) to change both the combination type and which selections are combined. But it is not possible to change the **Selection of** field.

## Related topics

[Create selections](Create-selections.md)

[Perform tasks using selections](Performing-tasks-using-selections.md)
