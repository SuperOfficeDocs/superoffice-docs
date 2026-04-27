---
uid: help-en-marketing-forms-field-restrictions
title: Form field restrictions
description: Learn how to control which fields are available in forms and whether form submissions can overwrite existing data in those fields.
keywords: form field restrictions, form, field, do not allow overwrite, overwrite, do not show in forms
author: digitaldiina
date: 05.04.2026
version: 11.13
content_type: howto
category: marketing
topic: forms
license: marketingessentials
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: en
---

# Form field restrictions

Form field restrictions let you control which fields are available in forms, and whether a form submission can overwrite existing data in those fields.

By default, form submissions do not overwrite existing data. The person building the form can choose to enable overwrite for individual fields. Use field restrictions to remove that option from sensitive fields, or to prevent a field from appearing in the form builder at all.

> [!CAUTION]
> Forms on a website can be filled out by anyone. Allowing overwrites carries risks including unintentional data loss, unauthorized modifications to sensitive fields, and compromised data integrity through incorrect entries. Handle sensitive fields with care.

## Where to manage field restrictions

Field restrictions are configured in **Settings and maintenance** and require administrator rights.

1. Go to **Settings and maintenance**.
1. Select <i class="ph ph-bullseye" aria-hidden="true"></i> **Marketing** from the navigator.
1. Select the **Form field restrictions** tab.

![Admin Marketing - Set restrictions on form fields visible in Marketing forms -screenshot][img1]

## Add a field restriction

1. In the **Fields with restrictions** section, select a field from the dropdown list.
1. Select the restriction type for that field.
1. Select **Save**.

Repeat to add restrictions for more fields.

## Restriction options

* **Do not allow overwrite:** The overwrite option is removed from this field in all forms, including forms that are already published. The field remains available in the form builder and can still be added to forms, but submitted data will never overwrite existing values.

* **Do not show in forms:** The field is removed from the form builder entirely and cannot be added to new forms. Existing published forms that already include the field are not affected.

## Remove a field restriction

1. Locate the field in the **Fields with restrictions** list.
1. Select the remove icon (<i class="ph ph-x-circle" aria-hidden="true"></i>) next to the field.
1. Select **Save**.

Removing a restriction restores default behavior. The field becomes available in the form builder again, and the form owner can choose whether to allow overwrite.

## Related content

* [Field options][1]
* [Create a form][2]
* [Manage fonts for forms][3]

<!-- Referenced links -->
[1]: ../learn/field-options.md
[2]: ../learn/create.md
[3]: manage-fonts.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/admin/admin-marketing-form-field-restrictions.png
