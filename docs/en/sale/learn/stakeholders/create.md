---
uid: help-en-stakeholder-create
title: Add stakeholders
description: How to link a sale to a stakeholder (company or contact) in SuperOffice.
keywords: Add stakeholder, new stakeholder Add/edit stakeholders dialog, Stakeholders section tab, stakeholder, sale
author: Bergfrid Dias
date: 01.08.2025
version: 10.5
topic: howto
license: salespremium
audience: person
audience_tooltip: SuperOffice CRM
language: en
---

# Add stakeholders

When adding stakeholders to a sale, you can either assign roles individually as you add contacts/companies, assign roles after adding all stakeholders, or use a combination of both methods.

A company/contact can be added as a stakeholder multiple times, provided different roles are specified each time.

## Steps

1. Open the sale (see [Use the Find screen][1]) and go to the **Stakeholders** section tab.

1. Click **Add** below the section tab. The **Add/edit stakeholders** dialog opens.

1. Click the **Company/Contact** list to add stakeholders. You have several options:

    * Search: Type at least two characters to search for a contact or company.

    * History/Favorites: Select from the history list or favorites.

      ![Add/edit stakeholders dialog, history -screenshot][img5]

    * User group: Click <i class="ph ph-users" aria-label="Associate icon"></i> to browse associates by group.

      ![Add/edit stakeholders dialog, group -screenshot][img6]

    * Company: Click <i class="ph ph-arrow-circle-right" aria-label="Arrow right"></i> to browse contacts by company or add a company as a stakeholder.

      ![Add/edit stakeholders dialog, company -screenshot][img7]

1. **Set roles**: Select a stakeholder and assign a role. To assign the same role to multiple stakeholders at once, use **Select All** or hold Ctrl/Shift while selecting.

    ![Add/edit stakeholders dialog, role -screenshot][img8]

    Optionally, add a comment to describe the stakeholder's role in more detail.

1. Click **Save**.

## Troubleshooting

* **Missing section tab:** If the **Stakeholders** tab is not visible, ensure that this [sale type has stakeholders][4] enabled in Settings and maintenance.

* **Missing person:** If a stakeholder is not listed, [create the contact][3] first.

* **Missing roles:** [Stakeholder roles][5] are defined in Settings and maintenance.

## Tips

* **Add Stakeholders via Company or Selection Screens**

    You can also [add stakeholders via the section tabs][2] containing contacts in the Company and Selection screens.

* **Add comments**

    If a comment is added, a paperclip (<i class="ph ph-paperclip" aria-hidden="true"></i>) will appear next to the **Sales role** column in the **Stakeholders** tab. Hover over the paperclip to see the comment tooltip.

<!-- Referenced links -->
[1]: ../../../search-options/learn/find-screen.md
[2]: ../../../project/learn/project-members/add.md
[3]: ../../../contact/learn/create.md
[4]: ../../admin/sale-type.md
[5]: ../../../admin/lists/learn/editing-items.md

<!-- Referenced images -->
[img5]: ../../../../media/loc/en/sale/add-stakeholders-from-history.png
[img6]: ../../../../media/loc/en/sale/add-stakeholders-from-group.png
[img7]: ../../../../media/loc/en/sale/add-stakeholders-from-company.png
[img8]: ../../../../media/loc/en/sale/set-stakeholder-role.png
