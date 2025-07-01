---
uid: mobile-crm-sale
title: Sales
description: Learn how to create, view, and update sales in SuperOffice Mobile CRM.
keywords: opportunity, manage sales, sale, upcoming, closed, overdue
author: Bergfrid Dias
date: 06.10.2025
version: 11.1
content_type: concept
platform: mobile
language: en
---

# Sales <i class="ph ph-currency-circle-dollar" aria-hidden="true"></i>

In SuperOffice Mobile CRM, you can easily create, view, and update sales records while on the go. Sales are linked to contacts or companies and allow you to track opportunities, progress, and revenue.

![Mobile CRM: Sale -app-screen][img1]

## Sale statuses

| Symbol | Status | Description |
|:-:|---|---|
| <i class="ph ph-currency-circle-dollar" aria-label="Sale icon"></i> | **Open** | The sale is active. In the **Stage** field, you can see how far through the sales process you are and which stage the sale has reached (for example, first meeting, prospect, quotation). |
| <i class="ph ph-check" aria-label="Check icon"></i> | **Sold** | The sale is completed successfully. |
| <i class="ph ph-x" aria-label="X icon"></i> | **Lost** | The sale did not close successfully. |
| <i class="ph ph-triangle" aria-label="Red triangle icon"></i> | **Stalled** | Progress has stopped, and the sale is on hold. |

## Tabs in the main Sale screen

| Tab | Description |
|---|---|
| Search | Search field and history list. |
| Favorites | Sales marked as a favorite (yellow star). |
| Upcoming | A list of sales with the date of today or ahead. Tap a sale to view details about it. |
| Closed | Sold or lost sales. |
| Overdue | A sale is overdue if it has a sale date earlier than today, but its status is neither *sold* nor *lost*. |

## Viewing sales and pipelines

You can view your own sales or explore sales belonging to other users or user groups.

### View your own sales

1. Go to **Sales**.
1. Select the **Upcoming**, **Closed**, or **Overdue** tab.
1. Ensure your name is displayed at the top.
    * If another person's name is shown, tap it to switch back to your own pipeline.
1. Optionally, filter the time period from the **Task menu** (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>).
1. Tap a sale to examine its details.

### View sales belonging to a colleague or a user group

To monitor team progress or internal competition, you can view sales by colleague or user group.

> [!NOTE]
> When viewing other users' sales, only information you have the rights to see is displayed. The user's name is shown above the list.

1. Go to **Sale** and select the **Upcoming**, **Closed**, or **Overdue** tab.

1. Tap the text just below the row of tabs.

1. Choose between:
    * **Group tab:** Select a user group from the list.
    * **Associate tab:** Choose a person from the history list or search for a name.

    To see a complete list of groups or associates, tap **Search** with the search box left empty.

1. Explore their sales as described above.

## Sale header

* **Status:** Indicates the sale's current state (Open, Sold, Lost, or Stalled) with a status icon.
* **Title:** Name of the sale
* **Currency amount:** Expected value
* Company (if set; otherwise, contact)
* **Edit** button (<i class="ph ph-pencil-simple" aria-label="Pencil icon"></i>)
* Action bar: Call, Email, Mark (Move to next/previous stage, Set as sold, Set as lost, Mark as stalled)

## Sections

| Icon | Tab | Description |
|:-:|---|---|
| | Progress bar and contact | Displays the current step in the sales process and who the customer is. |
| <i class="ph ph-list-bullets" aria-label="List"></i> | Details | Shows basic information like type, owner, and next activity. |
| | Description | An optional summary of the sale. |
| | Info | Free text area to add notes about the sale. |
| <i class="ph ph-link" aria-label="Chain"></i> | Links | Connect relevant activities, documents, or opportunities to the sale. |
| <i class="ph ph-calendar-blank" aria-label="Calendar"></i> | Activities | Meetings, todos, and phone calls linked to the sale. |
| <i class="ph ph-files" aria-label="Stack of files"></i> | Documents | All related documents and emails. |
| <i class="ph ph-ticket" aria-label="Ticket"></i> | Requests | Requests linked to the sale. |
| <i class="ph ph-users-three" aria-label="Group icon"></i> | Stakeholders | A list of contacts involved in the sale. |

### Tips

* Tap a linked item (such as person, activity, document) to open it.
[!include[List of tips](../includes/list-of-tips.md)]

## Related content

* [Create a sale][1]
* [Update a sale][2]
* [About sales guides][4]
* [Quote approval flow][3]

<!-- Referenced links -->
[1]: create.md
[2]: update.md
[3]: approve-quote.md
[4]: ../../../sale/learn/sales-guides.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/mobile/sale.png
