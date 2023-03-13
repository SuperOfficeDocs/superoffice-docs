---
uid: help-en-page-1-fields
title: Select page 1 fields
description: Select page 1 fields
author: SuperOffice RnD
so.date: 06.29.2022
keywords: udef, custom field
so.topic: howto
language: en
---

# Select page 1 fields

> [!NOTE]
> This feature is not available if your organization uses customized screen layouts.

Among the user-defined fields that are displayed in the **More** tabs in SuperOffice CRM, you can choose *three* that will function as page 1 fields (so called because they are displayed on the "first page" in their respective screens).

<details><summary>Where can I display Page 1 fields?</summary>

[!include[List](includes/list-page-1-field-locations.md)]

</details>

## To display a user-defined field on the first page

[!include[Go to fields and select tab](includes/goto-fields.md)]

1. Check **Allow different page 1 fields for different user groups** at the bottom of the tab to specify different page 1 fields for different user groups. If not checked, the fields you specify are used for all user groups.

1. In the user group list above, select the required user group (if you checked **Allow different page 1 fields for different user groups** in the previous step).

1. In the **Field 1** list box, choose the field to display at the top. Choose the fields to display in the next positions in the **Field 2** and **Field 3** list boxes.

1. Click **Save** to save your changes only in Settings and maintenance or click **Publish** to make the changes available to SuperOffice CRM users.

## User groups and page 1 fields

When you select a name in the **User group** list, the available page 1 fields for the selected user group are displayed under **Fields 1**, **2** and **3**.

> [!NOTE]
> User groups are defined in the **Lists** screen, and the group that a user belongs to is defined in the **Users** screen.

If you select **(all user groups)** in the **User group** list, select a field or fields and save the setup, the same selection of fields will apply to all user groups in SuperOffice CRM. If you then select a specific user group, you can override the existing field setup for just this group by using a different specification. If you do not specify anything in a field, it is left empty – because the override applies to all three fields irrespective of their contents.

> [!NOTE]
> You must publish an override for a single user group *after* you specify a setup for all user groups. Otherwise, it will not take effect.

<!-- Referenced links -->

<!-- Referenced images -->
