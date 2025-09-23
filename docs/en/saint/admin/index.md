---
uid: help-en-saint-admin
title: Set up SAINT
description: Learn how to set up SuperOffice SAINT in this guide.
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

# Set up SAINT

You can follow up on your customers proactively by using SAINT, which stands for Sales Intelligence. SuperOffice SAINT can be used in many ways and for many different processes. Before successfully implementing the SAINT feature it is important to know what you wish to improve and how you can analyze this.

After you know what you want to improve, try to think of the action your company can take to improve on the existing situation. What action will you take?

* Send out a group mailing using SuperOffice Mailings
* Call all customers in the SAINT selection
* Follow up on all requests

[!include[Requirement](../includes/note-saint-req.md)]

Using the **Status monitors/SAINT** tab, you can create statuses for companies, contacts and projects. Status monitors represent the functionality behind the Sales Intelligence (SAINT) concept. This facilitates following up companies, contacts and projects and provides more intelligent search options in SuperOffice CRM.

![SAINT screen with status list, description, image, and criteria -screenshot][img1]

## The status list

The status list on the **Company**, **Contact**, and **Project** tabs shows active status monitors for that entity and, if **Show deleted** is selected, also deleted ones.

| Element | Description |
|---|---|
| **Visualize icon** <i class="ph ph-eye" aria-label="eye"></i> | Indicates if a status image is displayed on company, contact, or project cards. The icon appears only if the **Visualize** box is checked. |
| **Red X** | Shown next to statuses that must be [regenerated][8]. These statuses are not updated and do not return current data. |
| **Name column** | Displays the names of the statuses. Deleted statuses are shown in red if **Show deleted** is checked below the list. |
| **Priority column** | Determines which status image is shown on the card when a company, contact, or project matches the criteria for multiple statuses. The highest-priority status is displayed, while other active statuses are available as links in the status dialog. |

## Status images

Statuses can be shown as images on the cards of projects, contacts or companies that fulfil your criteria. The status image for a customer you have had no contact with for a while could, for example, be a spider's web. This then provides a visual and immediate indication of what your relations with the customer are or how a project is progressing. When the user clicks or holds the mouse pointer over a status image in SuperOffice CRM, some text is displayed. For example, to indicate the actions that should be taken (you yourself enter the text when you create the status).

## Default follow-up for a status

When the user opens the status dialog in SuperOffice CRM, they may also create a follow-up for the status in question. The follow-up type and text can be predefined.

## Searches and selections

Statuses and counters can be used in searches and to create dynamic selections. For example, you can search for companies, contacts or projects that fulfil a status or a counter. [!include[Define counter](../includes/def-counter.md)]

You can set up 3 different counters/periods, these counters are the number of days you want to count on activities, sales and requests. The different periods are set on what is important for you. For example, you want to be notified if some of your customers haven't had any activities the last month (30 days), or if there are unsolved requests on the customers that are older than 30 days.

## Periods

You can specify up to three different periods for counters, so that the SAINT criteria can cover shorter or longer periods. If you specify three periods of 30, 60 and 90 days respectively, you can select SAINT criteria for each of these periods.

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
[1]: create-status.md
[2]: create-status.md#image
[5]: counter-settings.md
[7]: update.md
[8]: update.md#regen
[13]: ../../database/tables/countervalue.md
[14]: ../../database/tables/statusvalue.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/saint/status-monitors-company-tab.png
