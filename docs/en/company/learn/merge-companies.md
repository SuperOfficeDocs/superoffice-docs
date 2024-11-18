---
uid: help-en-company-merge
title: Merge companies
description: To be able to be efficient in the work with customers and contacts, it is vital to have a "clutter free" environment. This means delete unused companies and contacts, and merge duplicated companies and contacts.
keywords: company
author: SuperOffice
date: 08.27.2024
version: 10.3.8
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: en
---

# Merge companies

[!include[Requirement](../../learn/includes/note-req-manage-entities.md)]

You can merge duplicate database records of companies. Contacts and activities will be moved to the target company and the source company will be deleted.

If two companies in your customer database decide to merge or one of the companies has bought the other company, you can merge these companies into one company. Contacts (and related requests), invoices, and registered domains are kept for both companies.

## Steps

[!include[Go to company](../../learn/includes/goto-company.md)]

1. Select **Manage companies** from the ![icon][img3] **Task** button, and click **Merge companies**.
    The **Merge companies** dialog opens. The source company is specified under **From**.

1. Under **To company**, select the company you want to update with information from the source company. Start typing in the field to search for a specific company. To switch the **From** and **To** companies, click the arrow button.

    > [!CAUTION]
    > Make sure you select the correct company in the From field AND in the To field.

1. Under **Contacts and company details**, you can choose from:

    * Merge identical contacts. If selected, contacts with identical names are merged.

        The names must be EXACTLY the same, first name, middle name and last name, to be merged.

    * **Replace empty fields...**. If selected, empty data fields in the **To** company are updated with data from the **From** company.

1. Click **Merge**. The following then happens:

    * The companies are merged.
    * Contacts are moved or merged.
    * All activities are moved.
    * Project memberships and memberships of static selections follow the company.
    * All details are merged if you selected **Replace empty fields...**.
    * The source company is deleted.

![Merge companies dialog -screenshot][img4]

> [!TIP]
> You can also merge companies in dynamic and static selections.

## Related topics

* [Merge contacts][2]

<!-- Referenced links -->
[2]: ../../contact/learn/merge-contacts.md

<!-- Referenced images -->
[img3]: ../../../media/icons/btn-menu.png
[img4]: ../../../media/loc/en/company/merge-companies.png
