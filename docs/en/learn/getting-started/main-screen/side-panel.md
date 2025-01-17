---
uid: help-en-ui-side-panel
title: Use side panel to work more efficiently
description: The side panel allows you to access information stored in other parts of SuperOffice CRM, without leaving the screen you are on.
keywords: side panel
author: Bergfrid Dias
date: 01.17.2025
version: 10.5
topic: concept
audience: person
audience_tooltip: SuperOffice CRM
language: en
---

# The side panel

The **side panel** is a multifunctional tool located on the right side of every screen in SuperOffice CRM (except the Inbox). It provides quick access to relevant information and complements the main screen.

Use it to manage tasks, view overviews, or follow up on activities, sales, or contacts. The panel's content adapts based on the screen you are in, and it remembers your last view for each screen.

![The side panel is located on the right side of SuperOffice CRM -screenshot][img10]

> [!TIP]
> Minimize the side panel for more workspace by clicking <i class="ph ph-sidebar-simple" aria-label="Sidebar icon"></i> in the upper-right corner.

## Changing the side panel view

By default, the side panel shows a preview of the selected record. You can switch between different views in the side panel to display the information most relevant to your task.

For example, you can display the monthly calendar at the same time as you are viewing the daily calendar in the Diary screen, to give you a better overview, or you can show the members of a selection linked to a project you are looking at in the Project screen.

1. Click <i class="ph ph-caret-down" aria-label="Caret down icon"></i> next to the side panel's name.

1. Select the desired view from the list.

> [!NOTE]
> The available views depend on the active screen.

## Standard views

Here are the most common views available in the side panel, tailored to the active screen.

> [!TIP]
> To quickly view other records without switching screens, click the arrow (<i class="ph ph-caret-down" aria-hidden="true"></i>) next to the record's name in the side panel. This opens the [history list][1], where you can select a different record.

### Preview (default)

Shows a quick preview of selected records, such as contacts or activities, with links to related data. Clicking a link opens the respective dialog, such as the [Follow-up][6] or [Document][5] dialog.

### Calendar views

Stay on top of your schedule with these views:

* **Day:** Agenda for today. Similar to the **Day** tab in the [Diary screen][4].
* **Next day:** Agenda for tomorrow.
* **Week:** Weekly overview of follow-ups.
* **Month:** Monthly calendar, with tooltips for activities and a "bar" indicator for daily workload. Expand the side panel to show multiple months.

You can navigate between dates, weeks, or months using the **Previous** and **Next** buttons (<i class="ph ph-caret-left" aria-hidden="true"></i><i class="ph ph-caret-right" aria-hidden="true"></i>) at the bottom of the side panel.

When you are in the **Diary** screen, navigating to a different week or month in the side panel will also update the Diary view. Similarly, selecting a date, week, or month in the Diary updates the side panel to reflect the change.

> [!NOTE]
> Only your own diary can be shown in the side panel. Use the **Diary** screen to view others' calendars.

### Company

Summarizes information about the current company in the **Company** screen.

### Contact

Displays details about the selected contact in the **Company** or **Selection** screen.

Click the contact's name to open their [contact card][2].

### My favorites

Lists all your [favorites][8].

* Select the checkbox in the footer to filter by screen (for example, **Sales only** in the Sale screen).
* Remove items by selecting them and clicking **Remove**.
* Click <i class="ph ph-arrow-clockwise" aria-label="Refresh"></i> to update the list.
* Right-click a favorite to open the context menu.

### Project

Provides a quick overview of the current project in the **Project** screen.

### Project members

Lists members of the current project in the **Project** screen.

Double-click a project member's name to open their [contact card][2].

### Sale

Summarizes information about the current sale in the **Sale** screen.

### Selection

Summarizes the current selection in the **Selection** screen.

### Selection members

Lists members of the current selection in the **Selection** screen.

## User-defined views

Administrators can define custom views for the side panel in **Settings and maintenance**, tailoring the panel to your team's needs.

## FAQs and tips

* Pin frequently used side panels for easy access at the top of the list by clicking the **star** icon.

    ![Example of the side panel showing the favorites menu with pinned panels for easy access. -screenshot][img1]

* Why is the side panel empty?

  If no contact is specified (for example, in a dynamic selection without **Include main contact**), the Contact side panel will not display information.

* Why do I see "Document Closed" in the side panel?

  This is expected behavior to optimize system resources when using the InfoBridge Document Viewer. To view the document again, return to the document tab and reselect it. Find out more in [this support article][11].

* How can I use the side panel efficiently for sales?

  Use it to track opportunities, monitor overdue activities, and seamlessly follow up on sales proposals without leaving the main screen. For detailed steps, see [Using the side panel for sales][10].

<!-- Referenced links -->
[1]: ../../basics/history.md
[2]: ../../../contact/learn/create.md
[4]: ../../../diary/learn/index.md
[5]: ../../../document/learn/create.md#fields
[6]: ../../../diary/learn/create-follow-up.md
[8]: ../../basics/fav.md
[11]: https://community.superoffice.com/en/support-faqs/faq/what-to-do-when-i-get-document-closed-in-the-side-panel-of-superoffice-crm-when-document-viewer-is-used/
[10]: ../../../sale/learn/index.md#side-panel

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/learn/pin-side-panel-favs.png
[img10]: ../../../../media/loc/en/learn/getstarted-sidepanel-companypreview.png
