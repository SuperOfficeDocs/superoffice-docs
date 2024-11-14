---
uid: help-en-sale
title: Sale
description: SuperOffice Sales helps sales teams stay in control of their sales pipelines and processes.
keywords: sale
author: SuperOffice RnD
date: 10.29.2024
version: 10.3.11
topic: concept
audience: person
audience_tooltip: SuperOffice CRM
language: en
---

# Sale

The sale function in SuperOffice CRM enables you to record sales, keep track of costs and profits for every sale, and link sales to projects.

Managing your sales opportunities efficiently leads to closing more deals. SuperOffice Sales is designed to assist sales team in their everyday tasks and equip them to always hit their targets.

Watch this video and see how easy pursuing sales opportunities can be with SuperOffice CRM (video length - 2:16):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/VTgBzMk_qvk]

The **Sale** screen contains information about the sales entered into SuperOffice CRM. Each sale is displayed like an index card, showing all information about that sale.

To move between sales, click the previous/next buttons (<i class="ph ph-arrow-left" aria-hidden="true"></i><i class="ph ph-arrow-right" aria-hidden="true"></i>) at the bottom right of the cards.

You can also [create a quote][1] in the **Quote** section tab in the Sale screen.

## Where can I view sales?

In addition to the [Sale screen][2], sales are displayed on the [Sales section tab][13] in the Company, Contact, Diary, and Project screens

> [!TIP]
> Double-click a sale in one of these locations to open the sale in the Sale screen.

## Use sales overview to prioritize

Keep your sales organized so that you are always focused on the sales that matter the most to you.

After you have registered all your sales in SuperOffice CRM, they will appear in your personal sales overview in the **Sales** tab and in your Diary.

You can organize your sales list by [filtering, grouping and adding the columns][3] that are most important for you. The most used columns are: sales amount, sales date and sales stage.

The **Sales** tab also acts like a sales secretary by highlighting all your upcoming planned activities in the **Next Activity** field, as well as drawing your attention to those that you may have forgotten in red font.

![Go to the Diary and get an overview of all the sales that are not yet completed -screenshot][img1]

## The Sale main card

### The Sale tab

This tab contains the main fields you need to fill in. Title is the first, and it's also mandatory. Read more about how to [create a sale][4].

![The sale tab in Sales screen -screenshot][img5]

### The Details tab

This tab contains fields that focus, in particular, on the financial details of the sale.

![Sale Details tab -screenshot][img3]

| Field | Description | Defined in Settings and maintenance |
|---|---|---|
|Number | The ID number for the sale, where the next free sale number is entered automatically. | x |
| Source | Displays the source of the sale, as specified in the **Sale** tab. You can also edit the source here. | |
| Competitor | Contains a predefined list of competitors. Here you can enter any competitor for the sale. You can choose only one competitor. | x |
| Total cost | Enter here the cost connected with the sale. It is displayed in the same currency as the amount. The default value is 0. When you enter an amount in this field, the profit percentage and amount are automatically calculated in the field below. | |
| Profit | Enter the profit connected with the sale here. It is displayed in the same currency as the amount. | |
| Credited | Contains a predefined list of departments that can be responsible for the sale. | x |

> [!NOTE]
> If you change the value in the **Total cost** field, the **Profit** field or the field for the profit percentage, the other fields are automatically updated.

### <a id="more-tab"></a>The More tab for sales

The [More tab][12] includes additional custom fields for the sale. Up to three fields from the **More** tab can also be shown in the main **Sale** tab for easier visibility.

### The Links tab

Here you can add links that are relevant for the sale you are working on, such as URL addresses, projects, other sales, follow-ups and documents. For example, if you are going to a meeting with a company you have previously communicated with, you can add links to documents you have already created for this company.

[!include[How to add links](../../learn/includes/howto-add-links.md)]

#### Open links

You can open links by clicking on them in the **Links** tab. URLs/websites open in a new window.

#### Remove links

To remove a link, go to the **Links** tab, click **Edit**, click the delete button next to the link. The link is deleted from the tab.

### The Note tab

[!include[About the Note tab](../../learn/includes/about-note-tab.md)]

## <a id="section-tabs"></a>The Sale screen section tabs

The lower part of the Sale screen consists of section tabs.

* [Activities][14]
* [Sales guide][16]
* [Stakeholders][15]
* [Quote][17] (requires a licence)

[Sales guides][3] are only shown for specific sales types (defined in Settings and maintenance). If you select a sale type for which a sales guide is defined, the **Sales guide** section tab is displayed.

[!include[Add more section tabs](../../learn/includes/more-tab.md)]

## Related content

* [Add sale as a favorite][10]
* [Register a sale][4]
* [Create stakeholders][5]
* [Work with sales guides][6]
* [Create a quote][1]
* [Work with sales targets][7]
* [Stalled, sold, and lost sales][9]
* [Print info about a sale][11]

<!-- Referenced links -->
[1]: ../../quote/learn/create.md
[2]: screen/index.md
[3]: ../../learn/section-tabs/index.md
[13]: ../../learn/section-tabs/sales-tab.md
[14]: ../../learn/section-tabs/activities-tab.md
[4]: create.md
[5]: stakeholders/create.md
[15]: stakeholders/index.md
[6]: sales-guide/working-with-sales-guide.md
[16]: sales-guide/index.md
[7]: sales-targets/index.md
[9]: stages.md
[10]: ../../learn/basics/fav.md
[11]: ../../learn/basics/print.md
[12]: ../../custom-objects/learn/more-tab.md
[17]: ../../quote/learn/quote-tab.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/sale/user-diary-sales.png
[img3]: ../../../media/loc/en/sale/sale-details.png
[img5]: ../../../media/loc/en/sale/sale-card.png
