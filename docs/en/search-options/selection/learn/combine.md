---
uid: help-en-selection-combine
title: Create a combined selection
description: In this howto, you will learn how to create a combined selection.
keywords: combine selections, selection
author: Bergfrid Dias
date: 03.21.2025
version: 10.5.3
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: en
---

# Create a combined selection

## Find the data

1. Open one of the selections you want to combine.

1. Click the **Task** button (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>) and select **Combine selection with**. A new selection screen opens.

1. Type the name of the new selection in the field containing *Selection name*. This field is mandatory.

1. In the **Selection of** field, choose what the selection is to contain. The choices here are limited to **Company/contact** and the type of selection you have selected. You cannot change this after it is saved to the database.

1. In the **Selection is** field, **Combined** is selected by default.

1. Under **Selection 2**, choose the other selection you want to combine.

    > [!NOTE]
    > If you selected **Companies/contacts** under **Selection of**, you can choose from all types of selection here (a sales selection also contains companies/contacts related to the sales). But if the combined selection comprises Sales, Projects, Documents, Follow-ups, Requests, Form submissions, Chat conversations, Mailings or Products, you must choose the same type of selections for **Selection 1** and **Selection 2**.

1. Under **Compare**, select which entries from the two selections to include in the combined selection.

| Icon | Option | Description |
|:-:|---|---|
| <i class="ph ph-subtract" aria-label="Only in one selection icon"></i> | Only in Selection 1/Only in Selection 2 | Shows entries that are in only selection 1 or 2, and excludes entries that are in both selection 1 and selection 2. |
| <i class="ph ph-intersect" aria-label="Common entries icon"></i> | Common | Shows only entries that are in both selection 1 and selection 2. |
| <i class="ph ph-exclude" aria-label="Difference icon"></i> | Difference | Shows only entries that are either in selection 1 or in selection 2. |
| <i class="ph ph-unite" aria-label="All entries icon"></i> | All | Shows only entries in selection 1 and selection 2. |

## Choose details

Set properties following the instructions of step 2 in the [Create selection][1] tutorial.

## Finish

1. Optionally, click the star icon (<i class="ph ph-star" aria-hidden="true"></i>) to add the selection to [your favorites][2].

1. Click **Save**.

After saving the selection, you can [edit it][3] to change both the combination type and which selections are combined. But it is not possible to change the **Selection of** field.

<!-- Referenced links -->
[1]: create/tutorial.yml
[3]: update/index.md
[2]: ../../../learn/basics/fav.md
