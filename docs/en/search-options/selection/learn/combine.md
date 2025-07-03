---
uid: help-en-selection-combine
title: Create a combined selection
description: In this howto, you will learn how to create a combined selection.
keywords: combine selections, selection
author: Bergfrid Dias
date: 03.21.2025
version: 10.5.3
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: en
redirect_from: /en/search-options/selection/learn/create/combine
---

# Create a combined selection

The two selections to be combined can be static or dynamic. There are however certain limitations on what can be combined:

* If you choose to create a combined selection consisting of companies, all types of selection are available.
* But if you choose to create a combined selection consisting of sales, projects, documents, follow-ups or products, only selections of the selected type are available.

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

## Examples

### Companies and sales

1. Create a combined selection of companies/contacts based on two existing selections: "Customers in Sweden" (selection 1) and "Sales made last year" (selection 2).
2. Select the combination type **Only in Selection 1**. The result will contain customers in Sweden to whom you sold nothing last year.
3. Save the result as a static selection under the name "Customers in Sweden with no sales", and give one of your sales staff responsibility for following up these customers.

### Follow-ups

1. Create a combined selection of follow-ups based on two existing selections: "Follow-ups linked to my customers" (selection 1) and "Planned follow-ups next month" (selection 2).
2. Choose the combination type **Common**. The result is a list of follow-ups you need to act on next month. You could then export this to a file using the **Export to file** task.

> [!NOTE]
> If you simply want to compare the companies linked to these two selections, check **Compare companies only**.

<!-- Referenced links -->
[1]: create.md
[3]: update.md
[2]: ../../../learn/basics/fav.md
