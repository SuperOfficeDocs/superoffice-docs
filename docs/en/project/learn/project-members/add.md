---
uid: help-en-project-member-add
title: Add project members
description: How to add a project member in SuperOffice
keywords: add project member, new project member, Add/edit project members dialog, project member, project
author: Bergfrid Dias
date: 01.06.2025
version: 10.3.12
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: en
---

# Add project members

To link a project to a company, at least one project member must be specified. You can do this on the Project screen or [via the section tabs](#from-section-tab) for contacts in the Company, Selection, or Sale screens.

When adding members to a project, you can assign functions individually as you add contacts/companies, assign functions afterward, or use a combination of both methods.

## Steps

1. Open the project (see [Use the Find screen][1]) and go to the **Project members** section tab.

1. Click **Add** below the section tab. The **Add/edit project members** dialog opens.

1. Click the **Company/Contact** list to add members. You have several options:

    * Search: Type at least two characters to search for a contact or company.

    * History/Favorites: Select from the history list or favorites.

      ![Add/edit project members dialog, history -screenshot][img5]

    * User group: Click <i class="ph ph-users" aria-label="Associate icon"></i> to browse associates by group.

      ![Add/edit project members dialog, group -screenshot][img6]

    * Company: Click <i class="ph ph-arrow-circle-right" aria-label="Arrow right"></i> to browse contacts by company or add a company as a member.

      ![Add/edit project members dialog, company -screenshot][img7]

1. **Set functions**: Select a project member and assign a function. To assign the same function to multiple members at once, use **Select All** or hold Ctrl/Shift while selecting.

    ![Add/edit project members dialog, function -screenshot][img8]

    Optionally, add a comment to describe the project member's function in more detail.

1. Click **OK**.

## <a id="from-section-tab"></a>Add project members and stakeholders from section tabs

You can add project members and stakeholders from the contact lists in different section tabs, for example **Company** (**Contacts**), **Selection** (**Company/Contact**), **Sale** (**Stakeholders**) and **Project** (**Project members**). Thus procedure below can also be performed from the **Result** tab in the [Find screen][1].

**Steps:**

1. Go to the required section tab or the **Find** screen.

2. Select the required contact on the list.

    > [!NOTE]
    > To add several contacts as stakeholders/project members, use **Shift** or **Ctrl** + click.

3. Right-click the contacts and select **Add to sale** or **Add to project** on the menu that appears.

4. In the **Sale** or **Project** field, specify which sale/project to add the contacts to. Do this either by clicking the arrow and selecting the required sale/project in the displayed list box, or by typing in the whole or the beginning of the sale/project name.

5. In the **Sales role** or **Function** field, specify the sales role/function each person has in the sale/project. Click the arrow to display a list of predefined alternatives to choose from.

6. Click **Save**.

## Troubleshooting

* **Missing person:** If a person is not listed, [create the contact][3] first.

* **Missing roles:** Available [functions][5] are defined in Settings and maintenance.

## Tips

* **Add comments**

    If a comment is added, a paperclip (<i class="ph ph-paperclip" aria-hidden="true"></i>) will appear next to the **Project member information** column in the **Project members** tab. Hover over the paperclip to see the comment tooltip.

<!-- Referenced links -->
[1]: ../../../search-options/learn/find-screen.md
[3]: ../../../contact/learn/create.md
[5]: ../../../admin/lists/learn/editing-items.md

<!-- Referenced images -->
[img5]: ../../../../media/loc/en/project/add-project-member-from-history.png
[img6]: ../../../../media/loc/en/project/add-project-member-from-group.png
[img7]: ../../../../media/loc/en/project/add-project-member-from-company.png
[img8]: ../../../../media/loc/en/project/set-project-member-function.png
