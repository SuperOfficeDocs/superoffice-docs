---
uid: help-en-project-guide-edit
title: Edit or deactivate project guide
description: Learn how to edit or deactivate project guides in SuperOffice CRM. Modify statuses, follow-ups, and documents, or disable guides for specific project types while retaining flexibility for reactivation.
keywords: edit project guide, update project guide, deactivate project guide, project guide, guide, workflow, project
author: Bergfrid Dias
date: 01.03.2025
version: 10
topic: howto
license: salespremium, servicepremium, marketingessentials
audience: settings
audience_tooltip: Settings and maintenance
language: en
---

# Edit or deactivate project guide

[!include[Must be admin](../../learn/includes/req-admin.md)]

## Edit a project guide

1. Select <i class="ph ph-arrows-left-right" aria-hidden="true"></i> **Workflow** in the Navigator.
1. Select the **Project guide** tab.
1. Select the required project type from the list at the top.
1. [Edit information on the project type and its statuses][3].
1. [Edit the individual statuses][3].
1. Edit follow-ups and documents by double-clicking them in the lists at the bottom.

    * [Add a follow-up for a status][2]
    * [Add a document for a status][1]

    The changes are saved automatically.

## Deactivate a project guide

To remove a project guide from a [project type][4], follow these steps:

1. Select <i class="ph ph-list-bullets" aria-hidden="true"></i> **Lists** in the Navigator.

1. Select **Project - Type, Status** from the dropdown menu. The **Items** tab displays all existing project types.

1. Double-click the project type linked to the guide you want to deactivate. The **Edit list item** dialog opens.

1. Uncheck **This project type is linked to a guide**.

1. (Optional) Update other fields as needed.

1. Click **Save** to apply your changes or **Cancel** to discard them.

> [!NOTE]
> If you later want to reuse the project guide, recheck the option. Any follow-ups and documents previously added to the project guide's statuses will be automatically retrieved when reactivated. You can also add new follow-ups or documents, or remove any that are no longer relevant.

<!-- Referenced links -->
[1]: create-project-guide.md#add-doc-status
[2]: create-project-guide.md#add-fo-status
[3]: project-status.md
[4]: project-type.md
