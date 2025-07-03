---
uid: help-en-saint-status-create
title: Create new status
description: Create new status
keywords: SAINT, activity monitor, status monitor
author: SuperOffice RnD
date: 02.22.2023
version: 9
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: en
redirect_from: /en/sale/saint/learn/admin/create-status
---

# Create a new status

[!include[Requirement](../includes/note-saint-req.md)]

## Why should you create a status monitor?

You want to monitor companies that you have very few activities with, to avoid unhappy customers and churn. With this status monitor, you easily see all the customers who need attention.

![Create a status monitor by clicking the Add button -screenshot][img1]

## Steps

1. [!include[Open SAINT](includes/open-saint-select-tab.md)]

1. Click **Add** below the **Status monitors** list.

1. In the dialog, complete these fields:

    * **Name**: Enter a descriptive name for the status you want to add.

        Optional: Click <i class="ph ph-translate" aria-label="Translate"></i> to [add translations][8] of the status name.

    * **Description**: Enter an explanatory description of the status and what measures are required or recommended. In this field you can also use [template variables][9] to tailor the text to the relevant company, contact or project.

    The name and description are displayed in SuperOffice CRM when the user holds the mouse pointer over the status image or opens the status image for the company. You can subsequently [edit the description][2].

1. Click **Save**. The status is displayed in the status list.

1. If there are several statuses in the list, specify the priority you want the new status to have. Click the status and use the arrow buttons to the right of the status list to move it up or down the list.

### What does the status list contain?

* The **Visualize** icon (<i class="ph ph-eye" aria-hidden="true"></i>) indicates if to [display a status image][3] for company, contact or project cards that fulfil the status criteria. The icon is displayed only if you checked **Visualize** in the **Image** tab for the status in question.

* A red X indicates that the status must be regenerated. The [status must be regenerated][4] each time you add, edited or deleted a criterion or if, for example, when you change an intention for a task. Statuses with red crosses are not updated and do not return current data when using SuperOffice CRM.

* **Name** – the name of the statuses. Deleted statuses are displayed in red if checked **Show deleted** is checked.

* **Priority** – the priority of the statuses. The priority determines which status to display if a company, contact or project fulfils the criteria for several statuses.

## Why do I need to specify a status's priority?

A company, contact or project can fulfil the criteria for several different statuses, but it is only possible to show one status image on the company card, contact card or project card in SuperOffice CRM. An order of priority therefore has to be specified for displaying statuses in SuperOffice CRM. If a company, contact or a project does not fulfil the criteria for the highest-priority status, then the status with the next highest priority is displayed. If the company, contact or project does not fulfil these criteria, then the next is displayed and so on.

If a company, contact or project has several active statuses, the lower priority statuses are displayed as links in the status dialog. This dialog is displayed when the user clicks the status image in SuperOffice CRM or selects **Show status information** on the **Company**, **Contact**, or **Project** menu for a company, contact or project with an active status.

## What would you like to do now?

* [Select an image for a status][3]
* [Select a default follow-up type for a status][5]
* [Specify status criteria][6]
* [Specify a period length][7]
* [Manage status monitors][4]

<!-- Referenced links -->
[2]: edit-status.md
[3]: select-image-for-status.md
[4]: manage-status-monitors.md
[5]: select-default-follow-up-type-for-status.md
[6]: select-status-criteria.md
[7]: select-period-length.md
[8]: ../../globalization-and-localization/learn/translate-fields.md
[9]: ../../document/templates/variables/index.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/sale/admin-saint-company.png
