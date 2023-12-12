---
uid: help-en-basics-delete
title: Deleting elements
description: How to merge, delete and restore elements.
author: SuperOffice RnD
so.date: 03.07.2023
keywords: delete, restore, recycle bin
so.topic: howto
language: en
---

# Delete and restore items

To be efficient in the work with customers and contacts, it is vital to have a clutter free environment. When you add new companies and contacts, double check that they are not added before. And off course, make sure you add correct information on companies and contacts. Also, delete unused companies and contacts and merge duplicates.

## Merge companies and contacts

If you find duplicated information, merge them as soon as possible to make sure that it is easier to find the correct company and contact. You can also move a contact if they are added on the wrong company card. This is to prevent duplicates in the future.

> [!NOTE]
> This functionality requires user rights, so contact your administrator to get sufficient functional rights.

**How-tos:**

* [Merge contacts][4]
* [Move contact][5]
* [Merge companies][1]

## Delete company and contacts

When you have added wrong or duplicated information, it may be a good idea to delete a contact. There are several ways to do this:

* [Delete a company and associated data][2]
* [Delete a contact][3]
* [Bulk delete contacts and/or companies with selection][6]

When you choose to delete something in SuperOffice CRM, the dialog displays **Delete Follow-up**, **Delete Sale**, **Delete Selection** and so on, depending on what you have chosen to delete. The name of the item is displayed in the dialog, so that you can check that you have made the right choice.

When you have many contacts or companies you have to delete, the best way to mass delete them, is to add them into a new selection, and use the Delete tasks on the Task menu. On the selection, click on the Task button and select one of the wanted Delete functions.

### Why is the Delete button disabled (grey)?

If the **Delete** button is disabled (light grey), it means that you have no rights to delete this particular item.

Examples:

* You cannot delete a contact who is also an employee in a SuperOffice company.
* You cannot delete follow-ups, documents, sales, projects, and so on that do not belong to you, unless you have sufficient user rights.

## <a id="restore" />Restore deleted companies and contacts

When you have deleted something that was not meant to be deleted, for companies and contacts, you can still restore them from your Recycle bin. This makes it less scary to delete, when you know you still have a restore option.

![You can restore deleted items from the Recycle bin in your Personal settings menu -screenshot][img3]

Deleted companies and contacts are by default kept in the recycle bin for 14 days. After this time, they are permanently deleted.

You also have an option to restore other users' deleted companies and contacts, just check View deleted companies for all users ON.

1. Choose ![icon][img1] **Personal settings** > **Recycle bin**.

2. In the dialog, select the **Company** or **Contact** tab. Companies and contacts deleted by you are displayed.

3. Optional: Select **View deleted companies/contacts for all users**. This option requires functional rights.

4. Select the companies or contacts you want to restore.
    * Restoring a company will also restore all contacts associated with this company.
    * Restoring a contact where the company too was deleted, will restore the company and the selected contact.

    ![Restoring companies and contacts from the Recycle bin -screenshot][img2]

5. Click **Restore**. The companies and contacts are restored in SuperOffice.

## Buttons

| Button | Effect |
|---|---|
| Yes | Confirms deletion of a single item at a time. |
| Yes to All | Confirms that you want to delete all selected items. If, for example, you selected five items for deletion, this button will delete them all automatically. |
| No | Cancels deletion of a single item at a time. The dialog is closed without deleting anything. |
| Cancel | Cancels deletion of all selected elements. The dialog is closed without deleting anything. |

* To suppress this dialog: Check **Do not show this dialog again** at the bottom of the delete dialog.
* To reactivate this dialog: Go to ![icon][img1] **Personal settings** > **Preferences** > **Functions** and set the **Show confirmation dialog** option to **No**.

> [!NOTE]
> When you delete a company, a selection or a project, you are always asked to confirm the deletion, and the **Do not show this dialog again** option is not available.

## Related content

* [Stop repeating follow-ups][6]
* [Mass delete contacts and companies from selection][7]
* [Find and selections][8]

<!-- Referenced links -->
[1]: ../../company/learn/merge-companies.md
[2]: ../../company/learn/delete.md
[3]: ../../contact/learn/delete.md
[4]: ../../contact/learn/merge-contacts.md
[5]: ../../contact/learn/move.md

[6]: ../../diary/learn/recurrence/stop.md
[7]: ../../search-options/selection/learn/howto/mass-delete.md
[8]: ../../search-options/selection/learn/index.md

<!-- Referenced images -->
[img1]: ../../../media/icons/personal-settings-small.png
[img2]: ../../../media/loc/en/learn/recycle-bin.png
[img3]: ../../../media/loc/en/learn/recycle-bin-personal-settings.png
