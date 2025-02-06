---
uid: help-en-section-tab-projects
title: Projects tab
description: Learn how to view, add, and manage projects using the Projects section tab in SuperOffice CRM. Simplify project tracking across companies, contacts, and more.
keywords: projects tab, section tab, project archive
author: Bergfrid Skaara Dias
date: 01.29.2025
version: 10.5
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: en
---

# Projects tab

The **Projects** section tab in SuperOffice CRM allows users to view and manage [project information][1] related to specific entities such as companies and contacts. This guide provides a unified overview of how to access and interact with project records, enhancing the ability to track and manage project activities effectively.

![Projects section in company -screenshot][img1]

## Availability of the Projects section tab

The **Projects** section tab is available for:

| Entity | Description of the Projects section tab |
|---|---|
| [Company][9] | Displays all projects linked to the company. At least one employee must be registered as a project member. |
| [Contact][10] | Shows projects where the contact is a project member. |

## <a id="columns"></a>Projects tab columns overview

The **Projects** section tab contains the following columns to display key information about each project:

| Column | Description |
|---|---|
| Completed | Checkbox indicating if the project is completed. A ticked checkbox (<i class="ph ph-check" aria-hidden="true"></i>) means completed, while an empty box means it is ongoing. |
| Project name | The name of the project. |
| Project type | Specifies what type of project it is, such as internal or customer-facing. |
| Status | The current status of the project. |
| Project number | The unique identifier assigned to the project. |
| Description | Displays any description of the project. Hover over the paperclip icon to see the full text. |
| Web link | A URL associated with the project, if applicable. |
| User ID | The user who created the project. |

[!include[Conf. columns](../includes/tip-configure-columns.md)]

## View projects in the Projects section tab

1. Go to the relevant screen, such as Company or Contact.

1. Click on the **Projects** tab to see all projects linked to the entity.

1. Double-click a project in the list to open the Project screen and view detailed information.

### Filter projects

You can [filter the list of projects][8] by date, user, or group by clicking the Filter button. This helps focus on specific project activities that need attention.

## Add project members

To [add project members][4] directly from the **Projects** section tab:

1. Select **Add to project** to open the **Add/edit project members** dialog.

1. Complete the required fields and click **Save**.

## Additional tips

* **Quick navigation:** Use the [Navigator][7] to quickly switch between different entities and their corresponding **Projects** tabs.

## Related content

* [How to add a project][2]
* [Filter projects][8]
* [Group columns and summarize amounts][5]

<!-- Referenced links -->
[1]: ../../project/learn/index.md
[2]: ../../project/learn/create.md
[4]: ../../project/learn/project-members/add.md
[5]: configure-columns.md#calculate
[7]: ../getting-started/main-screen/navigator.md
[8]: filter.md
[9]: ../../company/learn/index.md#section-tabs
[10]: ../../contact/learn/index.md#section-tabs

<!-- Referenced images -->
[img1]: ../../../media/loc/en/company/projects-detail.png
