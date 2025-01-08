---
uid: help-en-project-type
title: Project type
description: Learn how to create a new project type in SuperOffice CRM. Define names, set estimated durations, link statuses, and optionally associate project guides for streamlined project management.
keywords: add project type, project type, project
author: Bergfrid Dias
date: 01.03.2025
version: 10
topic: howto
license: salespremium, servicepremium, marketingessentials
audience: settings
audience_tooltip: Settings and maintenance
language: en
---

# Project type

[!include[Must be admin](../../learn/includes/req-admin.md)]

The **Type** field in the Project card categorizes projects and defines their workflows. These types are predefined in the **Project - Type, Status** list, which you can manage in **Settings and maintenance** under **Lists**.

Each project must have a type, and these types can be linked to specific [statuses][1] and, optionally, to [project guides][4]. Project guides streamline execution by guiding users through predefined phases, follow-ups, and documents.

## Add a project type

1. Select <i class="ph ph-list-bullets" aria-hidden="true"></i> **Lists** in the Navigator.

1. Select **Project - Type, Status** from the dropdown menu. The **Items** tab displays all existing project types.

1. Click **Add** to open the **Edit list item** dialog.

    ![Edit list item dialog showing fields for project type configuration -screenshot][img1]

1. Enter a name for the project type in the **Name** field. *(Mandatory)*

    This name will appear in the **Type** field on the Project card.

1. Specify the typical project duration in the **Estimated time for this project process** field (number of weeks, days or months).

    This determines the default end date when creating a project.

1. Select the required statuses in the **Statuses used for this project type** list.

    > [!NOTE]
    > To link the project type to a project guide, select at least two statuses.

1. (Optional) Check **This project type is linked to a guide** if you want projects of this type to follow a project guide.

1. (Optional) Check **Suggest moving the project to next status automatically** to prompt users to [move to the next status][5] when all activities in the current status are completed.

1. Add a description of the type in the **Description** field, if needed.

1. Click **Save** to apply your changes or **Cancel** to discard them.

    The project type is added to the **Items** list. Repeat these steps to add more project types.

## Edit or delete a project type

1. Follow steps 1–2 above to access the **Project - Type, Status** list.

1. To edit:
   * Double-click the required project type to open the **Edit list item** dialog.
   * Make the necessary changes and click **Save**.

1. To delete:
   * Select the project type in the list and click **Delete**.

    > [!CAUTION]
    > Deleting a project type also removes its link to statuses and project guides. Ensure it is not in active use before proceeding.

## <a id="restore"></a>Restore a deleted project type

If a project type has been deleted, you can restore it from the **Project - Type, Status** list. However, restoring does not automatically reestablish any links between the restored item and related project statuses or guides. You must recreate these connections manually if needed.

1. Go to the **Project - Type, Status** list.

1. Check **Show deleted items and headings** in the footer. Deleted items appear strike-through in the **Items** tab.

1. Double-click the deleted item you want to restore. The **Edit list item** dialog opens.

1. Click **Restore**.

1. Update any necessary fields and click **Save**. The item is now active and will appear in the **Items** tab.

## Related content

* [Add a project status][1]
* [Create a project guide][2]
* [Edit a project guide][3]

<!-- Referenced links -->
[1]: project-status.md
[2]: create-project-guide.md
[3]: edit-project-guide.md
[4]: ../learn/project-guides.md
[5]: ../learn/project-guides.md#change-status

<!-- Referenced images -->
[img1]: ../../../media/loc/en/project/edit-project-type.png
