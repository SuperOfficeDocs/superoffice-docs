---
uid: help-en-company-merge
title: Merge companies
description: Merge companies
author: SuperOffice RnD
so.date: 06.29.2022
keywords: company
so.topic: help
language: en
---

# Merge companies

[!include[Requirement](../includes/note-req-manage-entities.md)]

If there are duplicate records of companies in the database, you can merge them. Contacts and activities will be moved to the target company and the source company will be deleted.

To merge companies:

[!include[Go to company](../includes/goto-company.md)]

1. Select **Manage companies** from the ![icon][img3] **Task** button, and click **Merge companies**.
    The **Merge companies** dialog opens. The source company is specified under **From**.

1. Under **To company**, select the company you want to update with information from the source company. Start typing in the field to search for a company (see [FastSearcher][1]).

    > [!TIP]
    > If you want to switch the **From** and **To** companies, click the ![icon][img1] button.

1. Under **Contacts and company details**, you can choose from:

    * Merge identical contacts. If you select this option, contacts with identical names will be merged.

        > [!NOTE]
        > The names must be EXACTLY the same, i.e. first name, middle name and last name, in order to be merged.)

    * **Replace empty fields in \[target company\] with values from \[source company\]**. If you select this option, empty data fields in the **To** company will be updated with data from the **From** company.

    [!include[Preview results](../includes/note-preview-results.md)]

1. Click **Merge**. The following then happens:

    * The companies are merged.
    * Contacts are moved or merged.
    * All activities are moved.
    * Project memberships and memberships of static selections follow the company.
    * All details are merged if you selected **Replace empty fields in &lt;target company&gt; with values from &lt;source company&gt;**.
    * The source company is deleted.

![Merge companies dialog -screenshot][img4]

> [!TIP]
> You can also merge companies in dynamic and static selections.

## Related topics

* [Merge contacts][2]

<!-- Referenced links -->
[1]: ../search-options/using-fastsearcher.md
[2]: ../person/merge-contacts.md

<!-- Referenced images -->
[img1]: ../../../common/icons/info-ball.png
[img3]: ../../media/icons/btn-menu.png
[img4]: media/merge-companies.bmp
