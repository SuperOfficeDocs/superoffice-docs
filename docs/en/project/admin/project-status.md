---
uid: help-en-project-status
title: Project status
description: Find out how to add a new project status in SuperOffice CRM. Create and manage predefined statuses to track project phases and streamline workflows efficiently.
keywords: add project status, project status, project
author: Bergfrid Dias
date: 02.11.2025
version: 10.5.2
topic: howto
license: salespremium, servicepremium, marketingessentials
audience: settings
audience_tooltip: Settings and maintenance
language: en
---

# Project status

[!include[Must be admin](../../learn/includes/req-admin.md)]

The **Status** field in the Project card helps categorize and track a project's progress. These statuses are predefined in the **Project - Status** list, which you can manage in **Settings and maintenance** under **Lists**.

Statuses can be linked to [project types][1], specifying which statuses are available for each type. If no project guide is defined, the **Status** field is still visible on the project, allowing users to view and update the project's current status.

## Add a status

1. Select <i class="ph ph-list-bullets" aria-hidden="true"></i> **Lists** in the Navigator.

1. Select **Project - Status** from the dropdown menu. The **Items** tab displays all existing statuses.

1. Click **Add** to open the **Edit list item** dialog.

1. In the **Name** field, enter the name of the new status. *(Mandatory)*

    This name will appear in the **Status** field on the Project card.

1. *(Optional)* Add a description in the **Description** field to explain the status's purpose.

1. Click **Save** to apply your changes or **Cancel** to discard them.

## Edit or delete a status

1. Follow steps 1–2 in **Add a Status** to access the **Project - Status** list.

1. To edit:
    1. Double-click the required status to open the **Edit list item** dialog.
    1. Update the fields as needed and click **Save**.

1. To delete:
   1. Select the status in the list and click **Delete**.

    > [!CAUTION]
    > Deleting a status removes it from all linked project types and project guides. Ensure it is not in active use before proceeding.

## Restore a deleted project status

If a project status has been deleted, you can restore it from the **Project - Status** list. However, restoring does not automatically reestablish any links between the restored item and related project types or guides. You must recreate these connections manually if needed.

The steps are similar to [restoring a deleted project type][2].

## Related content

* [Add or update project types][1]
* [Create a project guide][3]
* [Edit a project guide][4]
* [Move project to next status][5]

<!-- Referenced links -->
[1]: project-type.md
[2]: project-type.md#restore
[3]: create-project-guide.md
[4]: edit-project-guide.md
[5]: ../learn/project-guides.md#change-status

<!-- Referenced images -->
