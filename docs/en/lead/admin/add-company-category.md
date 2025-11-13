---
uid: help-en-add-company-category
title: Company category and category group
description: Create or update company categories, assign category groups, and enable lead status tracking.
keywords: company category, category group, lead status, potential customer, list
author: digitaldiina
date: 12.11.2025
version: 11.6
content_type: howto
category: sale
topic: lead
license: salesessentials
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: en
---

# Company category and category group

[!include[Must be admin](../../learn/includes/req-admin.md)]

The **Company – Category** list defines the types of companies in your database, such as *Customer*, *Partner*, or *Lead*.
Each category can belong to a **Category group** that determines how it behaves in searches, automations, and lead management.

You manage company categories in **Settings and maintenance** under **Lists** > **Company – Category**.

## About category groups

Category groups provide a way to classify categories by purpose and prevent unwanted automation changes. For example, a company marked as *Customer* should never automatically revert to a *Lead* because of a form submission.

| Category group | Description |
|---|---|
| Customer | Used for existing customers, such as *Customer A*, *Customer B*, or *VIP customer*. |
| Lost | Used for former customers or lost opportunities. |
| Partner | Used for resellers, integrators, or business partners. |
| Potential customer | Used for leads or prospects that have not yet become customers. Only this group can have **Lead status** enabled. |
| Other | Used for any other type of company. |

## Add a company category

1. Select <i class="ph ph-list-bullets" aria-hidden="true"></i> **Lists** in the Navigator.

1. From the dropdown menu, choose **Company – Category**. The **Items** tab displays all existing categories.

1. Click **Add** to open the **Edit list item** dialog.

1. Enter a name for the category in the **Name** field. *(Mandatory)*

    This name appears in the **Category** field on the Company screen.

1. From the **Category group** dropdown, select the appropriate group.

    The group determines how the category behaves in searches and automations but is not visible to end users.

    * To enable lead status later, select **Potential customer**.

1. *(Optional)* Enter a description to clarify how the category should be used.

1. *(Optional)* Select **Enable lead status for this category** if applicable.

1. Click **OK** to save the new category or **Cancel** to discard your changes.

![Editing a company category in the Company – Category list, showing the Potential Customer group selected and the option to enable lead status for the category. -screenshot][img1]

## Edit or delete company categories

> [!NOTE]
> Editing or deleting categories in use can lead to inconsistent data.
> Changing a category group or disabling lead status can leave companies and contacts with lead information that can no longer be updated.
> Review category usage carefully before making changes.

1. Open the **Company – Category** list.

1. To edit:

    1. Double-click a category to open it.
    1. Update the **Name**, **Category group**, or **Lead status** option.
    1. Click **OK** to save.

1. To delete:

    1. Select the category in the list.
    1. Click **Delete**.

## Restore deleted company categories

1. Open the **Company – Category** list.

1. Select **Show deleted items and headings**.

1. Locate the deleted category, double-click it, and click **Restore**.

1. Click **OK**.

## Related content

* [Potential customer categories][2]
* [Enable lead status for company categories][1]
* [Manage lead statuses][3]
* [User group filtering][4]

<!-- Referenced links -->
[1]: index.md
[2]: ../learn/index.md
[3]: add-lead-status.md
[4]: ../../admin/lists/user-group-filtering.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/lead/add-company-category.png
