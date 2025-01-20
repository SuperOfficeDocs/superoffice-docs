---
uid: help-en-company-merge
title: Merge companies
description: To keep your customer database clean and efficient, merge duplicate companies or combine records when one company acquires another.
keywords: Merge companies, Manage companies, Merge identical contacts, company
author: Bergfrid Dias
date: 12.16.2024
version: 10.3.8
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: en
---

# Merge companies

[!include[Requirement](../../learn/includes/note-req-manage-entities.md)]

To keep your customer database clean and efficient, merge duplicate companies or combine records when one company acquires another. Contacts, activities, invoices, registered domains, and other details will be moved or merged, and the source company will be deleted.

## Steps

1. Click the **Task** button (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>) in the upper-right corner of the Company card.
   Select **Manage companies** > **Merge companies** from the menu.
   The **Merge companies** dialog appears, with the source company specified under **From**.

2. In the **To company** section, search for and select the target company to merge into. To swap the **From** and **To** companies, click the arrow button <i class="ph ph-arrows-left-right" aria-hidden="true"></i>.

    > [!CAUTION]
    > Make sure you select the correct company in both the **From** and **To** fields before proceeding.

3. Under **Contacts and company details**, choose one or both of the following options:

    * **Merge identical contacts:** Contacts with exactly the same first, middle, and last names will be merged.
    * **Replace empty fields with values from the source company:** Empty fields in the target company will be updated with data from the source company.

4. Click **Merge**. The following happens:

    * Contacts (and related requests) are moved or merged.
    * Activities are moved.
    * Project and static selection memberships follow the target company.
    * Empty fields are updated if you selected **Replace empty fields...**.
    * The source company is deleted.

![Merge companies dialog with fields for selecting source and target companies, options to merge identical contacts, replace empty fields, and a summary of actions to be performed. -screenshot][img4]

> [!TIP]
> You can also merge companies in dynamic and static selections.

## Related content

* [Merge contacts][2]

<!-- Referenced links -->
[2]: ../../contact/learn/merge-contacts.md

<!-- Referenced images -->
[img4]: ../../../media/loc/en/company/merge-companies.png
