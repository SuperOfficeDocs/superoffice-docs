---
uid: help-en-merge-companies
title: Merge companies
description: Merge companies
author: SuperOffice RnD
so.date: 06.29.2022
keywords: CRM
so.topic: help
language: en
---

# Merge companies

[!include[Requirement](../includes/note-req-manage-entities.md)]

If there are duplicate records of companies in the database, you can merge them. Contacts and activities will be moved to the target company and the source company will be deleted.

To merge companies:

1. [!include[Go to company](../includes/goto-company.md)]

2. Select **Manage companies** from the ![icon][img3] **Task** button, and click **Merge companies**.
    The **Merge companies** dialog opens. The source company is specified under **From**.

    <!-- Fix reuse ID=a1 -->

    ![Merge companies dialog -screenshot][img4]

3. Under **To company**, select the company you want to update with information from the source company. Start typing in the field to search for a company (see [FastSearcher][1]).

    > [!TIP]
    > If you want to switch the **From** and **To** companies, click the ![icon][img1] button.

4. Under **Contacts and company details**, you can choose from:

    > [!NOTE]
    > The names must be EXACTLY the same, i.e. first name, middle name and last name, in order to be merged.)
    * **Replace empty fields in \[target company\] with values from \[source company\]**. If you select this option, empty data fields in the **To** company will be updated with data from the **From** company.

    > [!NOTE]
    > If you want to see the results before you merge the companies, click **Show results**: ![icon][img2].

5. Click **Merge**. The following then happens:

    * The companies are merged.
    * Contacts are moved or merged.
    * All activities are moved.
    * Project memberships and memberships of static selections follow the company.
    * All details are merged if you selected **Replace empty fields in &lt;target company&gt; with values from &lt;source company&gt;**.
    * The source company is deleted.

> [!TIP]
> You can also merge companies in dynamic and static selections.

## Related topics

* [Merge contacts][2]

<!-- Referenced links -->
[1]: ../getting-started/using-fastsearcher.md
[2]: merge-contacts.md

<!-- Referenced images -->
[img1]: ../../../media/icons/slå-sammen-bytte.bmp
[img2]: ../../../media/icons/vis-resultat.bmp
[img3]: ../../../media/icons/btn-menu.png
[img4]: media/merge-companies.bmp
