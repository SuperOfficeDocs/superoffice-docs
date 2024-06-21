---
uid: mobile-crm-sale
title: Sale
description: Learn about working with sales in SuperOffice Mobile CRM.
author: Bergfrid Dias
date: 07.26.2023
keywords: mobile, sale
topic: reference
version: 10
language: en
client: mobile
---

# Sale ![icon][img10]

From Sale, you can update forecasts for future sales, conclude sales, and create new ones. Also, track the status of all sales that you and your colleagues are responsible for.

![Mobile CRM: Sale -app-screen][img1]

## Tabs in the main Sale screen

| Icon | Tab | Description |
|:-:|---|---|
| ![icon][img19] | Search | Search field and history list. |
| ![icon][img18] | Favorites | Sales marked as a favorite (yellow star). |
| ![icon][img7] | Upcoming | A list of sales with the date of today or ahead. Select a sale to view details about it. |
| ![icon][img8] | Closed | Sold or lost sales. |
| ![icon][img9] | Overdue | A sale is overdue if it has a sale date earlier than today, but its status is neither *sold* nor *lost*. |

## Sales information

**Header:**

* 1 of 4 major statuses (open, lost, stalled, sold)
* Currency amount, sale date
* Company (if set; otherwise, contact)
* Sale title

Icons in the action bar: New appointment, Call, Send email, Go to website, Update status (Move to next stage/set as sold/set as lost/ edit sale)

**Tabs:**

| Icon | Tab | Description |
|:-:|---|---|
| ![icon][img11] | Details | Description and info. Edit to update info or mark as lost/sold/open/stalled. |
| ![icon][img6] | Activities | Appointments, tasks, and phone calls linked to the sale. |
| ![icon][img12] | Documents | Documents and emails linked to the sale. |
| ![icon][img15] | Requests | Requests linked to the sale. |
| ![icon][img17] | Stakeholders | A list of contacts involved in the sale. |
| ![icon][img20] | Quote/products | |

## Sale stages

| Symbol | Description |
|:-:|---|
| ![icon][img5] | Open. In the Stage field, you will also see how far through the sales process you are and which stage the sale has reached (for example, first meeting, prospect, quotation). |
| ![icon][img4] | Sold |
| ![icon][img2] | Lost |
| ![icon][img3] | Stalled |

The number in the red circle next to the sale icon in the navigator shows how many overdue sales you have. If there is a plus sign (+) in the red circle, this means that you have 10 or more overdue sales.

## View your own sales

1. Go to **Sale** ![icon][img10].
2. Check that your name appears at the top.

    If another person's name is shown in red, this means that you are looking at another person's sales. Select the person's name and switch to your own pipeline.

3. Select the **Upcoming**, **Closed**, or **Overdue** tab.

4. Optionally, filter the time period from the **Task** menu.

5. Select a sale to examine it.

[!include[Configure visible fields](../includes/tip-visible-fields.md)]

## View sales belonging to a colleague or a user group

Keeping an eye on the team or internal competition? You can track sales by user group, for example, all sales belonging to users in the Salespersons user group.

> [!NOTE]
> When viewing other users' sales, only information that you have the rights to see is shown. Their name is shown in red above the a list.

1. Go to **Sale**.

2. Select the name just below the row of tabs.

3. Select who's sales you want to view:

    * Select the **Group** tab, and select the user group you want in the list.
    * Or, select the **Associate** tab and choose a person from the history list or search for a name.

    > [!TIP]
    > To get a list of all groups or associates, tap **Search** leaving the search box empty.

4. Explore their sales as described above.

## Related content

* [Create sale][1]
* [Update sale][2]
* [Quote approval flow][3]
* [About sales guides][4]

<!-- Referenced links -->
[1]: create.md
[2]: update.md
[3]: approve-quote.md
[4]: ../../../sale/learn/sales-guide/index.md

<!-- Referenced images -->
[img1]: media/sale.png
[img2]: ../../../../media/icons/sale-lost.png
[img3]: ../../../../media/icons/sale-postponed.png
[img4]: ../../../../media/icons/sale-sold.png
[img5]: ../../../../../common/icons/nav-sale-h32.png
[img6]: ../../../../../common/icons/mobile/activities-h32.png
[img7]: ../../../../../common/icons/mobile/saleslist-pipeline-h32.png
[img8]: ../../../../../common/icons/mobile/saleslist-closed-h32.png
[img9]: ../../../../../common/icons/mobile/saleslist-overdue-h32.png
[img10]: ../../../../../common/icons/nav-sale.png
[img11]: ../../../../../common/icons/mobile/details-h32.png
[img12]: ../../../../../common/icons/mobile/documents-h32.png
[img15]: ../../../../../common/icons/mobile/ticket-h32.png
[img17]: ../../../../../common/icons/mobile/associate-h32.png
[img18]: ../../../../../common/icons/mobile/star-h32.png
[img19]: ../../../../../common/icons/mobile/search-h32.png
[img20]: ../../../../../common/icons/mobile/product-default-h32.png
