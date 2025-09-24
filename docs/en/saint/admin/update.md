---
uid: help-en-saint-update
title: Update activity monitors
description: Update activity monitors
keywords: SAINT, activity monitor, default follow-up type, delete status monitor, restore status monitor, regenerate status monitor, regenerate counter
author: SuperOffice Product and Engineering
date: 09.22.2025
version: 10.5
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: en
index: true
redirect_from: 
  - /en/sale/saint/learn/admin/edit-status
  - /en/saint/admin/edit-status
  - /en/sale/saint/learn/admin/select-default-follow-up-type-for-status
  - /en/saint/admin/select-default-follow-up-type-for-status
  - /en/sale/saint/learn/admin/restore-status
  - /en/saint/admin/restore-status
  - /en/sale/saint/learn/admin/select-status-criteria
  - /en/saint/admin/select-status-criteria
  - /en/sale/saint/learn/admin/manage-status-monitors
  - /en/saint/admin/manage-status-monitors
---

# Update activity monitors

[!include[Requirement](../includes/note-saint-req.md)]

## Open the SAINT screen

Before performing any of the following tasks, open the **SAINT** screen in Settings and maintenance and select the **Company**, **Contact**, or **Project** tab.

## Edit a status description

The **Description** tab shows the description you entered when you [created the status][1].

1. In the status list, select the status for which you want to edit the description.

1. Edit the text in the **Description** tab.

## Select a default follow-up type for a status

You can link a follow-up type to a status. When a user clicks the center of the status card, a follow-up opens automatically. This can include prefilled text that explains what action to take for companies, contacts, or projects with this status.

To specify a default follow-up type and description, use the **Create follow-up** tab.

1. In the status list, select the required status.
1. Go to the **Create follow-up** tab.
1. Select a follow-up type from the **Type** dropdown.
1. Enter the message that will appear in the follow-up dialog.

![The 'Create follow-up' tab in the SAINT status monitor, showing follow-up type selection and custom message entry. -screenshot][img1]

## <a id="criteria"></a>Add criteria to a status

Each status must have at least one criterion. The [criteria][2] determine which companies, contacts, or projects the status applies to.

1. In the status list, select the required status.

1. Below the criteria list, select **Add** to insert a new row.

1. Select a criterion type from the dropdown.

    ![Criteria list with multiple conditions defined and the Add button below the list -screenshot][img3]

1. Set the condition (such as **Before**, **After**, or **Equals**), and enter a value.

1. Repeat to add more criteria.

    > [!NOTE]
    > You can add only one of each criterion type. For example, you cannot add the **Postcode** criterion twice.

1. Select <i class="ph ph-arrow-circle-right" aria-hidden="true"></i> **Regenerate selected status monitor** to apply the changes.

## <a id="delete"></a>Delete a status monitor

You can delete a status from the status monitor list. Deleted statuses can be restored later.

1. In the status list, select the status you want to delete.
1. Click **Delete** at the bottom of the list.

The deleted status is removed from the active list but can be shown again by selecting **Show deleted**.

## <a id="restore"></a>Restore a deleted status monitor

You can restore a previously deleted status and regenerate it.

1. At the bottom of the status list, select **Show deleted**.

1. Double-click the status you want to restore.

    ![Status monitor dialog open after selecting a deleted status, with Restore and Save buttons visible -screenshot][img2]

1. In the **Status monitor** dialog, select **Restore**, then select **Save**.

    The status is restored and displayed in black text in the list.

1. Select **Regenerate selected status monitor** to update the restored status.

## <a id="regen"></a>Regenerate statuses and counters <i class="ph ph-arrow-circle-right" aria-hidden="true"></i>

At the bottom of the **Status monitors** tab, indicators show the date of the most recent update. A red cross in the status list means the status is not active until you regenerate it. If an item has never been generated, or the last generation was a long time ago, the results may be outdated.

Statuses and counters that are not updated remain visible in SuperOffice CRM, but the data may be incorrect. You should regenerate whenever criteria change, you have edited an intention for a task, or when the indicators suggest the data is stale.

### Regenerate statuses

| Name | Description | Location |
|---|---|---|
| Regenerate selected status monitor | Updates the selected status | Bottom of the **Company**, **Contact**, or **Project** tab |
| Regenerate all status monitors | Updates all statuses | Bottom of the **Status monitors** tab |

### Regenerate counters

| Name | Description |
|---|---|
| Regenerate all counters | Updates all counters |

<!-- Referenced links -->
[1]: set-up.md
[2]: ../../search-options/learn/search-criteria.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/saint/saint-create-follow-up-tab.png
[img2]: ../../../media/loc/en/saint/delete-restore-status-monitor.png
[img3]: ../../../media/loc/en/saint/criteria.png
