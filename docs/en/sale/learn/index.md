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

To move between sales, click the previous/next buttons ( ![icon][img2] ![icon][img4] ) at the bottom right of the cards.

You can also [create a quote][1] in the **Quote** section tab in the Sale screen.

## Where can I view sales?

In addition to the [Sale screen][2], sales can be displayed in the following places in SuperOffice CRM:

* On the **Sales** section tab in the Company screen
* On the **Sales** section tab in the Contact screen
* On the **Sales** section tab in the Diary screen
* On the **Sales** section tab in the Project screen

> [!TIP]
> Double-click a sale in one of these locations to open the sale in the Sale screen.

## Use sales overview to prioritize

Keep your sales organized so that you are always focused on the sales that matter the most to you.

After you have registered all your sales in SuperOffice CRM, they will appear in your personal sales overview in the **Sales** tab and in your Diary.

You can organize your sales list by [filtering, grouping and adding the columns][3] that are most important for you. The most used columns are: sales amount, sales date and sales stage.

The **Sales** tab also acts like [a sales secretary][8] by highlighting all your upcoming planned activities in the **Next Activity** field, as well as drawing your attention to those that you may have forgotten in red font.

![Go to the Diary and get an overview of all the sales that are not yet completed -screenshot][img1]

## Add a sale to favorites

[!include[add fav](../../learn/includes/howto-add-favorite.md)]

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

### <a id="more-tab"></a>The More tab

![The More tab (Sale) -screenshot][img6]

The **More** tab displays user-defined fields for the sale. If your organization needs more fields than the default fields in the **Sale** tab, you can specify in Settings and maintenance that these fields will be inserted here.

Click **Edit** to edit the information in the **More** tab.

Three of the user-defined fields from the **More** tab can also be displayed in the **Sale** tab.

### The Links tab

Here you can add links that are relevant for the sale you are working on, such as URL addresses, projects, other sales, follow-ups and documents. For example, if you are going to a meeting with a company you have previously communicated with, you can add links to documents you have already created for this company.

[!include[How to add links](../../learn/includes/howto-add-links.md)]

#### Open links

You can open links by clicking on them in the **Links** tab. URLs/websites open in a new window.

#### Remove links

To remove a link, go to the **Links** tab, click **Edit**, click the delete button next to the link. The link is deleted from the tab.

### The Note tab

[!include[About the Note tab](../../learn/includes/about-note-tab.md)]

## Print info about a sale

1. Go to the required sale.
2. Click the **Task** button and select **Print**.
3. In the window which displays the contents to be printed, click **Print**.

## What would you like to do now?

* [Read about the Sale screen][2]
* [Register a sale][4]
* [Create stakeholders][5]
* [Work with sales guides][6]
* [Create a quote][1]
* [Work with sales targets][7]
* [Stalled, sold, and lost sales][9]

<!-- Referenced links -->
[1]: ../../quote/learn/create.md
[2]: screen/index.md
[3]: ../../learn/section-tabs/index.md
[4]: create.md
[5]: stakeholders/create.md
[6]: sales-guide/working-with-sales-guide.md
[7]: sales-targets/index.md
[8]: ../../diary/learn/screen/sales-tab.md
[9]: stages.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/sale/user-diary-sales.png
[img2]: ../../../media/icons/arrow-left.png
[img3]: ../../../media/loc/en/sale/sale-details.png
[img4]: ../../../media/icons/arrow-right.png
[img5]: ../../../media/loc/en/sale/sale-card.png
[img6]: ../../../media/loc/en/sale/sale-more.png
