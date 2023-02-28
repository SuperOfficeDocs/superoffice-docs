---
uid: help-en-sale-screen
title: Sale screen
description: The Sale screen in SuperOffice
author: SuperOffice RnD
so.date: 07.04.2022
keywords: sale
so.topic: reference
language: en
---

# The Sale screen

The **Sale** screen contains information about the sales entered into SuperOffice CRM. Each sale is displayed like an index card, showing all information about that sale.

To move between sales, click the previous/next buttons ( ![icon][img2] ![icon][img1] ) at the lower right of the cards.

You can also [create a quote][1] in the **Quote** section tab in the **Sale** screen.

## The Details tab

This tab contains fields that focus, in particular, on the financial details of the sale.

![Sale Details tab -screenshot][img3]

| Field | Description | Defined in Settings and maintenance |
|---|---|---|
|Number | The ID number for the sale, where the next free sale number is entered automatically. | x |
| Source | Displays the source of the sale, as specified in the **Sale** tab. You can also edit the source here. |
| Competitor | Contains a predefined list of competitors. Here you can enter any competitor for the sale. You can choose only one competitor. | x |
| Total cost | Enter here the cost connected with the sale. It is displayed in the same currency as the amount. The default value is 0. When you enter an amount in this field, the profit percentage and amount are automatically calculated in the field below. | |
| Profit | Enter the profit connected with the sale here. It is displayed in the same currency as the amount. | |
| Credited | Contains a predefined list of departments that can be responsible for the sale. | x |
| User-defined fields | In the user-defined fields you can enter further information about the sale. | |

> [!NOTE]
> If you change the value in the **Total cost** field, the **Profit** field or the field for the profit percentage, the other fields are automatically updated.

## The Links tab

Here you can add links that are relevant for the sale you are working on, such as URL addresses, projects, other sales, follow-ups and documents. For example, if you are going to a meeting with a company you have previously communicated with, you can add links to documents you have already created for this company.

[!include[How to add links](../../../learn/includes/howto-add-links.md)]

### Open links

You can open links by clicking on them in the **Links** tab. URLs/websites open in a new window.

### Remove links

To remove a link, go to the **Links** tab, click **Edit**, click the delete button next to the link. The link is deleted from the tab.

## The Note tab

[!include[About the Note tab](../../../learn/includes/about-note-tab.md)]

## Section tabs in the Sale screen

The lower part of the **Sale** screen consists of section tabs.

* [Activities][6]
* [Sales guide][3]
* [Stakeholders][5]
* [Quote][7] (requires a licence)

[Sales guides][3] are only shown for specific sales types (defined in SuperOffice Settings and maintenance). If you select a sale type for which a sales guide is defined, the **Sales guide** section tab is displayed.

[!include[Add more section tabs](../../../learn/includes/more-tab.md)]

## What would you like to do now?

* [Record a sale][4]
* [Work with sales guides][2]
* [Create a quote][1]

<!-- Referenced links -->
[1]: ../../../quote/learn/create.md
[2]: ../sales-guide/working-with-sales-guide.md
[3]: ../sales-guide/index.md
[4]: ../create.md
[5]: ../stakeholders/index.md
[6]: activities-sale.md
[7]: quote-tab.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/arrow-right.png
[img2]: ../../../../media/icons/arrow-left.png
[img3]: ../media/55-chap7-sale-new-details.bmp
