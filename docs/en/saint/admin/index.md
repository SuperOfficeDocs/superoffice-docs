---
uid: help-en-saint-admin
title: SAINT in Settings and maintenance
description: Learn about the key concepts of SuperOffice SAINT, including criteria, images, counters, and default follow-ups.
keywords: SAINT, activity monitor, status monitor
author: SuperOffice Product and Engineering
date: 09.23.2025
version: 10.5
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
language: en
index: true
redirect_from: /en/sale/saint/learn/admin/index
---

# SAINT in Settings and maintenance

SAINT (Sales Intelligence) helps you monitor companies, contacts, and projects so you can follow up at the right time. An **activity monitor** (also known as status monitor) combines criteria, counters, and optional properties to highlight records that need attention.

Before implementing SAINT, it is important to know what you want to improve and how you will analyze it. Then, consider which proactive actions your company can take to improve the current situation. For example:

* Send a group mailing
* Call all customers in the SAINT selection
* Follow up on all requests

[!include[Requirement](../includes/note-saint-req.md)]

![SAINT screen with status list, description, image, and criteria -screenshot][img1]

## The status list

The status list on the **Company**, **Contact**, and **Project** tabs shows active status monitors for that entity and, if **Show deleted** is selected, also deleted ones.

| Element | Description |
|---|---|
| **Visualize icon** <i class="ph ph-eye" aria-label="eye"></i> | Indicates if a status image is displayed on company, contact, or project cards. The icon appears only if the **Visualize** box is checked. |
| **Red X** | Shown next to statuses that must be [regenerated][8]. These statuses are not updated and do not return current data. |
| **Name column** | Displays the names of the statuses. Deleted statuses are shown in red if **Show deleted** is checked below the list. |
| **Priority column** | Determines which status image is shown on the card when a company, contact, or project matches the criteria for multiple statuses. The highest-priority status is displayed, while other active statuses are available as links in the status dialog. |

## Properties

A status monitor combines several properties that define how it works:

* **Criteria:** Each status must include one or more criteria. These conditions determine which companies, contacts, or projects the status applies to. For example, you can define a status for customers with no sales in the last 90 days.

* **Status images:** An optional image can be displayed on company, contact, or project cards that match the criteria. For example, a spider's web can indicate inactivity. Images appear as light watermarks and can be clicked for more details.

* **Default follow-up:** When a user clicks the status, they can create a follow-up. The type and description can be predefined, so the follow-up clearly states what action is required.

## Counters and periods

Counters [track activity over time][5], such as sales, requests, or completed follow-ups.
You can use counters in searches and selections to identify records that meet or fail certain thresholds.

You can define up to three different periods (for example, 30, 60, and 90 days).
This lets you apply the same counter, such as "Number of sales", to different time spans.

## <a id="database"></a>How SAINT stores counters and statuses

SAINT counters are stored in the [countervalue][13] table and updated automatically as you do things:

* When SAINT is enabled, whenever a contact or a project is created, a bunch of counter rows are created.

* Whenever a follow-up, document, or sale is created, then the corresponding counter rows are updated.

SAINT **values** are simple binary values (on or off) that determine the look and feel of the company and project cards. These values are stored in the [statusvalue][14] table.

## Related content

* [Set up a new status monitor][1]
* [Visualize statuses with images][2]
* [Counters and counter settings][5]
* [Update, delete, and restore status monitors][7]
* [Regenerate status monitors and counters][8]

<!-- Referenced links -->
[1]: set-up.md
[2]: set-up.md#image
[5]: counter-settings.md
[7]: update.md
[8]: update.md#regen
[13]: ../../../en/database/tables/countervalue.md
[14]: ../../../en/database/tables/statusvalue.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/saint/status-monitors-company-tab.png
